using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Test.Domain
{
    public static class PesonQweryExtencion
    {

        public static IQueryable<Person> IncludeProducts(this IQueryable<Person> qwery)
        {
            return qwery.Include(p => p.Products);
        }


        public static IQueryable<PersonProduct> IncludeProduct(this IQueryable<PersonProduct> qwery)
        {
            return qwery.Include(p => p.Product);

        }

    }
}
