using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootstrap.Common;
using Bootstrap.Entity;
using Bootstrap.Entity.Common;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using Unity;

namespace Bootstrap.Controllers
{
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
    }
}
