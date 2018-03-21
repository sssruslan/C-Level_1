using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//2. * Модифицировать программу нахождения минимума функции так, чтобы можно было
//     передавать функцию в виде делегата. 
//     Сделать меню с различными функциями и представьте
//     пользователю выбор для какой функции и на каком отрезке находить минимум. 
//     Используйте массив делегатов. - Не понял о чем речь

namespace DoubleBinary
{
    class Program
    {
        delegate double Function(double a, double x);

        private static double F1(double a, double x)
        {
            return a * x * x;
        }

        private static double F2(double a, double x)
        {
            return a * Math.Sin(x);
        }
        
        public static void SaveFunc(string fileName, double a, double b, double h, int func)
        {
            // используя делегат выбираем нужную функцию и дальше ее используем (строка 48)
            Function del;
            if (func == 1)
            {
                del = F1;
            }
            else
            {
                del = F2;
            }

            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(del.Invoke(a, x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static int[] Menu()
        {
            int[] variables = new int[3];

            Console.Write("Выберите функцию: 1 - a*x^2; другое число - a*sin(x): ");
            variables[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("На каком отрезке функции находить минимум?\n" +
                "Введите начальное значение X и конечное.\n" +
                "При этом a = начальному значению отрезка: ");
            variables[1] = Convert.ToInt32(Console.ReadLine());
            variables[2] = Convert.ToInt32(Console.ReadLine());

            return variables;
        }

        static void Main(string[] args)
        {
            int[] variables = Menu();

            SaveFunc("data.bin", variables[1], variables[2], 0.5, variables[0]);
            Console.WriteLine(Load("data.bin"));
            
            Console.ReadKey();
        }
    }
}