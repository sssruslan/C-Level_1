using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

// 3. Подсчитать количество студентов:
//   + а) учащихся на 5 и 6 курсах;
//   + б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный
//       массив);
//   + в) отсортировать список по возрасту студента;
//   + г) отсортировать список по курсу и возрасту студента.

class Student
{
    public string surname;
    public string name;
    public int course;
    public int age;

    // Создаем конструктор
    public Student(string surname, string name, int course, int age)
    {
        this.surname = surname;
        this.name = name;
        this.course = course;
        this.age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        GenerationCollection(20);

        int course5 = 0;
        int course6 = 0;
        List<Student> list = new List<Student>(); // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("list.csv");
        int[] count = new int[6]; // массив из количества студентов 18-20 лет, обучающихся на 1-6 курсах

        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], int.Parse(s[2]), int.Parse(s[3])));
                
                // Одновременно подсчитываем количество студентов 5 и 6 курсов
                if (int.Parse(s[2]) == 5)
                {
                    course5++;
                }
                else if (int.Parse(s[2]) == 6)
                {
                    course6++;
                }
                
                // заполняем массив количества студентов 18, 19, 20 лет, обучающихся на 1-6 курсах
                if (int.Parse(s[3])>=18 && int.Parse(s[3]) <= 20)
                {
                    count[int.Parse(s[2])-1]++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        list.Sort(new Comparison<Student>(MyDelegat1)); // сортируем по возрасту

        Console.WriteLine("Студентов 5 курса: {0}", course5);
        Console.WriteLine("Студентов 6 курса: {0}", course6);
        Console.WriteLine();

        Console.WriteLine("Список студентов, отсортированных по возрасту:");
        foreach (var v in list)
        {
            Console.WriteLine("Возраст {0}: {1} {2}", v.age, v.surname, v.name);
        }
        Console.WriteLine();

        Console.WriteLine("Количество студентов 18-20 лет, обучающихся на 1-6 курсах:");
        for (int i=0; i<count.Length;i++)
        {
            Console.WriteLine("Курс: {0} Кол-во: {1}", i+1, count[i]);
        }
        Console.WriteLine();

        list.Sort(new Comparison<Student>(MyDelegat2)); // сортируем по курсу и возрасту
        Console.WriteLine("Список студентов, отсортированных по курсу и возрасту:");
        foreach (var v in list)
        {
            Console.WriteLine("Курс: {0} Возраст: {1}: {2} {3}", v.course, v.age, v.surname, v.name);
        }
        Console.WriteLine();

        Console.WriteLine("Время выполнения программы = " + (DateTime.Now - dt));
        Console.ReadKey();
    }

    /// <summary>
    /// Генератор списка фамилий, имен, курсов, возрастов
    /// </summary>
    /// <param name="n">Количество студентов</param>
    static void GenerationCollection(int n)
    {
        StreamWriter generList = new StreamWriter(new FileStream("list.csv", FileMode.Create, FileAccess.Write));
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            // генерируем случайные фамилии
            int z = rand.Next(2, 10);
            char[] surname = new char[z];
            for (int j = 0; j < z; j++)
            {
                if (j == 0)
                {
                    surname[j] = (char)rand.Next(0x0041, 0x005A);
                }
                else
                {
                    surname[j] = (char)rand.Next(0x0061, 0x007A);
                }
            }

            // генерируем случайные имена
            int y = rand.Next(2, 10);
            char[] name = new char[y];
            for (int j = 0; j < y; j++)
            {
                if (j == 0)
                {
                    name[j] = (char)rand.Next(0x0041, 0x005A);
                }
                else
                {
                    name[j] = (char)rand.Next(0x0061, 0x007A);
                }
            }

            // генерируем курс
            int cource = rand.Next(1, 6);

            // генерируем возраст
            int age = rand.Next(17, 25);

            // записываем строку в csv файл
            generList.WriteLine(new string(surname) + ";" + new string(name) + ";" + cource + ";" + age);
        }
        generList.Close();
    }

    static int MyDelegat1(Student st1, Student st2) // Создаем метод для сравнения для экземпляров по возрасту
    {
        if (st1.age > st2.age)
            return 1;
        else if (st1.age < st2.age)
            return -1;
        else
            return 0;
    }

    static int MyDelegat2(Student st1, Student st2) // Создаем метод для сравнения для экземпляров по курсу и возрасту
    {
        if (st1.course > st2.course)
            return 1;
        else if (st1.course < st2.course)
            return -1;
        else
        {
            if (st1.age > st2.age)
                return 1;
            else if (st1.age < st2.age)
                return -1;
            else
                return 0;
        }            
    }
}