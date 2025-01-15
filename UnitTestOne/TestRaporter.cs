using FunWithUnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestOne
{
    public class TestRaporterTest
    {
        [Fact]
        public void raport_for_failed_test()
        {
            var fakeSender = new Mock<ISender>();
            var raporter = new TestRaport(fakeSender.Object);

            raporter.Raport(State.Faild);

            fakeSender.Verify(s => s.SendEmail(It.IsAny<string>()),Times.Never);

            fakeSender.Verify(s => s.SendSms(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void raport_for_failed_test_mail()
        {
            var fakeSender = new FakeSender();
            var raporter = new TestRaport(fakeSender);

            Assert.False(fakeSender.IsEmailSent);
            Assert.False(fakeSender.IsSmsSent);

            raporter.Raport(State.Success);

            Assert.True(fakeSender.IsEmailSent);
            Assert.False(fakeSender.IsSmsSent);
        }

    }


    public class FakeSender : ISender
    {
        public bool IsEmailSent { get; private set; }
        public bool IsSmsSent { get; private set; }

        public void SendEmail(string message)
        {
            IsEmailSent = true;
        }

        public void SendSms(string message)
        {
            IsSmsSent = true;
        }
    }
}
