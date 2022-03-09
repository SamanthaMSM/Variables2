using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            Console.WriteLine("Escriba su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese su edad: ");
            Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("\nTu Nombre es: " + Nombre + " y tienes: " + Edad + " años");
            Console.WriteLine("\nPresiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
