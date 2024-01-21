using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A12C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sal = 0;
            Console.Write("Qual o seu salário? ");
            float.TryParse(Console.ReadLine(), out sal);
            string nome = Console.ReadLine();
            Console.WriteLine($"Você ganha {sal:C} por mês.");//C mostra valor monetário
            Console.ReadKey();
        }
    }
}
