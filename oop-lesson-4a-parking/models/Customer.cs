using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4a_parking.models
{
    public class Customer
    {
        public int hoursParked { get; set; }

        public string registration { get; set; }
        public Customer(string _registration, int _hoursParked)
        {
            hoursParked = _hoursParked;
            Console.WriteLine("I'm the Customer()");
            registration = _registration;
        }
        public override string ToString()
        {
            return "I'm the Customer()";
        }
    }
}
