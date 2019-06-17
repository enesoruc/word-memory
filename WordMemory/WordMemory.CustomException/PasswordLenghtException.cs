using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.CustomException
{
    public class PasswordLenghtException:Exception
    {
        public override string Message => "Şifre karakter uzunluğu 5'ten uzun olmalıdır!"; 
    }
}
