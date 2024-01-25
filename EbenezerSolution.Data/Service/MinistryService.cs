using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Service
{
    public class MinistryService : IMinistryService
    {
        private string _ConnectionString;

        public MinistryService()
        {
            _ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Ministry entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ministry> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Ministry Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Ministry> Search(string term)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Ministry entity)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }
    }
}
