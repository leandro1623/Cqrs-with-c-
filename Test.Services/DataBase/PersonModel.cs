using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;

namespace Test.Services
{
    public class PersonModel : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Person>
    {
        public PersonModel()
        {
            this.ToTable("Person");

            this.HasMany(p => p.Products).WithRequired(p=>p.Person).Map(m => m.MapKey("PersonId"));
            //this.HasRequired(p => p.Product.Value).WithMany().Map(m => m.MapKey("Value")); error
        }

    }
}
