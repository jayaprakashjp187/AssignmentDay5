using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
     class LeapYear
    {
        public static void checkingLeapYearOrNot(int year) 
        {
            if(year%4==0)
            {
                Console.WriteLine(year +"is aleap year");
            }
            else
            {
                Console.WriteLine(year + "is not a leap year");
            }
        }
    }
}
