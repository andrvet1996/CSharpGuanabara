using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M02Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplos de operadores aritméticos
            int op1 = 0;
            int op2 = 0;

            Console.Write("Digite o primeiro operando");
            int.TryParse(Console.ReadLine(), out op1);
            Console.Write("Digite o segundo operando");
            int.TryParse(Console.ReadLine(), out op2);

            Console.WriteLine($"Calculando +{op1} = {+ op1}");//operador de identidade
            Console.WriteLine($"Calculando -{op1} = {- op1}"); //operador de negação aritmética
            Console.WriteLine($"Calculando {op1} + {op2} = {op1 + op2}");//operador de adição
            Console.WriteLine($"Calculando {op1} - {op2} = {op1 - op2}");//operador de subtração
            Console.WriteLine($"Calculando {op1} x {op2} = {op1 * op2}");//operador de multiplicação
            Console.WriteLine($"Calculando {op1} ÷ {op2} = {op1 / op2}");//operador de divisão inteira
            Console.WriteLine($"Calculando {op1} resto {op2} = {op1 % op2}");//resto inteiro da divisão
            Console.ReadKey();
        }
    }
}
