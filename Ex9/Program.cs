using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool engine = true;
            Random random = new Random();
            do
            {                
                Console.WriteLine("Проверьте свою удачу, а заодно и теорию вероятностей!");
                Console.WriteLine("Введите \"орел\" или \"решка\"");
                string userSide = Console.ReadLine();
                while ((userSide != "орел") && (userSide != "решка"))
                {
                    Console.WriteLine("Некорректное значение. Введите \"орел\" или \"решка\".");
                    userSide = Console.ReadLine();
                }                
                var computerSide = random.Next(2) == 1 ? "решка" : "орел";
                Console.WriteLine("Выпала " + computerSide + ". Вы " + (computerSide == userSide ? "выиграли." : "проиграли."));
                Console.WriteLine("Желаете играть еще? Ответьте \"да\" или \"нет\".");
                string answer = Console.ReadLine();
                while ((answer != "да") && (answer != "нет"))
                {
                    Console.WriteLine("Некорректный ответ. Введите \"да\" или \"нет\".");
                    answer = Console.ReadLine();                   
                }
                engine = answer != "нет";
            } while (engine);
        }
    }
}
