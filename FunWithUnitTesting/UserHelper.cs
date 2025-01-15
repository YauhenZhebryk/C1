using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public interface IUserHelper
    {
        bool UserWriteNumber();
    }
    public class UserHelper : IUserHelper
    {
        private readonly IConsole console;

        public UserHelper(IConsole console) 
        { 
            this.console = console;
        }

        public bool UserWriteNumber()
        {
            var result = console.ReadLine();
            return int.TryParse(result, out var value);
        }

        public bool UserReadNumberBetter(string value)
        {
            return int.TryParse(value, out var r);
        }
    }

    public interface IConsole
    {
        string ReadLine();
    }

    public class MyConsole : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
