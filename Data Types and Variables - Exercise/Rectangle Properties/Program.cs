using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var perimeter = 2 * width + 2 * height;
            var area = width * height;
            double diagonal = width * width + height * height;
            diagonal = Math.Sqrt(diagonal);
            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");
        }
    }
}
