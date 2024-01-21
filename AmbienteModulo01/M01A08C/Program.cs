using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A08C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número ");
            int n = Convert.ToInt32(Console.ReadLine());
            int d = n * 2;
            Console.WriteLine("O dobro de n é " + d);
            Console.ReadKey();
        }
    }
}

