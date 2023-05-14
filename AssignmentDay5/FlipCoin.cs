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
            Random Flip = new Random();
            int randomInPut=Flip.Next(0,1);
            int heads = 0;
            int tails = 0;

            for (int i = 0; i < num; i++)
            {
                if (Flip.NextDouble() < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }

            double headsPercentage = ((double)heads / num) * 100;
            double tailsPercentage = ((double)tails / num) * 100;

            Console.WriteLine("heads " + headsPercentage.ToString("0.00") + "percentage");
            Console.WriteLine("tails " + tailsPercentage.ToString("0.00") + "percentage");

        }
    }
}
