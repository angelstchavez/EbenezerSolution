using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System.Collections.Generic;

namespace EbenezerSolution.Data.Service
{
    public class UserService : IUserService
    {
        private string _connectionString;

        public UserService()
        {
            _connectionString = MasterConnection.ConnectionString;
        }

        public bool Create(User entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<User> Search(string term)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }
    }
}
