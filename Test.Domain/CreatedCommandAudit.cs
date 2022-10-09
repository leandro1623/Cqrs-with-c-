using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public class CreatedCommandAudit : IEvent
    {
        public string Action { get;  set; }
        public DateTime Date { get;  set; }
    }
}
