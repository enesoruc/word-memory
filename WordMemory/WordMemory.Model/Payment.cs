using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class Payment
    {
        public Guid PaymentID { get; set; }
        public Guid UserID { get; set; }
        public byte PaymentTypeID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Price { get; set; }

    }
}
