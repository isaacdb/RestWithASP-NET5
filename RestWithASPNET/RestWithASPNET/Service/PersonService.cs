using RestWithASPNET.Model;
using RestWithASPNET.Service.Implementation;
using System;
using System.Collections.Generic;

namespace RestWithASPNET.Service
{
    public class PersonService : IPersonService
    {
        public Person Create(Person person)
        {
            return PersonMock();
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            var result = new List<Person>();

            for (int i = 0; i < 5; i++)
            {
                result.Add(PersonMock());
            }

            return result;
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
