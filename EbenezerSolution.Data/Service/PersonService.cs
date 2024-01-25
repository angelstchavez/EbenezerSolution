using Dapper;
using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EbenezerSolution.Data.Service
{
    public class PersonService : IPersonService
    {
        private string _ConnectionString;

        public PersonService()
        {
            _ConnectionString = MasterConnection.ConnectionString;
        }

        public bool Create(Person person)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    person.FullName,
                    person.Gender,
                    person.NumberPhone,
                    person.Address,
                    person.BirthDate,
                    person.User.Id
                };

                var affectedRows = dbConnection.Execute("InsertPerson", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { Id = id };

                var affectedRows = dbConnection.Execute("DeletePerson", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public IEnumerable<Person> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Person>("GetAllPersons", commandType: CommandType.StoredProcedure);
            }
        }

        public Person Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { Id = id };

                return dbConnection.QueryFirstOrDefault<Person>("GetPersonById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Person> Search(string term)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new { Term = term };

                return dbConnection.Query<Person>("SearchPersons", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public bool Update(Person person)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    person.Id,
                    person.FullName,
                    person.Gender,
                    person.NumberPhone,
                    person.Address,
                    person.BirthDate,
                    UserId = person.User?.Id
                };

                var affectedRows = dbConnection.Execute("UpdatePerson", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public IEnumerable<Person> GetAllpaginated(int pageSize, int pageNumber)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                };

                return dbConnection.Query<Person>("GetPersonsPaginated", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
