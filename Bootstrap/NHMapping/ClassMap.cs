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
            this.Id(db => db.id).Column("id");
            this.Map(db => db.name).Column("name");           
            this.Table("user");

        }
    }

}
