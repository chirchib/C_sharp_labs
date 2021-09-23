using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Дан текст, состоящий не менее из 10 слов. Напечатать все слова из
// текста, отличные от слова hello
namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();

            Console.WriteLine(text.Replace("hello", "").Replace("  ", " ")); ;


            Console.ReadKey();
        }
    }
}

