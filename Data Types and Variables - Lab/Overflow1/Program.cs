using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            BigInteger someValue = 0;
            //biggest integer; need to write "using System.Numerics;"
            //доста по-бавно от int

            for (int i = 0; i < 1000; i++)
            {
                someValue *= long.MaxValue;
            }
            Console.WriteLine(someValue);
        }
    }
}
