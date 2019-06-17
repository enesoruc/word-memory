using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemory.CustomException
{
    public class WrongPasswordLoginException :Exception
    {
        public string Tag;

        public WrongPasswordLoginException()
        {
            Tag = "password";
        }

        public override string Message => "Hatalı parola.";
    }
}
