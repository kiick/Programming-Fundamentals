using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        char letterOne = (char)('a' + i);
                        char letterTwo = (char)('a' + k);
                        char letterThree = (char)('a' + j);
                        Console.WriteLine($"{letterOne}{letterTwo}{letterThree}");
                    }
                }
            }
        }
    }
}
