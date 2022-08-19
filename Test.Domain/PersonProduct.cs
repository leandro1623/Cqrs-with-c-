using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public class PersonProduct  : Aggregate
    {
        public Person Person { get; protected set; }
        public Product Product { get; protected set; }

        //Construc to entity
        protected PersonProduct() { }


        public static PersonProduct CreateNew(Person person = null, Product product = null)
        {
            return new PersonProduct() { Person = person, Product = product };
        }

    }
}
