using FunWithUnitTesting;
using NuGet.Frameworks;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestOne
{
    public class StringServiveTest
    {
        [Theory]
        [InlineData("asd", 3)]
        [InlineData("qwerty", 6)]
        public void string_length_retutn_correct_value(string str, int expectedResult)
        {
            var stringService = new StringService();

            var result = stringService.GetLength(str);

            Assert.Equal(expectedResult,result);
        }

        [Theory]
        [InlineData(Colors.Red, "Czerwony")]
        [InlineData(Colors.Black, "Czarny")]
        [InlineData(Colors.Yellow, "Zolty")]
        [InlineData(Colors.Green, "Zielony")]
        [InlineData(Colors.None, "")]
        [InlineData((Colors)8, "nie wiem")]
        public void enum_color_return_correct_value(Colors colors, string expectedResult)
        {
            var stringService= new StringService();

            var result = stringService.GetColor(colors);

            Assert.Equal(expectedResult,result);
        }
        [Theory]
        [InlineData("beb", "BEB-----------------")]
        public void string_upper_return_correct_value(string str, string expectedResult)
        {
            var stringService = new StringService();

            var result = stringService.DoSomething(str);

            Assert.Equal(expectedResult, result);
        }

    }
}
