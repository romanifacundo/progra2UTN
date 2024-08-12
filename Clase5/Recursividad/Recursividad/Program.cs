using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    using System;
    using System.Collections;
    using System.Runtime.ConstrainedExecution;

    class Program
    {
        //1. Crear un programa que implemente una función recursiva que calcule el resultado de
        //elevar un entero a otro entero(números solicitados al usuario). Esta función debe
        //crearse de forma recursiva.

        //2. Crear un programa que implemente una función recursiva llamada "MulƟplicar" que
        //reciba dos números enteros solicitados al usuario y retorne el resultado de su
        //mulƟplicación.

        //3. Crear un programa que solicite una cadena al usuario e implemente una función
        //recursiva para inverƟr una cadena de caracteres(recordar que una cadena puede ser
        //tratada como array). 

        /**************************************************************************************/

        //static int Multiplicar(int num1, int num2)
        //{
        //    if (num1 == 0 || num2 == 0)
        //    {
        //        return 0;
        //    }
        //    return num1 + Multiplicar(num1, num2 - 1);
        //}

        //static int Potencia(int bas, int expo)
        //{
        //    if (expo == 0)
        //    {
        //        return 1;
        //    }

        //    return bas * Potencia(bas, expo - 1);
        //}

        static void Main(string[] args)
        {
            //Console.Write("Ingrese la base: ");
            //int bas = int.Parse(Console.ReadLine());

            //Console.Write("Ingrese el exponente: ");
            //int expo = int.Parse(Console.ReadLine());

            //int resultado = Potencia(bas, expo);
            //Console.WriteLine("{0} elevado a la {1} es {2}", bas , expo , resultado);

            //Console.ReadKey();

            //Console.Write("Ingrese el primer número: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Ingrese el segundo número: ");
            //int num2 = int.Parse(Console.ReadLine());


            //int resultado = Multiplicar(num1, num2);
            //Console.WriteLine($"{num1} multiplicado por {num2} es {resultado}"); //use interpolacion para mostrar.

            //Console.ReadKey();
        }
    }

}
