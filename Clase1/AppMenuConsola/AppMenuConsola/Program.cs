using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMenuConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables.
            int numeroInicio, num1, num2, opcion;
            bool ingresoExitoso;

            //Console.Write("SI QUIERES INGRESAR AL SISTEMA PRESIONA (1) - ");
            //numeroInicio = int.Parse(Console.ReadLine());


            do
            {
                // menu 
                Console.WriteLine("*************************");
                Console.WriteLine("ELIJA UNA OPCION DEL MENU");
                Console.WriteLine("1) SUMAR");
                Console.WriteLine("2) RESTAR");
                Console.WriteLine("3) MULTIPLICAR");
                Console.WriteLine("*************************");

                ingresoExitoso = int.TryParse(Console.ReadLine(), out opcion);

                if(ingresoExitoso == false) 
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("*************************");
                    Console.WriteLine("DEBES INGRESAR SOLO NUMEROS");
                    Console.WriteLine("*************************");
                    Console.WriteLine("\n");
                }

            } while (!ingresoExitoso);


            Console.WriteLine("Ingresa un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa otro numero");
            num2 = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("El resultado de la suma es {0}", num1 + num2);
                    break;
                case 2:
                    Console.Write("El resultado de la suma es {0}", num1 - num2);
                    break;
                case 3:
                    Console.Write("El resultado de la suma es {0}", num1 * num2);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
