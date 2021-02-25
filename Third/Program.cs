using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("Наибольшее число из введенных - " + a);
                }
                else Console.WriteLine("Наибольшее число из введенных - " + c);
            }
            else if (b > c)
            {
                if (b > a)
                {
                    Console.WriteLine("Наибольшее число из введенных - " + b);
                }
                else Console.WriteLine("Наибольшее число из введенных - " + a);
            }
            else Console.WriteLine("Наибольшее число из введенных - " + c);

        }
    }
}
