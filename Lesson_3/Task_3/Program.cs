using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
//     Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
//     программу, демонстрирующую все разработанные элементы класса.
//  ** Добавить упрощение дробей.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction x = new Fraction(1, 2);
            Fraction y = new Fraction(2, 3);
            Fraction z = new Fraction(311, 5222);

            Console.WriteLine(x.ToString() + " + " + y.ToString() + " = " + x.Plus(y).ToString());
            Console.WriteLine(x.ToString() + " - " + y.ToString() + " = " + x.Minus(y).ToString());
            Console.WriteLine(x.ToString() + " * " + y.ToString() + " = " + x.Multi(y).ToString());
            Console.WriteLine(x.ToString() + " / " + y.ToString() + " = " + x.Division(y).ToString());
            Console.WriteLine(x.ToString() + " + " + z.ToString() + " = " + x.Plus(z).ToString());
            Console.WriteLine(x.ToString() + " - " + z.ToString() + " = " + x.Minus(z).ToString());
            Console.WriteLine(x.ToString() + " * " + z.ToString() + " = " + x.Multi(z).ToString());
            Console.WriteLine(x.ToString() + " / " + z.ToString() + " = " + x.Division(z).ToString());

            Console.ReadKey();
        }
    }

    public class Fraction
    {
        int numerator, denominator;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Fraction()
        {
            numerator = 0;
            denominator = 0;
        }
        
        /// <summary>
        /// Конструктор класса с числителем и знаменателем
        /// </summary>
        public Fraction(int num, int denom)
        {
            numerator = num;
            denominator = denom;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        /// <param name="x2">второе слагаемое</param>
        /// <returns>ответ</returns>
        public Fraction Plus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator + x2.numerator * denominator;
            x3.denominator = denominator * x2.denominator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="x2">вычитаемое</param>
        /// <returns>ответ</returns>
        public Fraction Minus(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator - x2.numerator * denominator;
            x3.denominator = denominator * x2.denominator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        /// <param name="x2">второй множитель</param>
        /// <returns>ответ</returns>
        public Fraction Multi(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.numerator;
            x3.denominator = denominator * x2.denominator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        /// <param name="x2">делитель</param>
        /// <returns>ответ</returns>
        public Fraction Division(Fraction x2)
        {
            Fraction x3 = new Fraction();
            x3.numerator = numerator * x2.denominator;
            x3.denominator = denominator * x2.numerator;
            Reduce(ref x3.numerator, ref x3.denominator);
            return x3;
        }

        /// <summary>
        /// Метод сокращения дробей
        /// </summary>
        /// <param name="a">числитель</param>
        /// <param name="b">знаменатель</param>
        public void Reduce(ref int a, ref int b)
        {
            for (int i = 2; i < Math.Min(a, b); i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a /= i;
                    b /= i;
                    i = 1; // начинаем цикл с начала
                }
            }
        }

        public string ToString()
        {
            return numerator + "/" + denominator;
        }
    }
}
