using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01A07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ESCOLA = "FIEB";
            const float PI = 3.1415f;
            Console.WriteLine("Eu trabalho na  " + ESCOLA);
            Console.WriteLine("O valor de pi é " + PI);
            Console.WriteLine("O valor de pi é " + Math.PI);//declara pi com biblioteca
            Console.ReadKey();

        }
    }
}
