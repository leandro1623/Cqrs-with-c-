using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public class Product : Aggregate
    {
        public string Name { get; protected set; }
        public string Category { get; protected set; }
        public double Price { get; protected set; }
        
        //relation

        /// <summary>
        /// Construct for entity
        /// </summary>
        protected Product() { }

        public static Product CreateNew(string name, string category, double value)
        {
            Validate.NotNullOrEmpty(name, "Product.Name is required");
            Validate.NotNullOrEmpty(category, "Product.Category is required");
            Validate.NotNull(value, "Product.Value is required");


            return new Product()
            {
                Name = name,
                Category = category,
                Price = value
            };
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Name, this.Category, this.Price);
        }

    }
}
