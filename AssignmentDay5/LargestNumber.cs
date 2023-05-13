using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    internal class LargestNumber
    {
        public static void CheckingLargerNUmber(int firstValue,int  secondValue, int thirdValue)
        {
            int largerNumber=((firstValue > secondValue)&&(firstValue > thirdValue))?firstValue:(secondValue>thirdValue)?secondValue:thirdValue;
            Console.WriteLine(largerNumber +"is a larger number compare to all three");
        }
    }
}
