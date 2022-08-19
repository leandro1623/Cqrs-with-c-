using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Domain;


namespace Test.Services
{
    public class ServiceInjector : IServiceInjector
    {
        private IKernel Kernel;
        private List<Type> Types;

        public ServiceInjector()
        {
            Kernel = new StandardKernel();
            Types = new List<Type>();


            //set the implemetation of services
            Kernel.Bind<IServiceInjector>().ToConstant(this);
            Types.Add(typeof(IServiceInjector));
            
            Kernel.Bind<IServicePerdicate>().To<Predicate>();
            Types.Add(typeof(IServicePerdicate));
            Kernel.Bind<IContext>().To<Context>();
            Types.Add(typeof(IContext));
            Kernel.Bind<IServiceBus>().To<ServiceBus>();
            Types.Add(typeof(IServiceBus));

            //commands
            Kernel.Bind<IPersonCommandService>().To<PersonCommandService>();
            Types.Add(typeof(IPersonCommandService));
            //qweries
            Kernel.Bind<IQweryService>().To<QweryService>();
            Types.Add(typeof(IQweryService));


        }

        public object Get(Type value)
        {
            return this.Kernel.Get(value);
        }

        public T Get<T>()
        {
            return this.Kernel.Get<T>();
        }

        public List<Type> GetTypes()
        {
            return this.Types;
        }
    }
}
