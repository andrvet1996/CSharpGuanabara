using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A11A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            Console.Write("Hoje é dia ");//escreve e não quebra linha
            Thread.Sleep(1000);
            Console.Write(dia);
            Thread.Sleep(1000);
            Console.Write(" do mês ");
            Thread.Sleep(1000);
            Console.WriteLine(mes);//quebra linha
            Thread.Sleep(2000);
        }
    }
}
