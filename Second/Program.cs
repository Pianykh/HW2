using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            int century = (year / 100) + 1;
            Console.WriteLine("Введенный год относится к " + century + " веку");
        }
    }
}
