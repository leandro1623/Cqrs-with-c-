using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{

    public interface IServicePerdicate
    {
        List<int> GetPairs(List<int> collection);
        bool IsPair(int num);
    }

    public class Predicate : IServicePerdicate
    {
        public List<int> GetPairs(List<int> collection)
        {
            Predicate<int> pred = new Predicate<int>(IsPair);

            return collection.FindAll(pred);
        }

        public bool IsPair(int num)
        {
            return num % 2 == 0 ? true : false;
        }
    }
}
