using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_lesson_4a_parking.test;

namespace oop_lesson_4a_parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            Driver driver = new Driver();

            driver.CreateObjects();

            Console.ReadKey();
        }
    }
}
