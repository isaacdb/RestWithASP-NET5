using RestWithASPNET.Model;
using RestWithASPNET.Model.Context;
using RestWithASPNET.Service.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNET.Service
{
    public class PersonService : IPersonService
    {
        private MySqlContext _mySqlContext;

        public PersonService(MySqlContext mySqlContext)
        {
            _mySqlContext = mySqlContext;
        }

        public Person Create(Person person)
        {
            return PersonMock();
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            return _mySqlContext.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return PersonMock();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }

        private Person PersonMock()
        {
            return new Person
            {
                Id = 1,
                FirstName = "Isaac",
                LastName = "Debiasi",
                Adress = "Criciuma - SC",
                Gender = "Male"
            };
        }
    }
}
