using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IQweryService
    {
        List<Person> People(bool IncludeProducts = false);
        List<T> Entities<T>() where T : Aggregate;
    }

    public class QweryService : IQweryService
    {
        private IContext Context;

        public QweryService(IContext context)
        {
            this.Context = context;
        }

        public List<T> Entities<T>() where T : Aggregate
        {
            return Context.GenericEntity<T>().ToList();
        }

        public List<Person> People(bool IncludeProducts = false)
        {
                return this.Context.People(false, IncludeProducts).ToList();
        }
    }
}
