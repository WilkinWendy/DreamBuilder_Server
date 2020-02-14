using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bootstrap.Entity;
using Microsoft.AspNetCore.Mvc;
using NHibernate;
using Unity;

namespace Bootstrap.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : BaseSessionController
    {      
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            try
            {
                using (ISession session = sessionFactory.OpenSession())
                {
                    List<User> list = session.Query<User>().ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
          
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
