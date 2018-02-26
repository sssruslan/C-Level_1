using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Сагитов Руслан Равилевич
/// </summary>

//1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст,
//рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.
//2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
//I=m/(h* h); где m-масса тела в килограммах, h - рост в метрах
//3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат
//используя спецификатор формата .2f(с двумя знаками после запятой);
//© geekbrains.ru 20
//б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде
// метода;
//4. Написать программу обмена значениями двух переменных:
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.
//5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) * Сделать задание, только вывод организуйте в центре экрана
//в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
// x, int y)
// 6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).


namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи: ");
            int caseNumber = Convert.ToInt32(Console.ReadLine());

            switch (caseNumber)
            {
                case 1:
                    Task_1();
                    break;
                case 2:
                    Task_2();
                    break;
                case 3:
                    Task_3();
                    break;
                case 4:
                    Task_4();
                    break;
                case 5:
                    Task_5();
                    break;
                case 6:
                    Task_6();
                    break;
                default:
                    Console.WriteLine("Введите номер от 1 до 6.");
                    break;
            }

            Console.ReadLine();
        }

        /// <summary>
        /// 1. Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
        /// В результате вся информация выводится в одну строчку.
        /// а) используя склеивание;
        /// б) используя форматированный вывод;
        /// в) * используя вывод со знаком $.
        /// </summary>

        static void Task_1()
        {
            Console.WriteLine("Анкета");

            Console.Write("Имя: ");
            string name = Console.ReadLine();

            Console.Write("Фамилия: ");
            string surname = Console.ReadLine();

            Console.Write("Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Рост: ");
            string h = Console.ReadLine();

            Console.Write("Вес: ");
            string m = Console.ReadLine();

            Console.WriteLine(name+" "+surname + " " + age + " " + h + " " + m);
            Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, h, m);
            //в) *используя вывод со знаком $ - не нашел что это такое
        }

        /// <summary>
        /// 2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
        /// I=m/(h* h); где m-масса тела в килограммах, h - рост в метрах
        /// </summary>

        static void Task_2()
        {
            Console.WriteLine("Рост, м: ");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Вес, кг: ");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ИМЦ = " + m/(h*h));
        }

        /// <summary>
        /// 3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
        /// y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат
        /// используя спецификатор формата .2f(с двумя знаками после запятой);
        /// б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде
        /// метода;
        /// </summary>

        static void Task_3()
        {
            Console.Write("x1 = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("{0:F2}", r);
            Console.WriteLine("{0:F2}", Distance(x1, y1, x2, y2));
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        /// <summary>
        /// 4. Написать программу обмена значениями двух переменных:
        /// а) с использованием третьей переменной;
        /// б) * без использования третьей переменной.
        /// </summary>

        static void Task_4()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a+" "+b);

            int t = a;
            a = b; //2
            b = t; //1
            Console.WriteLine(a + " " + b);

            b = a + b; //3
            a = b - a; //3-2=1
            b = b - a; //3-1=2
            Console.WriteLine(a + " " + b);
        }

        /// <summary>
        /// 5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        /// б) * Сделать задание, только вывод организуйте в центре экрана
        /// в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
        /// x, int y)
        /// </summary>

        static void Task_5()
        {
            string name = "Руслан";
            string surname = "Сагитов";
            string city = "Оренбург";

            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);

            Console.WriteLine("{0} {1} {2}", name, surname, city);
            PrintInCenter(name + " " + surname + " " + city, Console.WindowWidth / 2, Console.WindowHeight / 2 + 1); // чуть ниже, чтобы не наложились друг на друга
        }

        static void PrintInCenter(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message); 
        }

        static void Task_6()
        {
            myTemplates.Print("Вывод текста с помощью собственного метода Print из класса myTemplates.\n" +
                "Далее перегруженный метод выводит double и int.\n" +
                "Потом собственный метод Input просит ввести текст.\n" +
                "Далее перегруженный метод Input с приветственным сообщением.");
            myTemplates.Print(1.34);
            myTemplates.Print(34);
            myTemplates.Input();
            myTemplates.Input("Введите значение: ");
        }
    }

    /// <summary>
    /// 6. *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
    /// </summary>

    public static class myTemplates
    {
        /// <summary>
        /// Вывод на экран строки
        /// </summary>
        /// <param name="msg">строка</param>
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Вывод на экран целого числа
        /// </summary>
        /// <param name="x">целое число</param>
        public static void Print(int x)
        {
            Console.WriteLine(x);
        }

        /// <summary>
        /// Вывод на экран числа с запятой
        /// </summary>
        /// <param name="x">число с запятой</param>
        public static void Print(double x)
        {
            Console.WriteLine(x);
        }

        /// <summary>
        /// Запрос ввода от пользователя
        /// </summary>
        /// <returns>Тип возвращаемого значения string</returns>
        public static string Input()
        {
            string msg = Console.ReadLine();
            return msg;
        }

        /// <summary>
        /// Запрос ввода от пользователя с приветственным сообщением
        /// </summary>
        /// <param name="header">Строка, которая выводится на экран перед запросом ввода</param>
        /// <returns>Тип возвращаемого значения string</returns>
        public static string Input(string header)
        {
            Console.WriteLine(header);
            string msg = Console.ReadLine();
            return msg;
        }
    }
}
