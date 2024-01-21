using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int nasc;
            int.TryParse(Console.ReadLine(), out nasc);
            int atual = DateTime.Now.Year;
            int idade = atual - nasc;
            Console.WriteLine("*****************************");
            Console.WriteLine($"Estamos em {atual}.");
            Console.WriteLine($"Se você nasceu em {nasc} terá {idade} anos.");
            Console.ReadKey();
        }
    }
}
