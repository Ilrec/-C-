using DZ6;
using System;

namespace DZ3
{
    class Ilya_artyukhin2
    {
        public static void TextOutput(double r)
        {
            
            Console.WriteLine("{0:f2}", r);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчитать расстояние между точками. Артюхин Илья");
            double r;
            double X1;
            double X2;
            double Y2;
            double Y1;
            Console.WriteLine("Введите х1");
            string x1 = Console.ReadLine();
            X1 = Convert.ToDouble(x1);
            Console.WriteLine("Введите y1");
            string y1 = Console.ReadLine();
            Y1 = Convert.ToDouble(y1);
            Console.WriteLine("Введите х2");
            string x2 = Console.ReadLine();
            X2 = Convert.ToDouble(x2);
            Console.WriteLine("Введите y2");
            string y2 = Console.ReadLine();
            Y2 = Convert.ToDouble(y2);
            r = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
            Console.WriteLine(r);
            //a)
            Console.WriteLine("{0:f2}", r );
            Console.ReadKey();
            //б)
            Console.WriteLine($"\nб)");
            TextOutput(r);
            Ilya_artyukhin6.Pause();
        }
    }
}
