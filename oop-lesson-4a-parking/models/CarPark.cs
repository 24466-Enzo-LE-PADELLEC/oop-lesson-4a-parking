using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4a_parking.models
{
    public class CarPark
    {
        public List<Customer> listOfCustomers = new List<Customer>();

        public CarParkCharge carParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I'm the CarkPark()");
        }

        public override string ToString()
        {
            return "I'm the CarkPark()";
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedCharge = carParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customer : cost is {calculatedCharge} euro for registration {customer.registration}");
            }
        }
    }
}
