using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x1 = 0;
            double x2 = 0;

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
                Console.WriteLine("Уравнение не имеет действительных корней");
            else
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;

                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }

            Console.ReadKey();
        }
    }
}
