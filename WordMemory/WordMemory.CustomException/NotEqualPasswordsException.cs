using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.CustomException
{
    public class NotEqualPasswordsException:Exception
    {
        public override string Message => "Girilen Şifreler Aynı Olmalıdır"; 
    }
}
