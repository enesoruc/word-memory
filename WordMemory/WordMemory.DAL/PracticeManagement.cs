using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.DTO;
using WordMemory.Model;

namespace WordMemory.DAL
{
    public class PracticeManagement
    {
        Helper h;
        public PracticeManagement()
        {
            h = new Helper();
        }

        // Insert , Add , Update , GetData , Get All Data 

        public int Insert(Practice practice)
        {
            string query = "Insert into Practice values(@practiceID,@practiceTypeID,@practiceDate,@trueAnswer,@falseAnswer,@practiceTime)";
            List<SqlParameter> parameters = GetParameters(practice, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }

        public int Update(Practice practice)
        {
            string query = @"UPDATE Practice SET TrueAnswer= @trueAnswer, FalseAnswer = @falseAnswer, PracticeTime = @practiceTime 
                            WHERE PracticeID = @practiceID ";
            List<SqlParameter> parameters = GetParameters(practice, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);


        }

    

        public Practice GetPracticeByID(Guid practiceID)
        {
            Practice currentPractice = new Practice();
            string query = "Select * from Practice where PracticeID=@practiceID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@practiceID",
                    Value=practiceID
                }
            });
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentPractice.PracticeID = practiceID;
            currentPractice.PracticeTypeID = (byte)reader["PracticeTypeID"];
            currentPractice.PracticeDate = (DateTime)reader["AddedDate"];
            reader.Close();
            return currentPractice;
        }

        public List<Practice> GetAllPractices()
        {
            List<Practice> practices = new List<Practice>();
            Practice currentPractice = null;
            string query = "SELECT * FROM Practice";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentPractice = new Practice();
                currentPractice.PracticeID = (Guid)reader["PracticeID"];
                currentPractice.PracticeTypeID = (byte)reader["PracticeTypeID"];
                currentPractice.PracticeDate = (DateTime)reader["AddedDate"];
                practices.Add(currentPractice);
            }
            reader.Close();
            return practices;
        }


        public UserScoreDTO GetTotalUserScoreByUserID(Guid userID)
        {
            UserScoreDTO userScoreDTO;
            
            string query = @"Select SUM(distinct p.TrueAnswer) as true,SUM(distinct p.FalseAnswer) as false,SUM(distinct p.PracticeTime) as time from [User] u join WordPool w on w.UserID=u.UserID join WordPoolDetail wd on wd.WordPoolID=w.WordPoolID join PracticeDetail pd on wd.WordPoolID=pd.WordPoolID join Practice p on p.PracticeID=pd.PracticeID where u.UserID=@userID group by u.UserID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@userID",
                    Value=userID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();

            userScoreDTO = new UserScoreDTO();
            {
                if (reader.HasRows)
                {
                    userScoreDTO.TrueAnswer = (int)reader[0];
                    userScoreDTO.FalseAnswer = (int)reader[1];
                    userScoreDTO.PracticeTime = (int)reader[2];
                }
                else
                {
                    userScoreDTO.TrueAnswer = 0;
                    userScoreDTO.FalseAnswer = 0;
                    userScoreDTO.PracticeTime = 0;
                }


                reader.Close();
                return userScoreDTO;
            }
        }



        /// <summary>
        /// HANGİ UYE KAÇ ALIŞTIRMA YAPMIŞ.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public int GetPracticeCountByUserID(Guid userID)
        {
            string query = @"SELECT COUNT(p.PracticeID)
                                FROM PracticeDetail pd
                                JOIN Practice p
                                ON p.PracticeID = pd.PracticeID
                                JOIN WordPoolDetail wp
                                ON pd.WordPoolID = wp.WordPoolID
                                JOIN [User] u
                                ON u.UserID = wp.WordPoolID
                                WHERE u.UserID = @userID
                                GROUP BY p.PracticeID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@userID",
                    Value=userID
                }
            });
            
            return h.MyExecuteScalar(query);
        }

        List<SqlParameter> GetParameters(Practice practice, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (isInsert)
            {
                parameters.Add(new SqlParameter("@practiceTypeID", practice.PracticeTypeID));
                parameters.Add(new SqlParameter("@practiceDate", practice.PracticeDate));
            }
            parameters.Add(new SqlParameter("@practiceID", practice.PracticeID));
            
            
            parameters.Add(new SqlParameter("@trueAnswer", practice.TrueAnswer));

            parameters.Add(new SqlParameter("@falseAnswer", practice.FalseAnswer));
            parameters.Add(new SqlParameter("@practiceTime", practice.PracticeTime));
            
            return parameters;
        }
    }

}