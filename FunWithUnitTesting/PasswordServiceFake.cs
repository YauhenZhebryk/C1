using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class PasswordServiceFake : IPasswordService
    {
        public string Hash(string value)
        {
            return "pass";
        }
    }
}
