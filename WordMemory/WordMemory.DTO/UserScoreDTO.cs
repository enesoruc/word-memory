using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.DTO
{
    public class UserScoreDTO
    {
        public int TrueAnswer { get; set; }
        public int FalseAnswer { get; set; }
        public int PracticeTime { get; set; }
    }
}
