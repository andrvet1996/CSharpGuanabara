using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A02E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Olá minha linda!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Tudo bem com você?");
            Console.ReadKey();


        }
    }
}
