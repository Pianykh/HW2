using System;
using System.Text.RegularExpressions;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexName = new Regex("^[А-Я][а-я]+$");
            Regex regexAge = new Regex("^[0-9]+$");
            Console.WriteLine("Введите имя первого человека");
            string firstName = Convert.ToString(Console.ReadLine());
            while (!regexName.IsMatch(firstName))
            {
                Console.WriteLine("Некорректный ввод данных. Введите имя кириллицей и с большой буквы.");
                firstName = Convert.ToString(Console.ReadLine());
            }           
            Console.WriteLine("Введите возраст первого человека.");
            string firstAge = Convert.ToString(Console.ReadLine());
            while (!regexAge.IsMatch(firstAge))
            {
                Console.WriteLine("Некорректный ввод данных. Введите возраст в годах, целым числом.");
                firstAge = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Введите имя второго человека.");
            string secondName = Convert.ToString(Console.ReadLine());
            while (!regexName.IsMatch(firstName))
            {
                Console.WriteLine("Некорректный ввод данных. Введите имя кириллицей и с большой буквы.");
                secondName = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Введите возраст второго человека.");
            string secondAge = Convert.ToString(Console.ReadLine());
            while (!regexAge.IsMatch(secondAge))
            {
                Console.WriteLine("Некорректный ввод данных. Введите возраст в годах, целым числом.");
                secondAge = Convert.ToString(Console.ReadLine());
            }
            bool isFirstOlder = Convert.ToInt32(firstAge) > Convert.ToInt32(secondAge) ? true : false;
            Console.WriteLine("Введите имя человека, который старше.");
            string selectedName = Convert.ToString(Console.ReadLine());
            while (selectedName != firstName && selectedName != secondName)
            {
                Console.WriteLine("Некорректный ввод данных. Введите имя человека, который старше - " +
                    "или \"" + firstName + "\" или \"" + secondName + "\"");
                selectedName = Convert.ToString(Console.ReadLine());
            }
            if (Convert.ToInt32(firstAge) == Convert.ToInt32(secondAge))
            {
                Console.WriteLine("Возраст у людей одиннаковый.");
                return;
            }
            if (selectedName == firstName)
            {
                if (isFirstOlder)
                {
                    Console.Write("Верно.");
                    Console.WriteLine(" " + firstName + " старше на " + (Convert.ToInt32(firstAge) - Convert.ToInt32(secondAge)));
                }
                else
                {
                    Console.Write("Неверно.");
                    Console.WriteLine(" " + secondName + " старше на " + (Convert.ToInt32(secondAge) - Convert.ToInt32(firstAge)));
                }

            }
            else if (isFirstOlder)
            {
                Console.Write("Верно.");
                Console.WriteLine(" " + firstName + " старше на " + (Convert.ToInt32(firstAge) - Convert.ToInt32(secondAge)));
            }
            else
            {
                Console.Write("Неверно.");
                Console.WriteLine(" " + secondName + " старше на " + (Convert.ToInt32(secondAge) - Convert.ToInt32(firstAge)));
            }

        }
    }
}
