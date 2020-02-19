using NHibernate.Engine;
using NHibernate.Id;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bootstrap.Core
{
    /// <summary>
    /// 自定义id生成器，如果已经指派则使用指派了的，没有指派则使用Guid来生成36位字符串主键
    /// </summary>
    public class UUIDGenerator : IIdentifierGenerator
    {
        public object Generate(ISessionImplementor session, object obj)
        {
            string assignedId = (string)(session.GetEntityPersister(session.GuessEntityName(obj), obj).GetIdentifier(obj));

            if (String.IsNullOrWhiteSpace(assignedId)){
                assignedId = Guid.NewGuid().ToString();
            }

            return assignedId;
        }

        public Task<object> GenerateAsync(ISessionImplementor session, object obj, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
