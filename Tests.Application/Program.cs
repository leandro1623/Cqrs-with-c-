using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;
using Test.Services;

namespace Tests.Application
{
    class Program
    {
        private static IServiceInjector Injector;

        static void Main(string[] args)
        {
            //init
            Injector = new ServiceInjector();

            //body
            IQweryService qwery = Injector.Get<IQweryService>();

            List<Person> people = new List<Person>();

            
            people = qwery.People(true).ToList();
            

            Product name =  people[1].Products[0].Product;

            //List<PersonProduct> personProducts = qwery.Entities<PersonProduct>().IncludeProduct().ToList();

            //WriteToDb();

            //Show on display

            Console.WriteLine(name.ToString());
        }

        private static void WriteToDb()
        {

            IServiceBus serviceBus = Injector.Get<IServiceBus>();

            List<PersonProduct> personProducts = new List<PersonProduct>();
            personProducts.Add(PersonProduct.CreateNew(null, Product.CreateNew("shampoo", "utils", 5000)));
            personProducts.Add(PersonProduct.CreateNew(null, Product.CreateNew("hoa", "utils", 6909)));


            CreatedCommnadPerson personCom = new CreatedCommnadPerson()
            {
                Name = "Prueba",
                LastName = "ApellidoPrueba",
                Age = 3,
                Address = "Direccion de prueba",
                PersonProducts = personProducts
            };

            serviceBus.StartMessage(personCom);
        }

        public void Extencion(IServiceInjector injector)
        {
            Test test = injector.Get<Test>();

            foreach (int val in test.List())
            {
                Console.WriteLine(val);
            }

            Console.ReadKey();
        }

        public class Test
        {
            List<int> pairs;
            public Test(IServicePerdicate pred)
            {
                pairs = pred.GetPairs(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            }

            public List<int> List()
            {
                return pairs;
            }
        }

    }



}
