using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.Model;

namespace WordMemory.DAL
{

    public class WordPoolManagement
    {
        Helper h;
        public WordPoolManagement()
        {
            h = new Helper();
        }
        public int Insert(WordPool wordPool)
        {
            string query = "INSERT INTO WordPool(WordPoolID,UserID,Name,CreatedDate,IsActive) VALUES (@WordPoolID,@UserID,@Name,@CreatedDate,@IsActive)";

            List<SqlParameter> parameters = GetParameters(wordPool,true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }

        public int Update(WordPool wordPool)
        {
            string query = "UPDATE WordPool SET Name=@Name,IsActive=@IsActive WHERE WordPoolID=@WordPoolID";
            List<SqlParameter> parameters = GetParameters(wordPool, false);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteNonQuery(query);
        }

        public WordPool GetWordPoolByWordPoolID(Guid wordPoolID)
        {
            WordPool currentWordPool = new WordPool();
            string query = "SELECT * FROM WordPool WHERE WordPoolID=@WordPoolID";
            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@WordPoolID",Value=wordPoolID
                }
            });
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentWordPool.WordPoolID = wordPoolID;
            currentWordPool.UserID = (Guid)reader["UserID"];
            currentWordPool.Name = reader["Name"].ToString();
            currentWordPool.CreatedDate = (DateTime)reader["CreatedDate"];
            currentWordPool.IsActive = (bool)reader["IsActive"];
            reader.Close();
            return currentWordPool;
        }

        //public WordPool GetWordPoolByUserID() //kullanıcı için
        //{
        //    WordPool currentWordPool = new WordPool();
        //    string query = "SELECT * FROM WordPool WHERE UserID=@UserID";
        //    h.AddParametersToCommand(new List<SqlParameter>
        //    {
        //        new SqlParameter()
        //        {
        //            ParameterName="@UserID",Value=UserID
        //        }
        //    });
        //    SqlDataReader reader = h.MyExecuteReader(query);
        //    reader.Read();
        //    currentWordPool.WordPoolID = (Guid)reader["WordPoolID"];
        //    currentWordPool.UserID = UserID;
        //    currentWordPool.Name = reader["Name"].ToString();
        //    currentWordPool.CreatedDate = (DateTime)reader["CreatedDate"];
        //    currentWordPool.IsActive = (bool)reader["IsActive"];
        //    reader.Close();
        //    return currentWordPool;
        //}

        public List<WordPool> GetAllWordPools()//admin için
        {
            List<WordPool> wordPools = new List<WordPool>();
            WordPool currentWordPool = null;
            string query = "SELECT * FROM WordPool";
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentWordPool = new WordPool();
                currentWordPool.WordPoolID= (Guid)reader["WordPoolID"];
                currentWordPool.UserID = (Guid)reader["UserID"];
                currentWordPool.Name = reader["Name"].ToString();
                currentWordPool.CreatedDate = (DateTime)reader["CreatedDate"];
                currentWordPool.IsActive = Convert.ToBoolean(reader["IsActive"]);
                wordPools.Add(currentWordPool);
            }
            reader.Close();
            return wordPools;
        }

        public List<WordPool> GetAllMyActiveWordPools(Guid UserID) //user için
        {
            List<WordPool> wordPools = new List<WordPool>();
            WordPool currentWordPool = null;
            string query = @"SELECT * FROM WordPool WHERE IsActive=@isActive AND UserID = @userID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@isActive",
                    Value = true
                },
                new SqlParameter()
                {
                     ParameterName = "@userID",
                    Value = UserID
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentWordPool = new WordPool();
                currentWordPool.WordPoolID = (Guid)reader["WordPoolID"];
                currentWordPool.UserID = (Guid)reader["UserID"];
                currentWordPool.Name = reader["Name"].ToString();
                currentWordPool.CreatedDate = (DateTime)reader["CreatedDate"];
                currentWordPool.IsActive = Convert.ToBoolean(reader["IsActive"]);
                wordPools.Add(currentWordPool);
            }
            reader.Close();
            return wordPools;
        }



        public List<WordPool> GetAllWordPoolsByUserID(Guid userID)//user için
        {
            List<WordPool> wordPools = new List<WordPool>();
            WordPool currentWordPool = null;
            string query = "SELECT * FROM WordPool WHERE UserID=@UserID";
            h.AddParametersToCommand(new List<SqlParameter>
            {
                new SqlParameter()
                {
                    ParameterName="@UserID",Value=userID
                }
            });
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentWordPool = new WordPool();
                currentWordPool.WordPoolID = (Guid)reader["WordPoolID"];
                currentWordPool.UserID = (Guid)reader["UserID"];
                currentWordPool.Name = reader["Name"].ToString();
                currentWordPool.CreatedDate = (DateTime)reader["CreatedDate"];
                currentWordPool.IsActive = (bool)reader["IsActive"];
                wordPools.Add(currentWordPool);
            }
            reader.Close();
            return wordPools;
        }


        List<SqlParameter> GetParameters(WordPool wordPool, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();            
            if (isInsert)
            {                
                parameters.Add(new SqlParameter("@UserID", wordPool.UserID));
                parameters.Add(new SqlParameter("@CreatedDate", wordPool.CreatedDate));
            }
            parameters.Add(new SqlParameter("@WordPoolID", wordPool.WordPoolID));
            parameters.Add(new SqlParameter("@Name", wordPool.Name));
            parameters.Add(new SqlParameter("@IsActive", wordPool.IsActive));
            return parameters;
        }
    }
}
