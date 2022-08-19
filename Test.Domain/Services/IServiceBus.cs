using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IServiceBus
    {
        void StartMessage<T>(T value) where T : IMesage;
    }
}
