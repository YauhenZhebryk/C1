using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class MyMath
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b) 
        {
            return a - b;
        }
        public double Mul(int a, int b  )
        {
            return (double)a * (double)b;
        }
        public double Div(int a, int b)
        {
            return (double)a / (double)b;
        }
    }
}
