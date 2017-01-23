using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 2; number <= n; number++)
            {
                bool prime = true;
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {prime}");
            }

        }
    }
}
