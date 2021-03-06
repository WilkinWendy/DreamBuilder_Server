﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootstrap.Common;
using Bootstrap.Entity;
using Bootstrap.Entity.Common;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using NSwag.Annotations;
using Unity;

namespace Bootstrap.Controllers
{
    [OpenApiTag("User",Description = "用户类接口")]
    [Route("api/user")]
    [ApiController]
    public class UserController : BaseEntityController<User>
    {
        /// <summary>
        /// 根据用户id获取用户信息
        /// </summary>
        /// <param name="id">主键id</param>
        /// <returns></returns>
        public override ActionResult<HttpResponseType<User>> GetById([FromQuery] string id)
        {
            return base.GetById(id);          
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public override ActionResult<HttpResponseType<string>> Add(User dto)
        {
            dto.CreateTime = DateTime.Now;
            return base.Add(dto);
        }
    }
}
