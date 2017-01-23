using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalPics = long.Parse(Console.ReadLine());
            long filterTimePerPic = long.Parse(Console.ReadLine());
            long filterPercentage = long.Parse(Console.ReadLine());
            long uploadTimePerPic = long.Parse(Console.ReadLine());

            long goodPics = (long)Math.Ceiling(totalPics * filterPercentage / 100.0);
            long filterTime = totalPics * filterTimePerPic;
            long uploadTime = goodPics * uploadTimePerPic;
            long totalSeconds = filterTime + uploadTime;


            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine("{0:d\\:hh\\:mm\\:ss}", time);
        }
    }
}
