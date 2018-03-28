using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//+ 1. а) создать приложение показанное на уроке;
//+ б) изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов, и добавив
//  другие косметические улучшения на свое усмотрение;
//+ в) добавить в приложение меню “О программе” с информацией о программе(автор, версия,
//  авторские права и др.);
//+ г) добавить в приложение сообщение с предупреждением при попытке удалить вопрос;
//+ д) добавить пункт меню Save As в котором можно выбрать имя для сохранения базы данных
//  (элемент SaveFileDialog);
//2. * Используя полученные знания и класс TrueFalse, разработать игру “Верю-Не верю”

namespace BelieveOrNotBelieve
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
