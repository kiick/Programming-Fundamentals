using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = int.Parse(Console.ReadLine());
            var secondChar = int.Parse(Console.ReadLine());
            for (int i = firstChar; i <= secondChar; i++)
            {
                Console.Write(Convert.ToChar(i)+" ");
            }
        }
    }
}
