using DZ6;
using System;

namespace DZ4
{
    class Ilya_artyukhin4
    {
        static void Main()
        {
            //a)
            Console.WriteLine("Обмена значений двух переменных. Артюхин Илья Сергеевич");
            Console.WriteLine("Обмена значений двух переменных. С тремя переменными ");
            Console.WriteLine("Введите первую переменную");
            string x = Console.ReadLine(); 
            Console.WriteLine("Введите вторую переменную");
            string y = Console.ReadLine();
            Console.WriteLine(x + " " + y);
            string z = x;
            x = y;
            y = z;
            Console.WriteLine(x + " " + y);
            Console.ReadKey();
            //б)
            Console.WriteLine("Обмена значений двух переменных. С двумя переменными. Если записываемые данные будут числовыми.");
            Console.WriteLine("Введите первую переменную");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x1 + " " + y1);
            y1 = y1 + x1;
            x1 = y1 - x1;
            y1 = y1 - x1;
            Console.WriteLine(x1 + " " + y1);
            Ilya_artyukhin6.Pause();

        }
    }
}
