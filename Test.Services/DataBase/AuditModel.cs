using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;

namespace Test.Services
{
    public class AuditModel : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AuditEntry>
    {
        public AuditModel()
        {
            this.ToTable("Audit");
        }
    }
}
