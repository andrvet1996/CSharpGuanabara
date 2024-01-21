using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01A13A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Andre";
            float sal = 550.7556f;
            int idade = 22;
            int num = 13;
            //Console.WriteLine($"Muito prazer em te conhecer, {nome, 20}!");
            //mostrar o nome usando 20 espaços a direta (-20 a esquerda) 
            Console.WriteLine($"O {nome,-10} tem idade {idade,-5:D} anos e ganha {sal,20:C2} por mês.");//C uma casa decimal
            Console.WriteLine($"O número escolhido foi {num:D3} e em hexadecimal é {num:X}.");
            Console.ReadKey();
        }
    }
}
