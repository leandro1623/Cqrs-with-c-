using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain
{
    public interface IPersonCommandService : IStartWithMessage<CreatedCommnadPerson>
    {

    }

    public class PersonCommandService : IPersonCommandService
    {
        private IContext Context;

        public PersonCommandService(IContext context)
        {
            this.Context = context;
        }


        public void Star(CreatedCommnadPerson value)
        {

            Person person = Person.BuildAPerson(value.Name, value.LastName, value.Age.ToString(), value.Address, value.PersonProducts);

            this.Context._Add(person);
            this.Context._SaveChanges();
        }
    }

}
