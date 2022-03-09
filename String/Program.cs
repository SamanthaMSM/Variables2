using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string Ciudad;
            Console.WriteLine("Escriba su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("\nEscriba su ciudad: ");
            Ciudad = Console.ReadLine();
            Console.WriteLine("\nHola " + Nombre + ", Bienvenido(a) a " + Ciudad);
            Console.WriteLine("\nPresione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}