using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public interface ISender
    {
        void SendSms(string message);
        void SendEmail(string message);
    }
    public class TestRaport
    {
        private readonly ISender _sender;

        public TestRaport(ISender sender)
        {
            _sender = sender;
        }

        public void Raport(State state)
        {
            if (state == State.Success)
            {
                _sender.SendEmail("asdgfdghfjhgkjhlgfmdnfsdb");
            }
            else if (state == State.Faild)
            {
                _sender.SendSms("asdfgfdhfjgkhg");
            }
        }
    }

    public enum State
    {
        Waiting,
        Success,
        Faild
    }
}
