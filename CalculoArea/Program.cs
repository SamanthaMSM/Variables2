using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int Area = (a * b/2);

            Console.WriteLine("El Área del triángulo es: " + Area);
            Console.WriteLine("Presiona una tecla para finaliDzar");
            Console.ReadKey();

        }
    }
}
