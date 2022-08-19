using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;

namespace Test.Services
{
    public class ProductModel : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Product>
    {
        public ProductModel()
        {
            this.ToTable("Products");
        }
    }
}
