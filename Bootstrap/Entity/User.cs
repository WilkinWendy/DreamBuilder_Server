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
        /// 主键
        /// </summary>
        public virtual string Id { get; set; }
       /// <summary>
        /// 姓名
        /// </summary>
        public virtual string Name { get; set; }
       /// <summary>
        /// 密码
        /// </summary>
        public virtual string Password { get; set; }
       /// <summary>
        /// 创建日期
        /// </summary>
        public virtual DateTime? CreateTime { get; set; }

    }
}
