using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Entity
{
    public class User
    {
        public virtual string id { get; set; }
        public virtual string name { get; set; }
        public virtual string password { get; set; }
    }
}
