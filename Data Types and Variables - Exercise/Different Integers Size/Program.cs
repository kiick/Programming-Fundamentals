using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (-128 <= number) && (number <= 127);
            bool isByte = (0 <= number) && (number <= 255);
            bool isShort = (-32768 <= number) && (number <= 32767);
            bool isUshort = (0 <= number) && (number <= 65535);
            bool isInt = (-2147483648 <= number) && (number <= 2147483647);
            bool isUint = (0 <= number) && (number <= 4294967295);
            bool isLong = (-9223372036854775808 <= number) && (number <= 9223372036854775807);

            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine($"{number} can fit in:");
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }

        }
    }
}
