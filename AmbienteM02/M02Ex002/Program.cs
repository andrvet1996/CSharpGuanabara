using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace M02Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;

            Console.Write($"Numerador: ");
            int.TryParse(Console.ReadLine(), out n1);

            Console.Write($"Denominador: ");
            int.TryParse(Console.ReadLine(), out n2);

            int res = n1 / n2;
            float resultado = (float)n1 / n2;//forma de casting
            Console.WriteLine($"O resultado da divisão inteira de {n1} ÷ {n2} = {res}");
            Console.WriteLine($"O resultado da divisão real de {n1} ÷ {n2} = {resultado:F1}");

        }
    }
}
