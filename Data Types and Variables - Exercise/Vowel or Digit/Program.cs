using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    default:
            //        Console.WriteLine("other");
            //        break;
            //    case 'a':
            //        Console.WriteLine("vowel");
            //        break;
            //}
            if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'i' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' ||
                symbol == '8' || symbol == '9' || symbol == '0')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
