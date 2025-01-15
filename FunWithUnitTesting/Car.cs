using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithUnitTesting
{
    public class Car
    {
        private int _maxSpeed = 200;
        public int CurrentSpeed { get; private set; }

        public Car(int currentSpeed)
        {
            if (CurrentSpeed < _maxSpeed)
            {
                CurrentSpeed = _maxSpeed;
            }
            else
            {

                CurrentSpeed = currentSpeed;
            }

        }
        public void SpeedUp(int speed)
        {
            if (CurrentSpeed + speed >= _maxSpeed)
            {
                CurrentSpeed = _maxSpeed;
            }
            else
            {
                CurrentSpeed += speed;
            }
        }
    }
}


       
