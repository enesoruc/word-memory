using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.CustomException
{
    public class NullOrWhiteSpaceException :Exception
    {
        string alan = string.Empty;

        public NullOrWhiteSpaceException(string current)
        {
            alan = current;
        }

        public override string Message => "Boş geçilemez."+" "+alan;
    }
}
