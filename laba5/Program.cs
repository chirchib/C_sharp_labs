using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Используя индивидуальные задания к лабораторной работе №4 и подготовленные в процессе ее выполнения 
// три программы решения задачи с различными операторами циклов, 
// построить алгоритм, написать и отладить соответствующую ему программу с двухуровневым меню,
// организованном с помощью операторов выбора.
// Внешнее меню обеспечивает режимы:
//  ⎯ ввод исходных данных; 
//  ⎯ просмотр результатов; 
//  ⎯ вход во внутреннее меню;
//  ⎯ выход из программы. 
// Внутреннее меню обеспечивает режимы: 
// ⎯ расчет и вывод результатов работы программы с применением оператора цикла с параметром;
//  ⎯ расчет и вывод результатов работы программы с применением оператора цикла с предусловием;
//  ⎯ расчет и вывод результатов работы программы с применением оператора цикла с постусловием;
//  ⎯ выход во внешнее меню

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str_v = "empty";
            double v = 0;
            double z;

            char choice, choice1;
            do
            {
                Console.WriteLine("1. Ввод исходных данных\n" +
                              "2. Просмотр результатов\n" +
                              "3. Внутреннее меню\n" +
                              "4. Выход");

                Console.WriteLine("Выбор: ");
                choice = Console.ReadKey(true).KeyChar;
                switch (choice)
                {
                    case '1':

                        Console.WriteLine("Введите v:");
                        str_v = Console.ReadLine();
                        v = double.Parse(str_v);
                        Console.WriteLine();

                        break;
                    case '2':

                        if (str_v == "empty")
                            Console.WriteLine("Сначала введите значение v");
                        else
                        {
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
                        }

                        break;
                    case '3':                        
                        
                        do
                        {
                            Console.WriteLine("1. Расчет и вывод результатов работы программы с применением оператора цикла с параметром\n" +
                             "2. Расчет и вывод результатов работы программы с применением оператора цикла с предусловием\n" +
                             "3. Расчет и вывод результатов работы программы с применением оператора цикла с постусловием\n" +
                             "4. Вернуться");

                            Console.WriteLine("Выбор: ");
                            choice1 = Console.ReadKey(true).KeyChar;

                            switch (choice1)
                            {
                                case '1':

                                    if (str_v == "empty")
                                        Console.WriteLine("Сначала введите значение v");
                                    else
                                    {
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
                                    }

                                    break;
                                case '2':

                                    if (str_v == "empty")
                                        Console.WriteLine("Сначала введите значение v");
                                    else
                                    {
                                        double y = -1.5;
                                        while (y < 1.36)
                                        {
                                            y = Math.Round(y, 10);  //иначе double не примет 0

                                            if (y < 0)
                                                z = 1 / (v - 2 * y);
                                            else if (y == 0)
                                                z = 0;
                                            else z = 1 / (v + y);

                                            Console.WriteLine(string.Format("{0:0.###} {1:0.###}", y, z));
                                            y += dy(y);
                                        }

                                    }

                                    break;
                                case '3':

                                    if (str_v == "empty")
                                        Console.WriteLine("Сначала введите значение v");
                                    else
                                    {
                                        double y = -1.5;
                                        do
                                        {
                                            y = Math.Round(y, 10);  //иначе double не примет 0

                                            if (y < 0)
                                                z = 1 / (v - 2 * y);
                                            else if (y == 0)
                                                z = 0;
                                            else z = 1 / (v + y);

                                            Console.WriteLine(string.Format("{0:0.###} {1:0.###}", y, z));
                                        } while (y < 1.36);
                                    }

                                    break;
                                default:

                                    break;
                            }
                        } while (choice1 != '4');

                        break;
                    default:

                        break;
                }
            } while (choice != '4');



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
