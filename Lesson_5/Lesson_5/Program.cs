using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

// Сагитов Руслан Равилевич

// 1. Создать программу, которая будет проверять корректность ввода логина.
//   Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры, и при этом цифра не может быть первой.
//   а) без использования регулярных выражений;
//   б) ** с использованием регулярных выражений.

namespace Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Результат проверки на корректность без регулярных выражений: {0}", LogIn_NoReg(login));
            Console.WriteLine("Результат проверки на корректность c регулярными выражениями: {0}", LogIn_Reg(login));
            Console.ReadKey();
        }

        /// <summary>
        /// Метод проверки корректности логина
        /// </summary>
        /// <param name="login">логин на проверку</param>
        /// <returns>true or false</returns>
        static bool LogIn_NoReg(string login)
        {
            // если длина от 2 до 10 и первый символ не цифра, то проверяем каждый символ на букву или цифру
            if (login.Length>=2 && login.Length<=10 && char.GetNumericValue(login[0])==-1)
            {
                foreach (char item in login)
                {
                    if (char.IsLetterOrDigit(item)==false)
                    {
                        return false;                        
                    }
                }
                return true;
            }
            return false;
        }

        /// <summary>
        /// Метод проверки логина с помощью регулярных выражений
        /// </summary>
        /// <param name="login">логин на проверку</param>
        /// <returns>true or false</returns>
        static bool LogIn_Reg(string login)
        {
            Regex myReg = new Regex(@"^[A-Za-zА-Яа-я][A-Za-zА-Яа-я0-9]{1,9}$");
            return myReg.IsMatch(login);
        }
    }
}
