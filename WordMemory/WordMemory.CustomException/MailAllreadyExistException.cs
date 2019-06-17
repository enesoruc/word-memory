using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.CustomException
{
    public class MailAllreadyExistException:Exception
    {
        public override string Message => "Aynı mail adresiyle kayıt yapılmıştır";
    }
}
