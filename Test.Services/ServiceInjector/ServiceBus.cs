using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;

namespace Test.Services
{
    public class ServiceBus : IServiceBus
    {
        private IServiceInjector Injector;

        public ServiceBus(IServiceInjector injector)
        {
            this.Injector = injector;
        }

        private List<T> GetAssignablesServices<T>() where T:class
        {
            Type lookType = typeof(T);
            List<T> Lista = new List<T>();
            foreach(Type type in Injector.GetTypes())
            {
                if (lookType.IsAssignableFrom(type))
                {
                    Lista.Add(Injector.Get(type) as T);
                }
            }
            return Lista;
        }

        public void StartMessage<T>(T value) where T : IMesage
        {
            List<IStartWithMessage<T>> srvs = GetAssignablesServices<IStartWithMessage<T>>();
            
            foreach(IStartWithMessage<T> serv in srvs)
            {
                serv.Star(value);   
            }
        }

        public void HandleEvent<T>(T value) where T : IEvent
        {
            List<ICanHandleEvent<T>> Events = GetAssignablesServices<ICanHandleEvent<T>>();

            foreach(ICanHandleEvent<T> handleEvent in Events)
            {
                handleEvent.Handle(value);
            }
        }
    }
}
