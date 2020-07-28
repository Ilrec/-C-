using DZ6;
using System;

namespace DZ5
{
    class Ilya_artyukhin5
    {
        public static void Print(int x , int y )
        {
            string im = "Илья";
            string Fam = "Артюхин";
            string Gor = "Уфа";
            Console.WriteLine("{0,50}", $"Имя - {im}");
            Console.WriteLine("{0,70}", $"Фамилия - {Fam}");
            Console.WriteLine("{0,90}", $"Город  - {Gor}");
        }
        public static void Printe(int x, int y)
        {
            string im = "Илья";
            string Fam = "Артюхин";
            string Gor = "Уфа";
            Console.SetCursorPosition(x, y);
            Console.WriteLine(im);
            Console.ReadKey();
            Console.SetCursorPosition(x + 20 , y + 10);
            Console.WriteLine(Fam);
            Console.ReadKey();
            Console.SetCursorPosition(x + 20, y + 10);
            Console.WriteLine(Gor);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу, которая выводит на экран ваше имя, фамилию и город проживания. Артюхин Илья");

            string im = "Илья";
            string Fam = "Артюхин";
            string Gor = "Уфа";
            Console.ReadKey();
            //а)

            Console.WriteLine(" \n Имя - {0} \n Фамилия - {1} \n Город - {2}", im, Fam, Gor);
            Console.ReadKey();

            //б)

            Console.WriteLine(" \n\t\t\t\t\t\t Имя - {0} \n\t\t\t\t\t\t Фамилия - {1} \n\t\t\t\t\t\t Город - {2}" ,im, Fam, Gor);
            Console.ReadKey();

            //в)
            
            Console.WriteLine("Введите кординаты ");
            Console.WriteLine("x"); int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y"); int y = Convert.ToInt32(Console.ReadLine());
            Printe(x, y);
            Print(x, y);
            Ilya_artyukhin6.Pause();
        }
    }
}
