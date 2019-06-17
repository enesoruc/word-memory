using System;
using System.Collections.Generic;

namespace WordMemory.Model
{

    public partial class Practice
    {

        public Practice()
        {

        }

        public Guid PracticeID { get; set; }
        public byte PracticeTypeID { get; set; }
        public DateTime PracticeDate { get; set; }
        public int TrueAnswer { get; set; }
        public int FalseAnswer { get; set; }
        public int PracticeTime { get; set; }

    }
}
