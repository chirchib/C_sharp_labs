using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double C = 2 * Math.Pow(x, 4) - 3 * Math.Pow(x, 3) - 5 * x + 6;
            Console.WriteLine(C.ToString());

            Console.ReadKey();
        }
    }
}
