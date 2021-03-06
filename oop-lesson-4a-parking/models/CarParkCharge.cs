using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4a_parking.models
{
    public class CarParkCharge
    {
        public int minimumFee { get; set; }
        public int minimumHours { get; set; }
        public CarParkCharge(int _minimumFee =2 ,int _minimumHours = 3)
        {
            Console.WriteLine("I'm the CarkParkCharge()");
            minimumFee = _minimumFee;
            minimumHours = _minimumHours;
        }
        public override string ToString()
        {
            return "I'm the CarkParkCharge()";
        }

        public int CalculateCharge(int hoursParked)
        {
            int calculatedFee = minimumFee;
            hoursParked = hoursParked - 3;
            calculatedFee = Convert.ToInt32(calculatedFee + 0.5 * hoursParked);
            if (calculatedFee > 10)
            {
                calculatedFee = 10;
            }
            return calculatedFee;
        }
    }
}
