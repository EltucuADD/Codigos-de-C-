using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero, Resultado = 0;

            Console.WriteLine("Ingrese un numero entero");
            Numero = Convert.ToInt32(Console.ReadLine());

            Resultado = Numero * 2;

            Console.WriteLine("El resultado es: {0}", Resultado);
            Console.ReadKey();
        }
    }
}
