using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Conversão implícita
            int a = 47;
            float b = a;
            Console.WriteLine("O valor de a é " + a + " do tipo" + a.GetType());
            Console.WriteLine("O valor de b é " + b + " do tipo" + b.GetType());
            Console.ReadKey();
            

            //Conversão explícita
            float x = 0.75f;
            int y = (int) x;//irá truncar o número
            Console.WriteLine("O valor de a é " + x + " do tipo" + x.GetType());
            Console.WriteLine("O valor de b é " + y + " do tipo" + y.GetType());
            Console.ReadKey();*/

            //Conversão por classes auxiliares
            float x = 0.75f;
            int y = Convert.ToInt16(x);//inteiro mais próximo de 0.75
            Console.WriteLine("O valor de a é " + x + " do tipo" + x.GetType());
            Console.WriteLine("O valor de b é " + y + " do tipo" + y.GetType());
            Console.ReadKey(); 




        }
    }
}
