using System;

namespace M02Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = true;
            bool q = false;
            Console.WriteLine($"não {p} = {!p}");
            Console.WriteLine($"{p} e {q} = {p && q}");
            Console.WriteLine($"{p} ou {q} = {p || q}");
        }
    }
}
