using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A05B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte idade = 47;
            ushort publico = 45_239;//underline facilita visualização
            float media = 4.5F; // F para float
            decimal estrela = 4.322456789M;//M para decimal
            bool aprovado = false;
            var y = 5;

            int salárioBruto;
            float _nota;


            Console.WriteLine(y.GetType());
            Console.ReadKey();

        }
    }
}
