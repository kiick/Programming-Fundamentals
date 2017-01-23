using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            var exchange = a;
            a = b;
            b = exchange;
            Console.WriteLine($"Before:\na = 5\nb = 10\nAfter:\na = {a}\nb = {b}");

        }
    }
}
