using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.Entity
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public virtual string id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public virtual string name { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public virtual string password { get; set; }
    }
}
