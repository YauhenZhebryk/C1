using FunWithUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestOne
{
    public class UserHelperTest
    {
        //[Theory]
        //[InlineData("asdf",false)]
        //[InlineData("123",true)]

        //public void is_user_helper_work(string res,bool rightAns)
        //{
        //    var help = new UserHelper();

        //    var helper = help.UserReadNumberBetter(res);

        //    Assert.Equal(helper,rightAns);
        //}

        [Fact]

        public void is_user_helper_work_2()
        {
            var helper = new UserHelper(new MyConsoleFake());

            var response = helper.UserWriteNumber();

            Assert.False(response);
        }
        public void is_user_helper_work_3()
        {
            var helper = new UserHelper(new MyConsoleFake2());

            var response = helper.UserWriteNumber();

            Assert.True(response);
        }
    }

    public class MyConsoleFake : IConsole
    {
        public string ReadLine()
        {
            return "abc";
        }
    }
    public class MyConsoleFake2 : IConsole
    {
        public string ReadLine()
        {
            return "123";
        }
    }
}
