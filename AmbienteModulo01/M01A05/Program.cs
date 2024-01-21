using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nome = "André";
            Console.WriteLine("A variável nome tem " + nome);
            Console.WriteLine("Nome é do tipo " + nome.GetType());
            Console.ReadKey();

        }
    }
}