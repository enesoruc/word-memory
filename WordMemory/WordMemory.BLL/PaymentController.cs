using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemory.DAL;
using WordMemory.Model;

namespace WordMemory.BLL
{
    public class PaymentController
    {
        PaymentManagement _paymentManagement;
        public PaymentController()
        {
            _paymentManagement = new PaymentManagement();
        }
        
        public bool Add(Payment payment)
        {
            payment.PaymentID = Guid.NewGuid();
            payment.PaymentDate = DateTime.Now;

            return _paymentManagement.Insert(payment) > 0;
        }

        public Payment GetPaymentByID(Guid paymentID)
        {
            return _paymentManagement.GetPaymentByID(paymentID);
        }

        public List<Payment> GetPaymentByTypeID(byte paymentTypeID)
        {
            List<Payment> payment = new List<Payment>();
            foreach (Payment item in _paymentManagement.GetAllPayments())
            {
                if (paymentTypeID == item.PaymentTypeID)
                {
                    payment.Add(item);
                }
            }
            return payment;
        }

        public List<Payment> GetPaymentByUserID(Guid userID)
        {
            List<Payment> payment = new List<Payment>();
            foreach (Payment item in _paymentManagement.GetAllPayments())
            {
                if (userID == item.UserID)
                {
                    payment.Add(item);
                }
            }
            return payment;
        }

        public List<Payment> GetAllPayments()
        {
            return _paymentManagement.GetAllPayments();
        }

        public decimal GetTotalPrice()
        {
            return _paymentManagement.GetTotalPrice();
        }


    }
}
