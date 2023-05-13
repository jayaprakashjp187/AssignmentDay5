using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class Power
    {
        public static void CheckingPowerOfNumber(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2^" + i + " = " + Math.Pow(2, i));
            }
        }
    }
}
