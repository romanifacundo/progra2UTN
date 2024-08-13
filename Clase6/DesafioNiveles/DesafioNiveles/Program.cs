using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioNiveles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int niveles;
            string cadena;

            Console.WriteLine("Ingresa el numero de niveles pasados");
            cadena = Console.ReadLine();
            //niveles = int.Parse(Console.ReadLine());

            while (!int.TryParse(cadena, out niveles))
            {
                Console.WriteLine("Debes ingresar un numero");
                cadena = Console.ReadLine();
            }

            Console.WriteLine("Tu puntuacion es: " + Calculo(niveles));

            Console.ReadKey();
        }

        static int Calculo(int n) 
        {
            if (n == 1) return 1;

            return n + Calculo(n - 1);
        }
           
    }
}
