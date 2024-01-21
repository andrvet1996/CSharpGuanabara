using System;
using System.Security.Cryptography;

namespace M02Ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("digite um número em base decimal: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase: 2)} em binário.");
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase: 8)} em octal.");
            Console.WriteLine($"O número {n} corresponde a {Convert.ToString(n, toBase: 16)} em hexadecimal.");
        }
    }
}