using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.DTO
{
    public class PracticeDetailDTO
    {
        public Guid PracticeID { get; set; }
        public Guid WordPoolID { get; set; }
        public Guid WordID { get; set; }

    }
}
