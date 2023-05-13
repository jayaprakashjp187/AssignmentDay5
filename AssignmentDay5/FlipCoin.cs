using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    class FlipCoin
    {
        public static void NumberOfTimesFlipCoin(int num)
        {
            Random rnd = new Random();
            int randomInPut=rnd.Next(0,1);
            if(randomInPut<0.5)

            {
                Console.WriteLine("tails");
            }
            else
            {
                Console.WriteLine("heads");
            }

        }
    }
}
