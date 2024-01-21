using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int n = gerador.Next(100);//gera de 0 a 99
            Console.WriteLine("Acabei de gerar o número " + n);
            Console.ReadKey();
        }
    }
}
