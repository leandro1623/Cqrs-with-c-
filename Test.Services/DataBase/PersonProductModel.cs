using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;

namespace Test.Services
{
    public class PersonProductModel : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PersonProduct>
    {
        public PersonProductModel()
        {
            this.ToTable("Person-Product");

            this.HasRequired(p => p.Product).WithMany().Map(m => m.MapKey("ProductId"));
        }
    }
}
