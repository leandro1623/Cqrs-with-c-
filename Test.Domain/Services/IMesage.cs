using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IMesage{ }
    public interface IEvent { }

    public interface IStartWithMessage<T> where T : IMesage
    {
        void Star(T value);
    }

    public interface ICanHadleMesage<T> where T : IMesage
    {
        void Handle(T value);
    }

    public interface ICanHandleEvent<T> where T:IEvent
    {
        void Handle(T value);
    }


}
