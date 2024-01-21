using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A12A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Tudo bem?");
            Console.ReadKey();
        }
    }
}
