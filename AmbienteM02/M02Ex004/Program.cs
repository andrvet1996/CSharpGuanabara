using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace M02Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.WriteLine("************************");
            Console.Write("Digite um número: "); 
            int.TryParse(Console.ReadLine(), out n1);
            Console.Write("Digite outro número: ");
            int.TryParse(Console.ReadLine(), out n2);
            Console.WriteLine("************************");

            Console.WriteLine($"{n1} = {n2} ? {n1 == n2}");
            Console.WriteLine($"{n1} ≠ {n2} ? {n1 != n2}");
            Console.WriteLine($"{n1} > {n2} ? {n1 > n2}");
            Console.WriteLine($"{n1} < {n2} ? {n1 < n2}");
            Console.WriteLine($"{n1} >= {n2} ? {n1 >= n2}");
            Console.WriteLine($"{n1} <= {n2} ? {n1 <= n2}");
            Console.WriteLine($"{n1} é inteiro? {n1 is int}");
        }
    }
}

