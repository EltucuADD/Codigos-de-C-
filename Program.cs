using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Celsius, Fahrenheit = 0;

            Console.WriteLine("Ingrese los grados Celsius");
            Celsius = Convert.ToDouble(Console.ReadLine());

            Fahrenheit = Celsius*(33.8);

            Console.WriteLine("La temperatura en grados Fahrenheit es: {0}", Fahrenheit);
            Console.ReadKey();
        }
    }
}
