using DZ6;
using System;

namespace DZ2
{
    class Ilya_artyukhin2
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Рассчитать и вывести индекс массы тела. Артюхин Илья"); 
                double ves;
                double ros;
                Console.WriteLine("Введите свой вес в киллограмах, для отделения от цельного числа используйте запятую");
                string v = Console.ReadLine();
                ves = Convert.ToDouble(v);
                Console.WriteLine("Введите свой рост в метрах, для отделения от цельного числа используйте запятую");
                string r = Console.ReadLine();
                ros = Convert.ToDouble(r);
                double f = ves / (ros * ros);
                Console.WriteLine("Ваш индекс массы тела равен: " + f);
                Ilya_artyukhin6.Pause();
            }
    }

    }

}
