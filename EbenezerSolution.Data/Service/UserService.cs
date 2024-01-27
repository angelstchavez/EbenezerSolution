using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using EbenezerSolution.Entity;
using EbenezerSolution.Data.Connection;
using EbenezerSolution.Data.Interface;

namespace EbenezerSolution.Data.Service
{
    public class UserService : IUserService
    {
        private string _connectionString;

        public UserService()
        {
            _connectionString = MasterConnection.ConnectionString;
        }

        public bool Create(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    Username = user.Username,
                    Password = user.Password,
                    IsActive = user.UserIsActive,
                    RoleId = user.Role.Id
                };

                var affectedRows = connection.Execute("CreateUser", parameters, commandType: System.Data.CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    UserId = id
                };

                var affectedRows = connection.Execute("DeleteUser", parameters, commandType: System.Data.CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<User, Role, User>("GetAllUsers", (user, role) =>
                {
                    user.Role = role;
                    return user;
                },
                splitOn: "UserRoleId",
                commandType: System.Data.CommandType.StoredProcedure)
                .ToList();
            }
        }

        public User Get(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    UserId = id
                };

                return connection.Query<User, Role, User>("GetUserById", (user, role) =>
                {
                    user.Role = role;
                    return user;
                },
                parameters,
                splitOn: "RoleId",
                commandType: System.Data.CommandType.StoredProcedure)
                .FirstOrDefault();
            }
        }

        public IEnumerable<User> Search(string term)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    SearchTerm = term
                };

                return connection.Query<User, Role, User>("SearchUsers", (user, role) =>
                {
                    user.Role = role;
                    return user;
                },
                parameters,
                splitOn: "RoleId",
                commandType: System.Data.CommandType.StoredProcedure)
                .ToList();
            }
        }

        public bool Update(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var parameters = new
                {
                    UserId = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    IsActive = user.UserIsActive,
                    RoleId = user.Role.Id
                };

                var affectedRows = connection.Execute("UpdateUser", parameters, commandType: System.Data.CommandType.StoredProcedure);

                return affectedRows > 0;
            }
        }

        public int Count()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.ExecuteScalar<int>("CountUsers", commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
