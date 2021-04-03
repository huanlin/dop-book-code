using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch01.Ex02_AdheringPrinciple1
{
    class NameCalculation
    {
        public static string FullName(dynamic entity)
        {
            return entity.FirstName + " " + entity.LastName;
        }
    }
}
