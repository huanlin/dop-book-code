using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01.Ex02_AdheringPrinciple1
{
    public class CustomerRating
    {
        public static bool IsVip(dynamic entity)
        {
            return entity.NumOfOrders > 100;            
        }
    }
}
