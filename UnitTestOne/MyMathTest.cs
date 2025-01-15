using FunWithUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    public class MyMathTest
    {
        [Theory]
        [InlineData(500,500,1000)]
        [InlineData(600, 200, 800)]
        [InlineData(-50, 500, 450)]
        [InlineData(1, 2, 3)]
        [InlineData(5, 5, 10)]

        public void add_return_correct_value(int valueA, int valueB, int expectedResult)
        {
            //Arrange
            var myMath = new MyMath();

            //Act
            var result = myMath.Add(valueA, valueB);

            //Assert
            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData(123, 23, 100)]
        public void sub_return_correct_value(int valueA, int valueB, int expectedResult)
        {
            var myMath = new MyMath();

            var result = myMath.Sub(valueA,valueB);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 4, 8)]
        public void mul_return_correct_value(int valueA, int valueB, int expectedResult)
        {
            var myMath = new MyMath();

            var result = myMath.Mul(valueA,valueB);

            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(14, 2, 7)]
        public void div_return_correct_value(int valueA, int valueB, int expectedResult)
        {
            var myMath = new MyMath();

            var result = myMath.Div(valueA,valueB);

            Assert.Equal(expectedResult, result);
        }
        //[Fact]
        //public void add_return_correct_value_second()
        //{
        //    //Arrange
        //    var myMath = new MyMath();

        //    //Act
        //    var result = myMath.Add(0,-15);

        //    //Assert
        //    Assert.Equal(-15, result);

        //}
    }
}
