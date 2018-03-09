using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Сагитов Руслан Равилевич

//+ 1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
//значения от –10 000 до 10 000 включительно.Написать программу, позволяющую найти и
//вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В
//данной задаче под парой подразумевается два подряд идущих элемента массива.Например,
//для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.
//+ 2. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
//+ массив заданной размерности и заполняющий массив числами от начального значения с
//+ заданным шагом.
//+ Создать свойство Sum, которые возвращают сумму элементов массива, 
//+ метод Inverse, меняющий знаки у всех элементов массива, 
//+ Метод Multi, умножающий каждый элемент массива на определенное число, 
//+ свойство MaxCount, возвращающее количество максимальных элементов.
//+ В Main продемонстрировать работу класса.
//+ б)* Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
// файл

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray array1 = new MyArray(20);
            array1.Print();
            Console.WriteLine("Количество пар, делящихся на 3 = " + array1.Pair_to_N(3));

            MyArray array2 = new MyArray(15, 0, 2);
            array2.Print();

            Console.WriteLine("Сумма: " + array2.Sum);

            array2.Inverse();
            Console.Write("Инверсия: ");
            array2.Print();

            array2.Multi(5);
            Console.Write("Умножаем на 5: ");
            array2.Print();

            Console.WriteLine("Количество максимальных элементов в массиве array1: " + array1.MaxCount);
            Console.WriteLine("Количество максимальных элементов в массиве array2: " + array2.MaxCount);
            MyArray array3 = new MyArray(100000);
            Console.WriteLine("Количество максимальных элементов в массиве array3: " + array3.MaxCount);

            MyArray array4 = new MyArray(@"D:\test.txt");
            Console.WriteLine("Тестим чтение из файла");
            array4.Print();
            Console.WriteLine("Тестим запись в файл массива array1 и чтение файла с обновленными данными");
            array1.Rec(@"D:\test.txt");
            Read(@"D:\test.txt");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод считывания из файла txt
        /// </summary>
        /// <param name="filename">имя файла .txt</param>
        static void Read(string filename)
        {
            if (File.Exists(filename))
            {
                //Считываем все строки из файла
                string[] ss = File.ReadAllLines(filename);
                for (int i = 0; i < ss.Length; i++)
                {
                    Console.Write(ss[i] + " ");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("Error load file");
        }
    }

    class MyArray
    {
        int[] a;
        Random rnd = new Random();
        
        /// <summary>
        /// Создаем целочисленный массив со случайными значениями от -10000 до 10000
        /// </summary>
        /// <param name="n">количество элементов</param>
        public MyArray(int n)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(-10000, 10000);
        }

        /// <summary>
        /// Создаем целочисленный массив, заполняющийся числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="n">количество элементов</param>
        /// <param name="start">значение 0 элемента массива</param>
        /// <param name="step">шаг изменения каждого последующего значения</param>
        public MyArray(int n, int start, int step)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = start + step * i;
            }
        }

        /// <summary>
        /// Читаем массив из файла
        /// </summary>
        /// <param name="filename">имя файла .txt</param>
        public MyArray(string filename)
        {
            //Если файл существует
            if (File.Exists(filename))
            {
                //Считываем все строки из файла
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                //Переводим данные из строкового формата в числовой
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }        
        /// <summary>
        /// Свойство для расчета суммы всех элементов целочисленного массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i];
                }
                return sum;
            }
        }

        /// <summary>
        /// Метод меняющий знаки элементов массива
        /// </summary>
        public void Inverse()
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= -1;
            }            
        }

        /// <summary>
        /// Метод умножающий все элементы массива на число
        /// </summary>
        /// <param name="x">множитель</param>
        public void Multi(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= x;
            }
        }

        /// <summary>
        /// Свойство, показывающие количество элементов массива с максимальным значением
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = a[0];
                int count = 1;
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i]>max)
                    {
                        max = a[i];
                        count = 1; 
                    }
                    else if (a[i] == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        /// <summary>
        /// Выводим на консоль все элементы массива в одной строке
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Выводит количеств пар элементов массива, делящихся на n без остатка
        /// </summary>
        /// <param name="n">делитель</param>
        /// <returns>количество пар элементов массива</returns>
        public int Pair_to_N(int n)
        {
            int count = 0;
            for (int i = 0; i < (a.Length - 1); i++)
            {
                if ((a[i]%n == 0) || (a[i+1]%n == 0))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Свойство для записи в файл
        /// </summary>
        /// <param name="filename"></param>
        public void Rec(string filename)
        {
            //переводим данные из чисел в строки
            string[] a_string = new string[a.Length]; 
            for (int i = 0; i < a_string.Length; i++)
                a_string[i] = Convert.ToString(a[i]);

            //пишем массив со строками в файл
            System.IO.File.WriteAllLines(filename, a_string);
        }   
    }
}
