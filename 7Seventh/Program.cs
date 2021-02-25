using System;

namespace Seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные");      
             
            var data = Console.ReadLine();
            if (DateTime.TryParse(data, out DateTime dateTime)) {
                Console.WriteLine("Это значение объекта DateTime");
            }
            else if (int.TryParse(data, out int number))
            {
                Console.WriteLine("Это целое число");
            }
            else if (double.TryParse(data, out double doubleNumber))
            {
                Console.WriteLine("Это число с плавающей точкой");
            }
            else if (char.TryParse(data, out char character))
            {
                Console.WriteLine("Это символ");
            }
            else if (bool.TryParse(data, out bool boolean)) {
                Console.WriteLine("Это булевый тип данных");
            }
            else Console.WriteLine("Это строка");
        }
    }
}
