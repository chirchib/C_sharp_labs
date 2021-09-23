using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Переменной T присвоить значение TRUE, если в массиве Х, содержащем
// n вещественных чисел, нет нулевых элементов и при этом
// положительные элементы чередуются с отрицательными, и значение
// FALSE иначе.

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool T = false;

            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] X = new double[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                X[i] = random.Next(-1, 1) + random.NextDouble();
                Console.Write("{0,6:0.##}", X[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < n - 1; i++)
            {
                if ((X[i] < 0 && X[i + 1] > 0) || (X[i] > 0 && X[i + 1] < 0))
                    T = true;
                else
                {
                    T = false;
                    break;
                }
            }

            if (T)
                Console.WriteLine("T = true");
            else Console.WriteLine("T = false");

            Console.ReadKey();
        }
    }
}
