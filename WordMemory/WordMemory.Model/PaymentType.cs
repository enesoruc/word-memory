using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class PaymentType
    {
        public PaymentType()
        {

        }
        public byte PaymentTypeID { get; set; }
        public string Name { get; set; }
    }
}
