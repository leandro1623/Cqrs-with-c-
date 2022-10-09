using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public class AuditEntry : Aggregate
    {
        public string Action { get; protected set; }
        public DateTime Date { get; protected set; }


        protected AuditEntry() { }

        public static AuditEntry CreateNew(string action, DateTime date)
        {
            Validate.NotNull(action, "Audit.Action is required");
            Validate.NotNullDate(date, "Audit.Date Is required");

            return new AuditEntry()
            {
                Action = action,
                Date = date
            };
        }

    }

}
