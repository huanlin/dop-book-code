using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ch01.Ex01_BreakingPrinciple1
{
    class Customer
    {
        public Customer(string firstName, string lastName, int numOfOrders)
        {
            FirstName = firstName;
            LastName = lastName;
            NumOfOrders = numOfOrders;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int NumOfOrders { get; private set; }
        public string FullName => FirstName + " " + LastName;
        public bool IsVip() => NumOfOrders > 100;
    }

    class CustomerDemo
    {
        public static void Run()
        {
            var customer = new Customer("Bruce", "Wayne", 300); // 偉恩有 300 筆訂單
            Console.WriteLine(customer.FullName);
        }
    }
}
