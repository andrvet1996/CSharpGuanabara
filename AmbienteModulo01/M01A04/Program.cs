using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue);
            Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue);
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue);
            Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue);
            Console.ReadKey();
        }
    }
}
