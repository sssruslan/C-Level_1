using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Написать метод, возвращающий минимальное из трех чисел
// 2. Написать метод подсчета количества цифр
// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
// 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
// если не прошел (логин: root, пароль: GeekBrains).
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его
// дальше или не пропускает. С помощью цикла do while ограничивать ввод пароля 3 попытками.
// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет индекс массы тела и сообщает, нужно ли человеку
// похудеть или все в норме.
// б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. ИМТ в норме от 18,5 до 24,99. ИМТ = m/h^2
// 6. *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000. 
// Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
// времени выполнения программы, используя структуру DateTime.
// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
// 8. * Разработать рекурсивный метод, который считает сумму чисел от a до b.
// 9. Тестим предыдущую задачу. Ищем сумму от 5 до 55.


namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int caseNumber = Convert.ToInt32(Console.ReadLine());

            switch (caseNumber)
            {
                case 1:
                    Min3(332, 52, 213);
                    break;
                case 2:
                    SumNum(123456789);
                    break;
                case 3:
                    SumOdd();
                    break;
                case 4:
                    Log_In();
                    break;
                case 5:
                    IMT();
                    break;
                case 6:
                    SumGood(1, 1000000000);
                    break;
                case 7:
                    Task_7(5, 55);
                    break;
                case 8:
                    Task_8(5, 55);
                    break;
                case 9:
                    Test_Task_8();
                    break;
                default:
                    Console.WriteLine("Введите номер от 1 до 9.");
                    break;
            }

            Console.ReadKey();
        }

        /// <summary>
        /// 1. Написать метод, возвращающий минимальное из трех чисел
        /// </summary>
        /// <param name="a">целое</param>
        /// <param name="b">целое</param>
        /// <param name="c">целое</param>
        /// <returns>Возвращает минимальное из трех чисел</returns>
        static int Min3(int a, int b, int c)
        {
            if (a <= b && a <= c)
            {
                return a;
            }
            else if (b <= c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        /// <summary>
        /// 2. Написать метод подсчета количества цифр
        /// </summary>
        /// <param name="a">целое</param>
        /// <returns>Рассчитывает количество цифр в числе</returns>
        static int SumNum(int a)
        {
            int count = 0;
            while (a != 0)
            {
                a = a / 10;
                count++;
            }
            return count;
        }

        /// <summary>
        /// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        /// <returns>Сумма всех нечетных чисел.</returns>
        static int SumOdd()
        {
            int Sum = 0;
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else if (a > 0 && a % 2 != 0)
                {
                    Sum += a;
                }
            }
            return Sum;
        }

        /// <summary>
        /// 4.1. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
        /// если не прошел (логин: root, пароль: GeekBrains).
        /// </summary>
        /// <param name="login">логин: root </param>
        /// <param name="password">пароль: GeekBrains</param>
        /// <returns>true или false</returns>
        static bool verify(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 4.2. Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его
        /// дальше или не пропускает. С помощью цикла do while ограничивать ввод пароля 3 попытками.
        /// </summary>
        /// <returns>true или false</returns>
        static bool Log_In()
        {
            int count = 0;
            do
            {
                Console.Write("Логин: ");
                string login = Console.ReadLine();
                Console.Write("Пароль: ");
                string password = Console.ReadLine();
                count++;

                if (verify(login, password))
                {
                    return true;
                }
            } while (count < 3);
            return false;
        }

        /// <summary>
        /// 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет индекс массы тела и сообщает, нужно ли человеку
        /// похудеть или все в норме.
        /// б) Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса. ИМТ в норме от 18,5 до 24,99. ИМТ = m/h^2
        /// </summary>
        static void IMT()
        {
            Console.Write("Рост, м: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Вес, кг: ");
            double m = Convert.ToDouble(Console.ReadLine());
            double imt = m / (h * h);
            Console.WriteLine("ИМТ = {0:F2}", imt);

            if (imt < 18.5)
            {
                Console.WriteLine("Для идеального веса Вам нужно набрать: {0}", (18.5 - imt) * (h * h));
            }
            else if (imt > 24.99)
            {
                Console.WriteLine("Для идеального веса Вам нужно сбросить: {0}", (imt - 24.99) * (h * h));
            }
            else
            {
                Console.WriteLine("У вас идеальный вес");
            }
        }

        /// <summary>
        /// 6. *Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000. 
        /// Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
        /// времени выполнения программы, используя структуру DateTime.
        /// </summary>
        /// <param name="x">начало диапазона</param>
        /// <param name="y">конец диапазона</param>
        static void SumGood(int x, int y)
        {
            DateTime start = DateTime.Now;
            int count = 0;
            for (int i = x; i <= y; i++)
            {
                int sum = 0;
                int temp = i;
                while (temp != 0)
                {
                    sum += temp % 10;
                    temp /= 10;
                }

                if (i % sum == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество хороших чисел: {0}", count);
            Console.WriteLine("Время выполнения программы: {0}", DateTime.Now - start);
        }

        /// <summary>
        /// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a < b)
        /// </summary>
        /// <param name="a">начало диапазона</param>
        /// <param name="b">конец диапазона</param>
        static void Task_7(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Ошибка, a > b. Программа завершена.");
            }
            else
            {
                Console.WriteLine(a);
                if (b > a)
                {
                    Task_7(a + 1, b);
                }
            }
        }

        /// <summary>
        /// б) Разработать рекурсивный метод, который считает сумму чисел от a до b.
        /// </summary>
        /// <param name="a">начало диапазона</param>
        /// <param name="b">конец диапазона</param>
        static int Task_8(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("Ошибка, a > b. Программа завершена.");
                return 0;
            }
            else if (b > a)
            {
                return (b + Task_8(a, b - 1));
            }
            else
            {
                return a;
            }
        }

        static void Test_Task_8()
        {
            Console.WriteLine(Task_8(5, 55));
        }

    }
}
