using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IContext
    {
        void Add<T>(T value) where T : Aggregate;
        void _Add(Person value);
        IQueryable<Person> People(bool trackingChanges = false, bool IncludeProducts = false);
        IQueryable<T> GenericEntity<T>(bool trackingChanges = false) where T : Aggregate;
        int _SaveChanges();
        void Delete<T>(T val) where T : Aggregate;
    }
}
