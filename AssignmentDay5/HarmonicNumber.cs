using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class HarmonicNumber
    {
        public static void ToFindHarmonicNumber(int num) 
        {
            double harmonicSum = 0;
            for (int i = 1; i <= num; i++)
            {
                harmonicSum += 1.0 / i;
                
            }
            Console.WriteLine("sum of harmonic number is " +harmonicSum);
        }

       
    }
}
