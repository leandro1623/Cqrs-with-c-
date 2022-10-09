using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public class Person : Aggregate
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }
        public string Age { get; protected set; }
        public string Address { get; protected set; }

        //product
        public List<PersonProduct> Products { get; protected set; }
        

        //constructor to entity
        protected Person() { }

        //factory function
        public static Person BuildAPerson(string name, string lastname,string age, string address="NO AVIABLE", List<PersonProduct> product = null)
        {
            Validate.NotNullOrEmpty(name, "Person.Name is required");
            Validate.NotNullOrEmpty(lastname, "Person.LastName is required");
            Validate.NotNullOrEmpty(address, "Person.Address is required");
            Validate.NotNull(age, "Person.Age is required");

            return new Person()
            {
                Name = name,
                LastName = lastname,
                Age = age,
                Address = address,
                Products = product
            };
        }
    }
}
