using System;

namespace Sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму покупки");
            int price = Convert.ToInt32(Console.ReadLine());
            int discount = 0;
            if (price > 1000)
            {
                discount = 100;
            }
            else if (price > 500)
            {
                discount = 50;
            }
            Console.WriteLine("Ваша скидка - " + discount + "$");
            Console.WriteLine("Теперь цена со скидкой составляет - " + (price - discount) + "$");            
        }
    }
}
