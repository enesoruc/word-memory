using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.Model;

namespace WordMemory.DAL
{
    public class PaymentManagement
    {
        Helper h;
        public PaymentManagement()
        {
            h = new Helper();
        }

        public int Insert(Payment payment)
        {
            string query = @"INSERT INTO [Payment] VALUES (@paymentID,@userID,@paymentTypeID,@paymentDate,@price)";

            List<SqlParameter> parameters = GetParameters(payment);
            h.AddParametersToCommand(parameters);

            return h.MyExecuteNonQuery(query);
        }

        public decimal GetTotalPrice()
        {
            string query = "select SUM(Price) from Payment";
            SqlDataReader reader = h.MyExecuteReader(query);

            reader.Read();
            decimal value = Convert.ToDecimal(reader[0]);
            reader.Close();

            return value;
            
        }

        public Payment GetPaymentByID(Guid paymentID)
        {
            string query = @"SELECT * FROM Payment WHERE PaymentID = @paymentID";

            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@paymentID",
                    Value = paymentID
                }
            });

            Payment currentPayment;
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentPayment = new Payment()
            {
                PaymentID = (Guid)reader["PaymentID"],
                UserID = (Guid)reader["UserID"],
                PaymentTypeID = (byte)reader["PaymentTypeID"],
                PaymentDate = (DateTime)reader["PaymentDate"],
                Price = (decimal)reader["Price"]
            };

            return currentPayment;
        }

        public List<Payment> GetAllPayments()
        {
            string query = "SELECT * FROM Payment";

            List<Payment> allPayments = new List<Payment>();

            Payment currentPayment;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentPayment = new Payment()
                {
                    PaymentID = (Guid)reader["PaymentID"],
                    UserID = (Guid)reader["UserID"],
                    PaymentTypeID = (byte)reader["PaymentTypeID"],
                    PaymentDate = (DateTime)reader["PaymentDate"],
                    Price = (decimal)reader["Price"]
                };
                allPayments.Add(currentPayment);
            }

            return allPayments;
            
        }

        private List<SqlParameter> GetParameters(Payment payment)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            
            parameters.Add(new SqlParameter("@paymentID", payment.PaymentID));
            parameters.Add(new SqlParameter("@userID", payment.UserID));
            parameters.Add(new SqlParameter("@paymentTypeID", payment.PaymentTypeID));
            parameters.Add(new SqlParameter("@paymentDate", payment.PaymentDate));
            parameters.Add(new SqlParameter("@price", payment.Price));
         
            return parameters;
        }
    }
}
