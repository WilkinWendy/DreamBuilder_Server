using Bootstrap.Core;
using Bootstrap.Entity;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootstrap.NHMapping
{
    class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(db => db.Id).Column("Id").GeneratedBy.Custom<UUIDGenerator>();//主键
            Map(db => db.Name).Column("Name");//姓名
            Map(db => db.Password).Column("Password");//密码
            Map(db => db.CreateTime).Column("CreateTime");//创建日期

            Table("User");
        }
    }

}
