using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите v:");
            double v = double.Parse(Console.ReadLine());
            double z;
            Console.WriteLine();

            for (double y = -1.5; y < 1.36; y += dy(y))
            {
                y = Math.Round(y, 10);  //иначе double не примет 0

                if (y < 0)
                    z = 1 / (v - 2 * y);
                else if (y == 0)
                    z = 0;
                else z = 1 / (v + y);

                Console.WriteLine(string.Format("{0:0.###} {1:0.###}", y, z));
            }
         
            Console.ReadKey();
        }

        static double dy(double y)
        {
            if (y >= -1.5 && y < 0)
                return 0.15;
            else if ((y >= 0 && y <= 1.36))
                return 0.136;
            else return 0;
        }
    }
}