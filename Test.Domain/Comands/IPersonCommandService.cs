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
        private IServiceBus Svb;

        public PersonCommandService(IContext context, IServiceBus svb)
        {
            this.Context = context;
            this.Svb = svb;
        }


        public void Star(CreatedCommnadPerson value)
        {

            Person person = Person.BuildAPerson(value.Name, value.LastName, value.Age.ToString(), value.Address, value.PersonProducts);

            this.Context._Add(person);
            this.Context._SaveChanges();

            //event
            CreatedCommandAudit cmdAudit = new CreatedCommandAudit() { Action = string.Format("Person with id = {0} created",person.Id), Date = DateTime.Now };

            this.Svb.HandleEvent(cmdAudit);
            
            
        }
    }

}
