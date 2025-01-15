using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class StringService
    {
        public int GetLength(string value)
        {
            return value.Length;
        }
        public string GetColor(Colors colors)
        {
            if (colors == Colors.None)
                return string.Empty;
            switch (colors)
            {
                case Colors.Black:
                    return "Czarny";
                    break;
                case Colors.Red:
                    return "Czerwony";
                    break;
                case Colors.Yellow:
                    return "Zolty";
                    break;
                case Colors.Green:
                    return "Zielony";
                    break;
                default:
                    return "nie wiem";
                    break;
            }
        }
        public string DoSomething(string str)
        {
            string strToUpper = ToUpperCase(str);
            return strToUpper.PadRight(20, '-');
        }

        private string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
