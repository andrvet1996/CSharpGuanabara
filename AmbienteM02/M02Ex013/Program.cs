using System;
using System.Security.Cryptography;

namespace M02Ex013
{
    class Program
    {
        static void Main(string[] args)
        {
            int lotação = 10;
            int total = 0;

            int grupo = 0;
            Console.Write("Quantas pessoas chegaram? ");
            int.TryParse(Console.ReadLine(), out grupo);
            total += grupo;

            Console.WriteLine($"Chegando um grupo de {grupo} pessoas, agora temos {total} pessoas na festa");

            Console.WriteLine($"Lotou a balada? {total>= lotação}");
        }
    }
}
