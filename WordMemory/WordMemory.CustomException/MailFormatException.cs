using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.CustomException
{
    public class MailFormatException:Exception
    {
        public override string Message => "Girilen mail adresi doğru formatta değil! Kontrol edip tekrardan deneyiniz!";
    }
}
