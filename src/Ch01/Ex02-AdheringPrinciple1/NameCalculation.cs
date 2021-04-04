using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ch01.Ex02_AdheringPrinciple1
{
    public class NameCalculation
    {
        public static string FullName(dynamic entity)
        {
            return entity.FirstName + " " + entity.LastName;
        }
    }
}
