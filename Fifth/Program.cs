using System;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите делимое число:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число-делтель:");
            var b = Convert.ToInt32(Console.ReadLine());
            if (b != 0)
            {
                Console.WriteLine("Частное от деления " + a + " на " + b + " равно " + (a / b));
                if ((a % b) != 0)
                {
                    Console.WriteLine("Остача от деления - " + (a % b));
                }
            }
            else Console.WriteLine("На ноль делить нельзя");
        }
    }
}
