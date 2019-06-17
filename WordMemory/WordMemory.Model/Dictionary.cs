using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class Dictionary
    {
        public Dictionary()
        {

        }

        public Guid WordID { get; set; }
        public string English { get; set; }
        public string Turkish { get; set; }
        public DateTime AddedDate { get; set; }
        public bool IsActive { get; set; }

    }
}
