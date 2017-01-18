using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exact_sum_of_real_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal sum = 0; 
            // M-то се слага за да покажем че е 'decimal'(зависи от случая)
            for (int i = 0; i < number; i++)
            {
                decimal digit = decimal.Parse(Console.ReadLine());
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
