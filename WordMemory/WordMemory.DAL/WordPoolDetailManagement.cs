using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.Model;

namespace WordMemory.DAL
{
    public class WordPoolDetailManagement
    {
        Helper h;
        public WordPoolDetailManagement()
        {
            h = new Helper();
        }

        public int Insert(WordPoolDetail wordPoolDetail)
        {
            string query = "INSERT INTO WordPoolDetail(WordPoolID,WordID,IsActive,CreatedDate) VALUES(@WordPoolID,@WordID,@IsActive,@CreatedDate)";
            List<SqlParameter> sqlParameters = GetParameters(wordPoolDetail, true);
            h.AddParametersToCommand(sqlParameters);
            return h.MyExecuteNonQuery(query);
        }

        public int Update(WordPoolDetail wordPoolDetail)
        {
            string query = "UPDATE WordPoolDetail SET IsActive=@IsActive WHERE WordPoolID=@WordPoolID AND WordID=@WordID";
            List<SqlParameter> sqlParameters = GetParameters(wordPoolDetail, false);
            h.AddParametersToCommand(sqlParameters);
            return h.MyExecuteNonQuery(query);
        }


        /// <summary>
        /// Havuz zaten o kelimeyi içeriyorsa TRUE döner.
        /// </summary>
        /// <param name="wordPoolDetail"></param>
        /// <returns></returns>
        public bool IsPoolContainsAlready(WordPoolDetail wordPoolDetail)
        {
            string query = "SELECT * FROM WordPoolDetail WHERE WordPoolID=@WordPoolID AND WordID=@WordID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@WordPoolID",
                    Value = wordPoolDetail.WordPoolID
                },
                new SqlParameter()
                {
                    ParameterName="@WordID",
                    Value = wordPoolDetail.WordID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            bool isContain = reader.HasRows;
            reader.Close();

            if (isContain)
            {
                return true;
            }


            return false;
        }

        public List<Dictionary> GetActiveWordsByWordPoolID(Guid wordpoolID)
        {
            List<Dictionary> myActiveWords = new List<Dictionary>();

            string query = @"SELECT * FROM Dictionary d
                            JOIN WordPoolDetail wpd
                            ON d.WordID = wpd.WordID
                            WHERE wpd.WordPoolID = @wordPoolID AND wpd.IsActive = @isActive";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@WordPoolID", Value = wordpoolID
                },
                new SqlParameter()
                {
                     ParameterName="@isActive", Value = true
                }
            });
            SqlDataReader reader = h.MyExecuteReader(query);

            Dictionary currentWord;
            while (reader.Read())
            {
                currentWord = new Dictionary()
                {
                    WordID = (Guid)reader["WordID"],
                    English = reader["English"].ToString(),
                    Turkish = reader["Turkish"].ToString(),
                    AddedDate = (DateTime)reader["AddedDate"],
                    IsActive = Convert.ToBoolean(reader["IsActive"])
                };

                myActiveWords.Add(currentWord);
            }

            reader.Close();
            return myActiveWords;

        }

        public List<WordPoolDetail> GetWordPoolDetailByWordPoolID(Guid wordPoolID)
        {
            List<WordPoolDetail> WordPoolDetailList = new List<WordPoolDetail>();
            string query = "SELECT * FROM WordPoolDetail WHERE WordPoolID=@WordPoolID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@WordPoolID",Value=wordPoolID
                }
            });
            WordPoolDetail currentWordPoolDetail;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentWordPoolDetail = new WordPoolDetail();
                currentWordPoolDetail.WordPoolID = wordPoolID;
                currentWordPoolDetail.WordID = (Guid)reader["WordID"];
                currentWordPoolDetail.IsActive = (bool)reader["IsActive"];
                currentWordPoolDetail.CreatedDate = (DateTime)reader["CreatedDate"];

                WordPoolDetailList.Add(currentWordPoolDetail);
            }

            reader.Close();
            return WordPoolDetailList;
        }



        public List<WordPoolDetail> GetAllWordPoolDetail()
        {
            List<WordPoolDetail> wordPoolDetails = new List<WordPoolDetail>();
            WordPoolDetail currentWordPoolDetail = null;
            string query = "SELECT * FROM WordPoolDetail";
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentWordPoolDetail.WordPoolID = (Guid)reader["WordPoolID"];
                currentWordPoolDetail.WordID = (Guid)reader["WordID"];
                currentWordPoolDetail.IsActive = (bool)reader["IsActive"];
                currentWordPoolDetail.CreatedDate = (DateTime)reader["CreatedDate"];
                wordPoolDetails.Add(currentWordPoolDetail);
            }
            reader.Close();
            return wordPoolDetails;
        }



        List<SqlParameter> GetParameters(WordPoolDetail wordPoolDetail, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (isInsert)
            {
                parameters.Add(new SqlParameter("@CreatedDate", wordPoolDetail.CreatedDate));
            }
            parameters.Add(new SqlParameter("@WordPoolID", wordPoolDetail.WordPoolID));
            parameters.Add(new SqlParameter("@WordID", wordPoolDetail.WordID));
            parameters.Add(new SqlParameter("@IsActive", wordPoolDetail.IsActive));
            return parameters;
        }
    }
}
