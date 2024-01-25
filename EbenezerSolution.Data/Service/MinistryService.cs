using Dapper;
using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;
using EbenezerSolution.Entity;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    entity.Name,
                    entity.IsActive
                };

                var affectedRows = dbConnection.Execute("CreateMinistry", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public bool Update(Ministry entity)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    entity.Id,
                    entity.Name,
                    entity.IsActive
                };

                var affectedRows = dbConnection.Execute("UpdateMinistry", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    Id = id
                };

                var affectedRows = dbConnection.Execute("DeleteMinistry", parameters, commandType: CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public IEnumerable<Ministry> GetAll()
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Ministry>("GetAllMinistries", commandType: CommandType.StoredProcedure);
            }
        }

        public Ministry Get(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    Id = id
                };

                return dbConnection.QueryFirstOrDefault<Ministry>("GetMinistryById", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<Ministry> Search(string term)
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                var parameters = new
                {
                    Term = term
                };

                return dbConnection.Query<Ministry>("SearchMinistries", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public int Count()
        {
            using (IDbConnection dbConnection = new SqlConnection(_ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.QueryFirstOrDefault<int>("CountMinistries", commandType: CommandType.StoredProcedure);
            }
        }
    }
}
