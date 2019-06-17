using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class PracticeDetail
    {
        public int PracticeDetailID { get; set; }
        public Guid PracticeID { get; set; }
        public Guid WordPoolID { get; set; }
        public Guid WordID { get; set; }
        public bool IsSuccess { get; set; }

    }
}
