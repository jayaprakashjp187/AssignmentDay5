using System.Transactions;

namespace AssignmentDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the assignment day5 programs select any one program below mentioned");
            Console.WriteLine("1.FlipCoin Program\n2.LeapYear Program\n3.PowerProgram\n4.Harmonic Number Program\n5.Factors Program\n6.Quotient and Remainder Program\n7.Swap Numbers Program\n8.Even or Odd Number Program\n9.Vowel or Consonent Program\n10.CheckingLargerNumber");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    Console.WriteLine("welcome to the flipcoin program");
                    Console.WriteLine("enter the number how many times flip the coin");
                    int num= Convert.ToInt32(Console.ReadLine());
                    FlipCoin.NumberOfTimesFlipCoin(num);

                    break;
                case 2:
                    Console.WriteLine("welcome to the leap year program");
                    Console.WriteLine("please enter four digits number for checking leap year or not");
                    int year=Convert.ToInt32(Console.ReadLine());
                    LeapYear.checkingLeapYearOrNot(year);
                    break;
                case 3:
                    Console.WriteLine("welcome to the power program");
                    Console.WriteLine("enter the  value up to range");
                    int value=Convert.ToInt32(Console.ReadLine());
                    Power.CheckingPowerOfNumber(value);
                    break;
               
                case 4:
                    
                    Console.WriteLine("welcome to the harmonic number program");
                    Console.WriteLine("please enter the value");
                    int harmonicNum=Convert.ToInt32(Console.ReadLine());
                    HarmonicNumber.ToFindHarmonicNumber(harmonicNum);
                    break;
                case 5:
                    
                        Console.WriteLine("welcome to the factors program ");
                        Console.WriteLine("enter the number ");
                        int n= Convert.ToInt32(Console.ReadLine());
                        FactorsOfPrimeNumber.CalculatingFactorsOfPrimeNumber(n);
                        break;
                    
                 case 6:
                    
                        Console.WriteLine("welcome to the quotient and remainder program");
                        Console.WriteLine("please enter x value");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter y value");
                        int y= Convert.ToInt32(Console.ReadLine());
                        Calculator jp = new Calculator();
                        jp.remainderOfTwoNumbers(x, y);
                        jp.quotientOfTwoNumbers(x, y);
                        
                        break;
                  case 7:
                    
                        Console.WriteLine("welcome to the swap program");
                        Console.WriteLine("please enter j value before swaping");
                        int j = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("please enter k value before swaping");
                        int k = Convert.ToInt32(Console.ReadLine());
                        Swap.SwapingTwoNumbers(j,k);
                        break;
                  
                case 8:
                    Console.WriteLine("welcome to the even or odd program");
                    Console.WriteLine("enter the number");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    EvenOrOdd.CheckingNumberEvenOrOdd(numb);
                    break;
                case 9:
                    Console.WriteLine("welcome to alphabet like checking vowel or consonent ");
                    Console.WriteLine("enter the alphabet");
                    char chooseAlphabet=Convert.ToChar(Console.ReadLine());
                    Alphabet.CheckingVowelOrConsonent(chooseAlphabet);
                    break;
                 case 10:
                    Console.WriteLine("welcome to the largest of three numbers");
                    Console.WriteLine("please enter 1 st value");
                    int firstValue= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter 2 nd  value");
                    int secondValue = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter 3 rd st value");
                    int thirdValue = Convert.ToInt32(Console.ReadLine());
                    LargestNumber.CheckingLargerNUmber(firstValue, secondValue, thirdValue);
                    break;








            }
        }
    }
}