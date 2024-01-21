using System;

namespace M02Ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string nome = null;
            //Console.WriteLine($"A variável possui valor nulo? {nome is null}.");
            //Nullable<int> num = null; o tipo int é não anulável. Forma antiga de anular.
            int? num = null;//forma atual de anular
            int x = num ?? 0;//operadr de coalescência nula

            Console.WriteLine($"A variável possui valor nulo? {num is null}.");
            Console.WriteLine($"A variável possui valor nulo? {num.HasValue}.");
            Console.WriteLine($"A variável x recebeu o valor {x}.");

        }
    }
}
