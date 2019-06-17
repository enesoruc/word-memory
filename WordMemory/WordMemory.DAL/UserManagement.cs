using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.CustomException;
using WordMemory.DTO;
using WordMemory.Model;

namespace WordMemory.DAL
{
    public class UserManagement
    {
        Helper h;
        UserReportDTO userReportDTO;

        public UserManagement()
        {
            h = new Helper();

        }

        /// <summary>
        /// Kullanıcıyı DB'ye kaydeder. User parametresinin tüm değerleri dolu olmalı. 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Insert(User user)
        {
            string query = @"INSERT INTO [User] VALUES (@userID,@roleID,@firstName,@lastname,@birthDate,@email,@password,@createdDate,@isActive)";

            List<SqlParameter> parameters = GetParameters(user, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }



        /// <summary>
        /// Kullanıcıyı günceller.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int Update(User user)
        {
            string query = "UPDATE [User] SET RoleID = @roleID ,FirstName = @firstName, LastName = @lastName , BirthDate = @birthDate , Email = @email , Password = @password , IsActive = @isActive WHERE UserID = @userID";

            List<SqlParameter> parameters = GetParameters(user, false);

            h.AddParametersToCommand(parameters);

            return h.MyExecuteNonQuery(query);
        }
        public int DeleteAccount(Guid UserID)
        {
            string query = "UPDATE [User] SET IsActive=@IsActive WHERE UserID=@userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = UserID
                },
                 new SqlParameter()
                {
                    ParameterName = "@IsActive",
                    Value = false
                }
            });
            return h.MyExecuteNonQuery(query);
        }

        public List<User> GetAllUser()
        {
            List<User> allUsers = new List<User>();

            string query = "SELECT * FROM [User]";

            User currentUser;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentUser = new User()
                {
                    UserID = (Guid)reader["UserID"],
                    RoleID = (byte)reader["RoleID"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                    IsActive = (bool)reader["IsActive"]
                };
                allUsers.Add(currentUser);
            }
            reader.Close();

            return allUsers;
        }


        public User UserLogin(LoginDTO loginDTO)
        {

            string queryEmail = "SELECT * FROM [User] WHERE Email = @email";

            h.AddParametersToCommand(GetParametersForLogin(loginDTO, false));

            SqlDataReader reader = h.MyExecuteReader(queryEmail);
            if (!reader.HasRows)
            {
                reader.Close();
                throw new WrongEmailLoginException();
            }
            reader.Close();

            string queryPasswordAndEmail = "SELECT * FROM [User] WHERE Email = @email AND Password = @password AND IsActive=@IsActive";

            h.AddParametersToCommand(GetParametersForLogin(loginDTO, true));

            reader = h.MyExecuteReader(queryPasswordAndEmail);
            if (!reader.HasRows)
            {
                reader.Close();
                throw new WrongPasswordLoginException();
            }

            User currentUser;
            reader.Read();
            currentUser = new User()
            {
                UserID = (Guid)reader["UserID"],
                RoleID = (byte)reader["RoleID"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                Email = reader["Email"].ToString(),
                Password = reader["Password"].ToString(),
                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                IsActive = (bool)reader["IsActive"]
            };
            reader.Close();

            return currentUser;
        }

        public int GetPoolCountByUserID(Guid userID)
        {

            string query = @"SELECT COUNT(UserID) AS PoolCount FROM WordPool WHERE IsActive = @isActive AND UserID = @userID GROUP BY UserID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                },
                new SqlParameter()
                {
                    ParameterName = "@isActive",
                    Value = true
                }
            });

            return h.MyExecuteScalar(query);

        }


        public List<User> GetUsersByRoleID(Guid roleID)
        {
            List<User> allUsers = new List<User>();

            string query = "SELECT * FROM [User] WHERE RoleID=@roleId";

            SqlDataReader reader = h.MyExecuteReader(query);
            User currentUser;

            while (reader.Read())
            {
                currentUser = new User()
                {
                    UserID = (Guid)reader["UserID"],
                    RoleID = (byte)reader["RoleID"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString(),
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                    IsActive = (bool)reader["IsActive"]
                };
                allUsers.Add(currentUser);
            }

            reader.Close();

            return allUsers;
        }


        public User GetUserByID(Guid userID)
        {
            string query = "SELECT * FROM [User] WHERE UserID = @userID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@userID",
                    Value = userID
                }
            });

            User currentUser;
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentUser = new User()
            {
                UserID = userID,
                RoleID = (byte)reader["RoleID"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                Email = reader["Email"].ToString(),
                Password = reader["Password"].ToString(),
                CreatedDate = Convert.ToDateTime(reader["CreatedDate"]),
                IsActive = (bool)reader["IsActive"]
            };
            reader.Close();
            return currentUser;
        }



        List<SqlParameter> GetParameters(User user, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@userID", user.UserID));
            if (isInsert)
            {
                parameters.Add(new SqlParameter("@createdDate", DateTime.Now));
                parameters.Add(new SqlParameter("@roleID", 3));
            }
            else
            {
                parameters.Add(new SqlParameter("@roleID", user.RoleID));
            }
            parameters.Add(new SqlParameter("@firstName", user.FirstName));
            parameters.Add(new SqlParameter("@lastname", user.LastName));
            parameters.Add(new SqlParameter("@birthDate", user.BirthDate));
            parameters.Add(new SqlParameter("@email", user.Email));
            parameters.Add(new SqlParameter("@password", user.Password));
            parameters.Add(new SqlParameter("@isActive", user.IsActive));

            return parameters;
        }

        List<SqlParameter> GetParametersForLogin(LoginDTO loginDTO, bool control)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (control)
            {
                parameters.Add(new SqlParameter("@password", loginDTO.Password));
                parameters.Add(new SqlParameter("@IsActive", true));
            }

            parameters.Add(new SqlParameter("@email", loginDTO.Email));

            return parameters;
        }
        public List<UserReportDTO> GetUserReportBetweenDateRange(string startDate, string endDate)
        {
            List<UserReportDTO> UserReportList = new List<UserReportDTO>();

            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@startdate",
                    Value=startDate
                },
                new SqlParameter()
                {
                    ParameterName="@enddate",
                    Value=endDate
                }
            });
            SqlDataReader reader = h.ExecuteSpReader("sp_UserPracticeYearlyReport");
            while (reader.Read())
            {
                userReportDTO = new UserReportDTO();
                userReportDTO.Name = reader[0].ToString();
                userReportDTO.WordCount = (int)reader[1];

                UserReportList.Add(userReportDTO);
            }
            reader.Close();
            return UserReportList;
        }

        public List<UserReportDTO> GetWordUserReportByWeek(string date)
        {
            List<UserReportDTO> WordUserReportList = new List<UserReportDTO>();

            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@date",
                    Value=date
                }
            });
            SqlDataReader reader = h.ExecuteSpReader("sp_UserPracticeReportByWeek");
            while (reader.Read())
            {
                userReportDTO = new UserReportDTO();
                userReportDTO.Name = reader[0].ToString();
                userReportDTO.WordCount = (int)reader[1];
                WordUserReportList.Add(userReportDTO);
            }
            reader.Close();
            return WordUserReportList;
        }

        public List<UserReportDTO> GetWordUserReportByMonth(string date)
        {
            List<UserReportDTO> WordUserReportList = new List<UserReportDTO>();

            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@date",
                    Value=date
                }
            });
            SqlDataReader reader = h.ExecuteSpReader("sp_UserPracticeReportByMonth");
            while (reader.Read())
            {
                userReportDTO = new UserReportDTO();
                userReportDTO.Name = reader[0].ToString();
                userReportDTO.WordCount = (int)reader[1];
                WordUserReportList.Add(userReportDTO);
            }
            reader.Close();
            return WordUserReportList;
        }
    }
}
