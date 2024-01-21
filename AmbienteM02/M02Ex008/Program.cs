using System;

namespace M02Ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            int num = 0;
            Console.WriteLine("Digite um número inteiro");
            int.TryParse(Console.ReadLine(), out num);           
            //Mostrar resultado
            Console.WriteLine($"O número {num:D} que você digitou é {((num%2==0)?"PAR":"ÍMPAR")}");
        }
    }
}

