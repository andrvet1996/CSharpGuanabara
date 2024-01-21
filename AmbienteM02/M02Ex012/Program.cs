using System;
using System.Security.Cryptography;

namespace M02Ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 8;
            int c = 2;

            //b = a = c;
            b = a = c = 1000;

            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
