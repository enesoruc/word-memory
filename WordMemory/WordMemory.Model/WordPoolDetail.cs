using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class WordPoolDetail
    {

        public WordPoolDetail()
        {



        }

        public Guid WordPoolID { get; set; }
        public Guid WordID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
