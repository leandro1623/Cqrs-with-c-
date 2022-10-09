using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public static class Validate
    {
        public static void NotNull<T>(T value, string msg)
        {
            if(value == null)
            {
                throw new InvalidOperationException(msg);
            }
        }

        public static void NotNullOrEmpty(string value, string msg)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidOperationException(msg);
            }
        }


        public static void NotNullDate(DateTime date, string msg)
        {
            if (date == DateTime.MinValue)
                throw new InvalidOperationException(msg);
        }




    }   
}
