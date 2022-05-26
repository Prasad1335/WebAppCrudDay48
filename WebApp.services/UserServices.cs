using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using WebApp.services.Models;

namespace WebApp.services
{
    public class UserServices
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["UserManagement"].ConnectionString;

        public List<User> GetAll()
        {
            var users = new List<User>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "User_GetAll";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var user = new User
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                DateOfBirth = (DateTime)reader["DateOfBirth"],
                                Pan = (string)reader["Pan"],
                                Address = reader["Address"] == null ? (string)reader["Address"] : "null",
                                Gender = (string)reader["Gender"],
                                //   MobileNumber = reader["MobileNumber"] == null ? (string)reader["MobileNumber"] : "null",
                                Email = reader["Email"] == null ? (string)reader["Email"] : "null",
                                Comments = reader["Comments"] == null ? (string)reader["Comments"] : "null",
                                // DepartmentRefId = (int)reader["DepartmentRefId"],
                            };


                            users.Add(user);
                        }
                    }
                }
            }

            return users;
        }

        public void Add(User user)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "User_Add";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@Pan", user.Pan);
                    command.Parameters.AddWithValue("@Address", user.Address);
                    command.Parameters.AddWithValue("@Gender", user.Gender);
                    command.Parameters.AddWithValue("@MobileNumber", user.MobileNumber);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Comments", user.Comments);
                    command.Parameters.AddWithValue("@DepartmentRefId", user.DepartmentRefId);

                    connection.Open();

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }

        public void Update(User user)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "User_Update";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@Pan", user.Pan);
                    command.Parameters.AddWithValue("@Address", user.Address);
                    command.Parameters.AddWithValue("@Gender", user.Gender);
                    command.Parameters.AddWithValue("@MobileNumber", user.MobileNumber);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Comments", user.Comments);
                    command.Parameters.AddWithValue("@DepartmentRefId", user.DepartmentRefId);

                    connection.Open();

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "User_Delete";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected != 1)
                        throw new Exception("Add returned 0 rows affected. Expecting 1 rows affected");
                }
            }
        }

        public User GetById(int id)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                const string cmdText = "User_GetById";

                using (var command = new SqlCommand(cmdText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var user = new User
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                DateOfBirth = (DateTime)reader["DateOfBirth"],
                                Pan = (string)reader["Pan"],
                                Address = reader["Address"] == null ? (string)reader["Address"] : "null",
                                Gender = (string)reader["Gender"],
                                // MobileNumber = reader["MobileNumber"] == null ? (string)reader["MobileNumber"] : "null",
                                Email = reader["Email"] == null ? (string)reader["Email"] : "null",
                                Comments = reader["Comments"] == null ? (string)reader["Comments"] : "null",
                            };
                            return user;
                        }
                    }
                }
            }

            return null;
        }


    }
}
