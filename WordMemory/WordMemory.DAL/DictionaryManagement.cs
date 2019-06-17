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
    public class DictionaryManagement
    {
        Helper h;
        WordReportDTO wordReportDTO;
        public DictionaryManagement()
        {
            h = new Helper();

        }

        // Insert , Update , GetData , Get All Data

        public int Insert(Dictionary dictionary)
        {
            string query = "Insert into Dictionary(WordID,English,Turkish,AddedDate,IsActive) values(@wordID,@english,@turkish,@addedDate,@isActive)";
            List<SqlParameter> parameters = GetParameters(dictionary, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }

        public int Update(Dictionary dictionary)
        {
            string query = "Update Dictionary set WordID = @wordID,English=@english,Turkish=@turkish,IsActive=@isActive WHERE WordID = @wordID";
            List<SqlParameter> parameters = GetParameters(dictionary, false);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }


        List<SqlParameter> GetParameters(Dictionary dictionary, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@wordID", dictionary.WordID));
            if (isInsert)
            {
                parameters.Add(new SqlParameter("@addedDate", DateTime.Now));
            }
            parameters.Add(new SqlParameter("@english", dictionary.English));
            parameters.Add(new SqlParameter("@turkish", dictionary.Turkish));
            parameters.Add(new SqlParameter("@isActive", dictionary.IsActive));
            return parameters;
        }

        public Dictionary GetWordByID(Guid wordID)
        {
            Dictionary currentDictionary = new Dictionary();
            string query = "Select * from Dictionary where WordID=@wordID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName="@wordID",
                    Value=wordID
                }
            });
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentDictionary.WordID = wordID;
            currentDictionary.English = reader["English"].ToString();
            currentDictionary.Turkish = reader["Turkish"].ToString();
            currentDictionary.AddedDate = (DateTime)reader["AddedDate"];
            currentDictionary.IsActive = (bool)reader["IsActive"];
            reader.Close();
            return currentDictionary;
        }

        public List<Dictionary> GetAllWords()
        {
            List<Dictionary> words = new List<Dictionary>();
            Dictionary currentWord = null;
            string query = "SELECT * FROM Dictionary";

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentWord = new Dictionary();
                currentWord.WordID = (Guid)reader["WordID"];
                currentWord.English = reader["English"].ToString();
                currentWord.Turkish = reader["Turkish"].ToString();
                currentWord.AddedDate = (DateTime)reader["AddedDate"];
                currentWord.IsActive = (bool)reader["IsActive"];
                words.Add(currentWord);
            }
            reader.Close();
            return words;
        }


        public List<WordReportDTO> GetWordReportByWeek(string date)
        {
            List<WordReportDTO> WordReportList = new List<WordReportDTO>();

            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@date",
                    Value=date
                }
            });
            SqlDataReader reader = h.ExecuteSpReader("sp_WordReportbyWeek");
            while (reader.Read())
            {
                wordReportDTO = new WordReportDTO();
                wordReportDTO.English = reader[0].ToString();
                wordReportDTO.Turkish = reader[1].ToString();
                wordReportDTO.WordCount = (int)reader[2];

                WordReportList.Add(wordReportDTO);
            }
            reader.Close();
            return WordReportList;
        }



        public List<WordReportDTO> GetWordReportByMonth(string date)
        {
            List<WordReportDTO> WordReportList = new List<WordReportDTO>();

            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@date",
                    Value=date
                }
            });
            SqlDataReader reader = h.ExecuteSpReader("sp_WordReportbyMonth");
            while (reader.Read())
            {
                wordReportDTO = new WordReportDTO();
                wordReportDTO.English = reader[0].ToString();
                wordReportDTO.Turkish = reader[1].ToString();
                wordReportDTO.WordCount = (int)reader[2];

                WordReportList.Add(wordReportDTO);
            }
            reader.Close();
            return WordReportList;
        }

       public List<WordReportDTO> GetReportBetweenDateRange(string startDate, string endDate)
        {
            List<WordReportDTO> WordReportList = new List<WordReportDTO>();

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
            SqlDataReader reader = h.ExecuteSpReader("sp_YearlyReport");
            while (reader.Read())
            {
                wordReportDTO = new WordReportDTO();
                wordReportDTO.English = reader[0].ToString();
                wordReportDTO.Turkish = reader[1].ToString();
                wordReportDTO.WordCount = (int)reader[2];

                WordReportList.Add(wordReportDTO);
            }
            reader.Close();
            return WordReportList;
        }

    }
}
