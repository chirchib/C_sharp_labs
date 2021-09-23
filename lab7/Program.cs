using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





//  1  2  3  4  5  6  7  8  9  10
//  2  3  4  5  6  7  8  9  10  1
//  3  4  5  6  7  8  9  10  1  2
//  4  5  6  7  8  9  10  1  2  3
//  5  6  7  8  9  10  1  2  3  4
//  6  7  8  9  10  1  2  3  4  5
//  7  8  9  10  1  2  3  4  5  6
//  8  9  10  1  2  3  4  5  6  7
//  9  10  1  2  3  4  5  6  7  8
//  10  1  2  3  4  5  6  7  8  9





namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 10; 
            int[,] matrix = new int[N, N];

            matrix[0, 0] = 1;
            for (int i = 0; i < N; i++) // 10 - 1 = 9 / i <= 9 || i < N
            {
                for (int j = 0; j < N - 1; j++)
                {

                    if ((matrix[i, j] + 1) % 10 != 0)
                        matrix[i, j + 1] = (matrix[i, j] + 1) % 10;
                    else
                        matrix[i, j + 1] = 10;
                }

                if (i == N - 1) break;

                if ((matrix[i, 0] + 1) % 10 != 0)
                    matrix[i + 1, 0] = (matrix[i, 0] + 1) % 10;
                else 
                    matrix[i + 1, 0] = 10;
                
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N ; j++)
                {

                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
