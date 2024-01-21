using System;

namespace M02Ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados 
            float n1 = 0f;
            float n2 = 0f;
            Console.Write($"Primeira nota do aluno: ");
            float.TryParse( Console.ReadLine(), out n1);
            Console.Write($"Segunda nota do aluno: ");
            float.TryParse(Console.ReadLine(), out n2);
            //Cálculo da média e situações
            float média = (n1+n2)/2;
            bool sit1 = média >= 0.0 && média <= 4.0;
            bool sit2 = média >= 4.0 && média <= 7.0;
            bool sit3 = média >= 7.0;
            //Mostrando resultados
            Console.WriteLine($"A média do aluno foi {média:F1}");
            Console.WriteLine($"O aluno está reprovado {sit1}");
            Console.WriteLine($"O aluno está em recuperação? {sit2}");
            Console.WriteLine($"O aluno está aprovado {sit3}");
        }
    }
}
