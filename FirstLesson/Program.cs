using System;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp > -21 && temp < 6)
            {
                Console.WriteLine("На улице холодно");
            }
            else if (temp > 5 && temp < 16)
            {
                Console.WriteLine("На улице прохладно");
            }
            else if (temp > 15 && temp < 21)
            {
                Console.WriteLine("На улице тепло");
            }
            else if (temp > 20 && temp < 36)
            {
                Console.WriteLine("На улице тепло");
            }
            else if (temp > 35 && temp < 46)
            {
                Console.WriteLine("На улице жарко");
            }
            else Console.WriteLine("Аномальная температура. Замерьте еще раз");
        }
    }
}
