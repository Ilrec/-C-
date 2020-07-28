using DZ6;
using System;

namespace ConsoleApp1
{
    class Ilya_artyukhin1
    {
        static void Main(string[] args)
        {
            Console.WriteLine( " Задание Анкета, Артюхин Илья");
            Console.WriteLine("Как вас зовут?");
            string Name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия?");
            string Fam = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string Let = Console.ReadLine();
            Console.WriteLine("Какого вы роста?");
            string Rost = Console.ReadLine();
            Console.WriteLine("Сколько вы весите?");
            string Ves = Console.ReadLine();
            //a)
            Console.WriteLine("Склеивание");
            Console.WriteLine(" Анкета " + " Имя: " + Name  + "; Фамилия: " + Fam  + "; Возраст: " + Let  + "; Рост: " + Rost  + "; Вес: " + Ves);
            Console.ReadKey();
            //б)
            Console.WriteLine("Формативный");
            Console.WriteLine(" Анкета \n Имя: {0}; Фамилия: {1}; Возраст: {2};  Рост: {3};  Вес: {4}; ", Name, Fam, Let, Rost, Ves);
            Console.ReadKey();
            //в)
            Console.WriteLine("Интерполяция");
            Console.WriteLine($" Анкета \n Имя: {Name} \n Фамилия: {Fam} \n Возраст: {Let} \n Рост: {Rost} \n Вес: {Ves} ") ;
            Ilya_artyukhin6.Pause();


        }
    }
}
