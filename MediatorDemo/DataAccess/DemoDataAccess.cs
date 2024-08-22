using MediatorDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> _persons = new();

        public DemoDataAccess()
        {
            _persons.Add(new PersonModel
            {
                Id = 1,
                FirstName = "Nguyen",
                Name = "Nguyen Viet Minh Tien",
                LastName = "Tien"
            });
            _persons.Add(new PersonModel
            {
                Id = 2,
                FirstName = "Quynh",
                Name = "Nguyen Nhu Quynh",
                LastName = "Nhu"
            });
        }

        public List<PersonModel> GetPeople()
        {
            return _persons;
        }

        public PersonModel InsertPerson(string name, string lastname, string full_name, string first_name)
        {
            PersonModel person = new PersonModel
            {
                FirstName = first_name,
                LastName = lastname,
                Name = full_name,
            };
            person.Id = _persons.Max(x => x.Id) + 1;
            _persons.Add(person);
            return person;
        }
    }
}
