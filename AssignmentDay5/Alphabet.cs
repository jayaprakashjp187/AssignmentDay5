using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay5
{
     class Alphabet
    {
        public static void CheckingVowelOrConsonent(char chooseAlphabet)
        {
            switch(chooseAlphabet)
            {
                case 'a':
                    Console.WriteLine(chooseAlphabet +  " is a vowel");
                    break;
                case 'e':
                    Console.WriteLine(chooseAlphabet +  " is a vowel");
                    break;
                case 'i':
                    Console.WriteLine(chooseAlphabet +   " is a vowel");
                    break;
                case 'o':
                    Console.WriteLine(chooseAlphabet +  " is a vowel");
                    break;
                case 'u':
                    Console.WriteLine(chooseAlphabet +  " is a vowel");
                    break;
                default:
                    Console.WriteLine(chooseAlphabet + " consonent");
                    break;

            }
        }
    }
}
