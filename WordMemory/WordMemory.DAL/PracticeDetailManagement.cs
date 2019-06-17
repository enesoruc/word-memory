using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.Model;

namespace WordMemory.DAL
{
    public class PracticeDetailManagement
    {
        Helper h;

        public PracticeDetailManagement()
        {
            h = new Helper();
        }

        public int Insert(PracticeDetail practiceDetail)
        {
            string query = "INSERT [PracticeDetail] VALUES (@practiceID,@wordPoolID,@wordID,@isSuccess)";
            List<SqlParameter> parameters = GetParameters(practiceDetail);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }

    
        public List<PracticeDetail> GetPracticeDetailsByPracticeID(Guid practiceID)
        {
            List<PracticeDetail> allPracticeDetails = new List<PracticeDetail>();

            string query = "SELECT * FROM PracticeDetail WHERE PracticeID = @practiceID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@practiceID",
                    Value=practiceID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            PracticeDetail currentPracticeDetail;

            
            while (reader.Read())
            {
                currentPracticeDetail = new PracticeDetail()
                {
                    PracticeDetailID = (int)reader["PracticeDetailID"],
                    PracticeID = (Guid)reader["PracticeID"],
                    WordPoolID = (Guid)reader["WordPoolID"],
                    WordID = (Guid)reader["WordID"],
                    IsSuccess = (bool)reader["IsSuccess"]
                };

                allPracticeDetails.Add(currentPracticeDetail);
            }
            reader.Close();

            return allPracticeDetails;
        }


        public PracticeDetail GetPracticeDetailsByPracticeDetailID(int practiceDetailID)
        {
            PracticeDetail currentPracticeDetail;

            string query = "SELECT * FROM PracticeDetail WHERE PracticeDetailID = @practiceDetailID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@practiceDetailID",
                    Value=practiceDetailID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
         

            reader.Read();

            currentPracticeDetail = new PracticeDetail()
            {
                PracticeDetailID = (int)reader["PracticeDetailID"],
                PracticeID = (Guid)reader["PracticeID"],
                WordPoolID = (Guid)reader["WordPoolID"],
                WordID = (Guid)reader["WordID"],
                IsSuccess = (bool)reader["IsSuccess"]
            };
            
            reader.Close();

            return currentPracticeDetail;
        }


        public List<PracticeDetail> GetPracticeDetailsByWordPoolID(Guid wordPoolID)
        {
            List<PracticeDetail> allPracticeDetails = new List<PracticeDetail>();

            string query = "SELECT * FROM PracticeDetail WHERE WordPoolID = @wordPoolID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@wordPoolID",
                    Value=wordPoolID
                }
            });


            SqlDataReader reader = h.MyExecuteReader(query);
            PracticeDetail currentPracticeDetail;


            while (reader.Read())
            {
                currentPracticeDetail = new PracticeDetail()
                {
                    PracticeDetailID = (int)reader["PracticeDetailID"],
                    PracticeID = (Guid)reader["PracticeID"],
                    WordPoolID = (Guid)reader["WordPoolID"],
                    WordID = (Guid)reader["WordID"],
                    IsSuccess = (bool)reader["IsSuccess"]
                };

                allPracticeDetails.Add(currentPracticeDetail);
            }
            reader.Close();

            return allPracticeDetails;
        }

        public List<PracticeDetail> GetPracticeDetailsByWordID(Guid WordID)
        {
            List<PracticeDetail> allPracticeDetails = new List<PracticeDetail>();

            string query = "SELECT * FROM PracticeDetail WHERE WordID = @wordID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@wordID",
                    Value=WordID
                }
            });


            SqlDataReader reader = h.MyExecuteReader(query);
            PracticeDetail currentPracticeDetail;


            while (reader.Read())
            {
                currentPracticeDetail = new PracticeDetail()
                {
                    PracticeDetailID = (int)reader["PracticeDetailID"],
                    PracticeID = (Guid)reader["PracticeID"],
                    WordPoolID = (Guid)reader["WordPoolID"],
                    WordID = (Guid)reader["WordID"],
                    IsSuccess = (bool)reader["IsSuccess"]
                };

                allPracticeDetails.Add(currentPracticeDetail);
            }
            reader.Close();

            return allPracticeDetails;
        }

        public List<PracticeDetail> GetAllPracticeDetails()
        {
            List<PracticeDetail> allPracticeDetails = new List<PracticeDetail>();

            string query = "SELECT * FROM PracticeDetail";
            
            SqlDataReader reader = h.MyExecuteReader(query);
            PracticeDetail currentPracticeDetail;

            while (reader.Read())
            {
                currentPracticeDetail = new PracticeDetail()
                {
                    PracticeDetailID = (int)reader["PracticeDetailID"],
                    PracticeID = (Guid)reader["PracticeID"],
                    WordPoolID = (Guid)reader["WordPoolID"],
                    WordID = (Guid)reader["WordID"],
                    IsSuccess = (bool)reader["IsSuccess"]
                    
                };

                allPracticeDetails.Add(currentPracticeDetail);
            }

            reader.Close();
            return allPracticeDetails;
        }

        private List<SqlParameter> GetParameters(PracticeDetail practiceDetail)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@practiceID", practiceDetail.PracticeID),
                new SqlParameter("@wordPoolID", practiceDetail.WordPoolID),
                new SqlParameter("@wordID", practiceDetail.WordID),
                new SqlParameter("@isSuccess", practiceDetail.IsSuccess)
            };

            return parameters;
        }
    }
}
