using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01.Ex02_AdheringPrinciple1
{
    class CustomerData
    {
        public CustomerData(string firstName, string lastName, int numOfOrders)
        {
            FirstName = firstName;
            LastName = lastName;
            NumOfOrders = numOfOrders;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int NumOfOrders { get; private set; }
    }
}
