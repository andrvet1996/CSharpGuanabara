using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ini, fim;
            Console.WriteLine("SORTEADOR DE NÚMEROS");
            Console.WriteLine("********************");
            Console.Write("Início: ");
            int.TryParse(Console.ReadLine(), out ini);
            Console.Write("Fim: ");
            int.TryParse(Console.ReadLine(), out fim);

            Console.WriteLine("********************");
            Console.SetCursorPosition(0, 6);//posiciona o Soteando...
            Console.Write("Sorteando...");
            Thread.Sleep(1500);
            Random gerador = new Random();
            int num = gerador.Next (ini, fim + 1);//fim + 1 para gerar todo intervalo
            Console.SetCursorPosition(0, 6);
            Console.WriteLine($"O valor sorteado entre {ini} e {fim} é {num}.");

            Console.ReadKey();
        }
    }
}
