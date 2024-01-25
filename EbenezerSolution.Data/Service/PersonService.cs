using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Service
{
    public class PersonService : IPersonService
    {
        private string _ConnectionString;

        public PersonService()
        {
            _ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Person entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Person> GelAll()
        {
            throw new System.NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Person> Search(string term)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Person entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
