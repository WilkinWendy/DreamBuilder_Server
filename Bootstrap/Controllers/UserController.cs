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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseEntityController<User>
    {
       
    }
}
