using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using Test.Domain;

namespace Test.Services
{
    public class Context : DbContext, IContext
    {
        public Context() : base("StringC")
        {
            Database.SetInitializer<Context>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PersonModel());
            modelBuilder.Configurations.Add(new ProductModel());
            modelBuilder.Configurations.Add(new PersonProductModel());
        }

        public void Add<T>(T value) where T: Aggregate
        {
            this.Set<T>().Add(value);
        }

        public void _Add(Person value)
        {
            try
            {
                this.Set<Person>().Add(value);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public IQueryable<Person> People(bool trackingChanges = false, bool IncludeProducts = false)
        {
            IQueryable<Person> Qwery = this.Set<Person>();

            if (trackingChanges)
                return Qwery.AsNoTracking();

            if (IncludeProducts)
                return Qwery.IncludeProducts();

            return Qwery.IncludeProducts();
        }

        /// <summary>
        /// Generic entity from de data base it has to be a agregate
        /// </summary>
        public IQueryable<T> GenericEntity<T>(bool trackingChanges = false) where T : Aggregate
        {
            IQueryable<T> Qwery = this.Set<T>();

            if (trackingChanges)
                return Qwery.AsNoTracking();

            return Qwery;
        }

        public int _SaveChanges()
        {
            return this.SaveChanges();
        }

        public void Delete<T>(T val)where T: Aggregate
        {
            this.Set<T>().Remove(val);
        }
    }
}
