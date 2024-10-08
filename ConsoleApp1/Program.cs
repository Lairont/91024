using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Привет {name}!");
            //Console.ReadLine();

            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.WriteLine("Изменить цвет фона и символов.");
            //Console.ResetColor();
            //Console.ReadLine();

            //if (Console.CapsLock == true)
            //{ Console.WriteLine("The Caps Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Caps Lock key is OFF."); }
            //if (Console.NumberLock == true)
            //{ Console.WriteLine("The Num Lock key is ON."); }
            //else
            //{ Console.WriteLine("The Num Lock key is OFF."); }
            //Console.ReadLine();

            //Console.Write("Скрыть курсор ");
            //Console.CursorVisible = false;  
            //bool saveCursorVisibile = Console.CursorVisible;
            //Console.ReadLine();



            Console.WindowWidth = 40;
            Console.WindowHeight = 40;
            Console.Write("Введите сивол:  ");
            string s = Console.ReadLine();
            Console.WriteLine($"На экране будет нарисован квадрат из символов {s}");
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write($"{s}{s}{s}{s}{s}{s}{s}{s}{s}{s}{s}{s}{s}{s}{s}\n{s}             {s}\");
            Console.ReadLine();




        }
    }
}
