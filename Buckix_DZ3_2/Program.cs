//========================================================================
// Создайте класс «Веб-сайт». Необходимо хранить в полях класса:
// название сайта, путь к сайту, описание сайта, ip адрес сайта.
// Реализуйте методы класса для ввода данных, вывода данных, реализуйте
// доступ к отдельным полям через методы класса. 
//========================================================================
using System;

namespace Buckix_DZ3_2
{
    class Program
    {
        static int Main()
        {
            Console.Title = "Создайте класс «Веб-сайт»";
            string[] msg = { "Введите название сайта: ", "Введите путь к сайту: ", "Введите описание сайта: ", "Введите IP адрес сайта: " };
            Console.WriteLine();
            Website website = new Website { Name = InputText(msg[0]), Path = InputText(msg[1]), Note = InputText(msg[2]), Ip = InputText(msg[3]) };
            Console.WriteLine(website.ToString());
            return 0;
        }

        static string InputText(string msg)
        {
            Console.Write(msg);
            return Console.ReadLine();
        }
    }
}