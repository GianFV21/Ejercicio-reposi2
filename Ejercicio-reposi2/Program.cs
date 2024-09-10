using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_reposi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Num1, Num2;
            Double Suma = 0;
            Console.WriteLine("Ingrese el numero 1: ");
            Num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2: ");
            Num2 = Double.Parse(Console.ReadLine());
            Suma = Num1 + Num2;
            Console.WriteLine("El resultado de la suma es de: ");
            Console.ReadKey();

        }
    }
}
