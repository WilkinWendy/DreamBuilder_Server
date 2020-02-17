using Bootstrap.Controllers;
using Bootstrap.Entity.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Common
{
    /// <summary>
    /// 针对表对象的通用操作控制器
    /// </summary>
    /// <typeparam name="T">表对象实体泛型</typeparam>
    public abstract class BaseEntityController<T> : BaseSessionController where T : class
    {
        /// <summary>
        /// 根据主键id获取表实体对象
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns></returns>
        [HttpGet("getById")]
        public virtual ActionResult<HttpResponseType<T>> GetById([FromQuery] string id)
        {
            try
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    T obj = session.Get<T>(id);
                    if (obj == null)
                    {
                        return HttpResponseType.Failure<T>("id不存在");
                    }
                    return HttpResponseType.Success<T>(obj);
                }
            }
            catch (Exception ex)
            {
                return HttpResponseType.Failure<T>(ex.Message, HttpResponseTypeCode.Exception);
            }
        }

        /// <summary>
        /// 通用新增方法
        /// 注意：如果NH不代理主键的生成，将不会取到主键，强烈建议使用NH代理主键的生成
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public virtual ActionResult<HttpResponseType<T>> Add(T dto)
        {
            try
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    T obj = session.Save(dto) as T;             
                    return HttpResponseType.Success(obj);
                }
            }
            catch (Exception ex)
            {
                return HttpResponseType.Failure<T>(ex.Message, HttpResponseTypeCode.Exception);
            }
        }

        /// <summary>
        /// 根据主键id删除表对象
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("delete")]
        public virtual ActionResult<HttpResponseType<bool>> DeleteById(string id)
        {
            try
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    T query = session.Get<T>(id);
                    if (query == null)
                    {
                        return HttpResponseType.Failure<bool>("id不存在");
                    }

                    session.Delete(query);
                    return HttpResponseType.Success(true);
                }
            }
            catch (Exception ex)
            {
                return HttpResponseType.Failure<bool>(ex.Message, HttpResponseTypeCode.Exception);
            }
        }

        /// <summary>
        /// 更新表对象，将根据主键来进行唯一判定
        /// </summary>
        /// <param name="dto">表对象</param>
        /// <returns></returns>
        [HttpPost("update")]
        public virtual ActionResult<HttpResponseType<bool>> update(T dto)
        {
            try
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    session.Update(dto);
                    session.Flush();
                    return HttpResponseType.Success(true);
                }
            }
            catch (Exception ex)
            {
                return HttpResponseType.Failure<bool>(ex.Message, HttpResponseTypeCode.Exception);
            }
        }

    }
}
