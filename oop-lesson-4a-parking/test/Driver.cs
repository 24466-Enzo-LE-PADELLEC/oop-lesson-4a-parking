using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_lesson_4a_parking.models;

namespace oop_lesson_4a_parking.test
{
    public class Driver
    {
        public Driver()
        {
            Console.WriteLine("I'm the code Driver()");
        }
        public void CreateObjects()
        {
            CarPark carpark = new CarPark();

            carpark.AddCustomer(new Customer("a", 2));
            carpark.AddCustomer(new Customer("b", 3));
            carpark.AddCustomer(new Customer("c", 4));
            carpark.AddCustomer(new Customer("d", 5));
            carpark.AddCustomer(new Customer("e", 6));
            carpark.AddCustomer(new Customer("f", 7));

            carpark.CalculateCharges();

            Customer customer = new Customer("g", 8);
            CarParkCharge carparkcharge = new CarParkCharge();

            //Call the ToString Method

            Console.WriteLine(carpark.ToString());
            Console.WriteLine(customer.ToString());
            Console.WriteLine(carparkcharge.ToString());
        }
    }
}
