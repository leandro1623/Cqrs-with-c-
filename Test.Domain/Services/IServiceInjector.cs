using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IServiceInjector
    {
        object Get(Type value);
        T Get<T>();
        List<Type> GetTypes();
    }
}
