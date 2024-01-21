using System;

namespace M02Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 6;
            int n2 = 9;

            //int n3 = ++n1;
            //int n3 = n1++ + --n2;//primeiro faz o pré, depois a soma e depois o pós.
            //Console.WriteLine($" n1 vale {n1}, n2 vale {n2} e n3 vale {n3}.");

            int j = 9;
            Console.WriteLine($"Antes do incremento j vale {j++}.");
            Console.WriteLine($"Após o incremento j vale {j}.");


        }
    }
}