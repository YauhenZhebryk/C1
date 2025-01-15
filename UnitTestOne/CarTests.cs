using FunWithUnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestOne
{
    public class CarTests
    {
        public void speedup_add_speed_with_correct_state()
        {
            var car = new Car(20);

            Assert.Equal(20, car.CurrentSpeed);

            car.SpeedUp(50);

            Assert.Equal(70, car.CurrentSpeed);


        }
    }
}
