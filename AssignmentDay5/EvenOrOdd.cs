using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
     class EvenOrOdd
    {
        public static void CheckingNumberEvenOrOdd(int numb)
        {
            if (numb%2  == 0) 
            {
                Console.WriteLine(numb + " is a  even number");
            }
            else
            {
                Console.WriteLine(numb + "is a odd number");
            }

        }
    }
}
