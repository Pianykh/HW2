using System;

namespace Seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату в формате ХХ.ХХ.ХХХХ");
            string date = Console.ReadLine();
            int day = Convert.ToInt32(date.Substring(0, 2));
            int month = Convert.ToInt32(date.Substring(3, 2));
            int year = Convert.ToInt32(date.Substring(6, 4));            
            DateTime dt = new DateTime(year, month, day);
            DateTime today = DateTime.Now;
            DateTime firstDay = DateTime.MinValue;
            if (dt.CompareTo(today) < 0 && dt.CompareTo(firstDay) >= 0)
            {
                Console.WriteLine(dt.DayOfWeek);
            }
            else Console.WriteLine("Ввеженная дата не может быть в будущем либо до 01.01.0001");

            
        }
    }
}
