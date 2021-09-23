using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Описать класс дробей — рациональных чисел, являющихся отношением
// двух целых чисел. Предусмотреть сложение, вычитание, умножение и
// деление дробей
namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();
            Fraction fraction3 = new Fraction();

            Console.WriteLine("Введите числитель первой дроби");
            fraction1.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаминатель первой дроби");
            fraction1.Denominator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите числитель второй дроби");
            fraction2.Numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знаминатель второй дроби");
            fraction2.Denominator = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Сложение:");        
            Console.WriteLine(fraction1.ToString() + " + " + fraction2.ToString() + " = " + Fraction.Addition(fraction1, fraction2).ToString());

            Console.WriteLine("Вычитание:");
            Console.WriteLine(fraction1.ToString() + " - " + fraction2.ToString() + " = " + Fraction.Subtraction(fraction1, fraction2).ToString());
            
            Console.WriteLine("Произведение:");
            Console.WriteLine(fraction1.ToString() + " * " + fraction2.ToString() + " = " + Fraction.Multiplication(fraction1, fraction2).ToString());
            
            Console.WriteLine("Деление:");
            Console.WriteLine(fraction1.ToString() + " : " + fraction2.ToString() + " = " + Fraction.Division(fraction1, fraction2).ToString());

            Console.ReadKey();

        }
    }

    class Fraction
    {
        private int numerator;
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                if (value > 0) numerator = value;
            }
        }

        private int denominator;
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value > 0) denominator = value;
            }
        }

        public Fraction() { }
        public Fraction(int a, int b)
        {
            Numerator = a;
            Denominator = b;
        }

        static public Fraction ReverseFraction(Fraction a)
        {
            Fraction b = new Fraction();
            b.Numerator = a.Denominator;
            b.Denominator = a.Numerator;

            return b;
        }

//          Находим наименьшее общее кратное знаменателей: {\displaystyle M =[b, d]}
//          M=[b, d].
//          Умножаем числитель и знаменатель первой дроби на {\displaystyle M/b
//          }
//          M / b.
//          Умножаем числитель и знаменатель второй дроби на {\displaystyle M/d}M / d.

        static public Fraction Addition(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            int M = lcm(a.Denominator, b.Denominator);

            if (a.Denominator == b.Denominator)
            {
                c.Numerator = a.Numerator + b.Numerator;
                c.Denominator = a.Denominator;
            }
            else
            {
                c.Numerator = a.Numerator * (M / a.Denominator) + b.Numerator * (M / b.Denominator);
                c.Denominator = a.Denominator * M / a.Denominator;
            }

            return c;
        }

        static public Fraction Subtraction(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            int M = lcm(a.Denominator, b.Denominator);

            if (a.Denominator == b.Denominator)
            {
                c.Numerator = a.Numerator - b.Numerator;
                c.Denominator = a.Denominator;
            }
            else
            {
                c.Numerator = a.Numerator * (M / a.Denominator) - b.Numerator * (M / b.Denominator);
                c.Denominator = a.Denominator * M / a.Denominator;
            }


            return c;
        }

        static public Fraction Multiplication(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c.Numerator = a.Numerator * b.Numerator;
            c.Denominator = a.Denominator * b.Denominator;

            return c;
        }

        static public Fraction Division(Fraction a, Fraction b)
        {
            Fraction c = new Fraction();
            c = Multiplication(a, ReverseFraction(b));

            return c;
        }

        static private int gcd(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }

        static private int lcm(int x, int y)
        {
            return Math.Abs(x * y) / gcd(x, y); 
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
