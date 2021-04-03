using System;
using Ch01.Ex02_AdheringPrinciple1;

namespace Ch01
{
    class Program
    {
        static void Main(string[] args)
        {            
            var customer = new CustomerData("Bruce", "Wayne", 300); 
            var name = NameCalculation.FullName(customer);
            Console.WriteLine(name);
        }
    }
}
