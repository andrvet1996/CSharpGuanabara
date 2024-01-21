using System;

namespace M02Ex007
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            float altura = 0f;
            Console.WriteLine("Qual é a sua altura (em metros)? ");
            float.TryParse(Console.ReadLine(), out altura);
            //Verificação de status
            string status = (altura <= 1.70) ? "baixo" : "alto";
            //Mostrar resultado
            Console.WriteLine($"Alguém com {altura:F2}m de altura é considerado {status}.");
        }
    }
}
