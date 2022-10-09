using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IAuditCommandService : ICanHandleEvent<CreatedCommandAudit>
    {

    }

    public class AuditCommandService : IAuditCommandService
    {
        private IContext Context;

        public AuditCommandService(IContext context)
        {
            Context = context;
        }

        public void Handle(CreatedCommandAudit value)
        {
            AuditEntry audit = AuditEntry.CreateNew(value.Action, value.Date);

            Context.Add(audit);
            this.Context._SaveChanges();
        }
    }
}
