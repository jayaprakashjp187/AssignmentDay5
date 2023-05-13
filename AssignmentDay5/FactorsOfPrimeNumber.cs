using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
    class FactorsOfPrimeNumber
    {
        public static void CalculatingFactorsOfPrimeNumber(int n)
        {
            int count = 0;
            for(int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    count++;
                }
               
            }
            if(count == 2)
            {
                for(int a=1; a<=n; a++)
                {
                    if(n%a==0)
                    {
                        Console.WriteLine("the factors of prime number is   " + a);
                    }
                }
                
            }
            else
            {
                Console.WriteLine("sorry " + n + "is not a prime number");
            }

        }
    }
}
