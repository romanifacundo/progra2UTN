﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Cree un programa que solicite un valor inicial y un valor final y que imprima todos los
            //números impares del rango ingresado.En caso no haya ningún número en el rango
            //establecido o el usuario haya ingresado un rango incorrecto, mostrar un mensaje
            //informativo.

            //int inicial, final;

            //Console.WriteLine("ingrese el valor inicial");
            //inicial = int.Parse(Console.ReadLine());
            //Console.WriteLine("ingrese el valor final");
            //final = int.Parse(Console.ReadLine());

            //if (inicial > final)
            //{
            //    Console.WriteLine("rango incorrecto");
            //}
            //else
            //{          
            //    bool banderaImp = false;
            //    Console.WriteLine("numeros impares en el rango:");

            //    for (int i = inicial; i <= final; i++)
            //    {
            //        if (i % 2 == 1)
            //        {
            //            Console.WriteLine(i);
            //            banderaImp = true;
            //        }
            //    }

            //    if (!banderaImp)
            //    {
            //        Console.WriteLine("no hay numeros impares ");
            //    }
            //}
            //Console.ReadKey();

            // Intento de diferentes formas de hacer el ejercicio.

            //while (inicial < final && final > inicial) 
            //{
            //    num = double.Parse(Console.ReadLine());

            //    if (num < inicial && num > final)
            //    {
            //        Console.WriteLine("INGRESE UN NUMERO DENTRO DEL RANGO");
            //    }

            //    if (num % 2 == 1)
            //    {
            //        Console.WriteLine("EL {0} es impar", num);
            //    }
            //    else
            //    {
            //        Console.WriteLine("USTED NO INGRESO NINGUN NUMERO IMPAR");
            //    }
            //}


            // Intento de diferentes formas de hacer el ejercicio.

            //int[] numeros = new int[rango];

            //for (int i = 0; i < rango  ; i++)
            //{
            //    Console.WriteLine("INGRESE UN CARACTER");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < rango; i++)
            //{
            //    if (numeros[i] %2 ==1)
            //    {
            //        Console.WriteLine(numeros[i]);
            //    }
            //}

            //Console.ReadKey();


            /*************************************************************************************/


            //2.Cree un programa que muestre los 15 primeros múlƟplos de 4.

            //int mult = 4;
            //int cant = 15;

            //for (int i = 1; i <= cant; i++)
            //{
            //    Console.WriteLine(mult * i);
            //}

            //Console.ReadKey();

            // Otra manera.

            //for (int i = 0; i <= 66; i++)
            //{
            //    if (i %4==0)
            //    {
            //        Console.WriteLine(i);
            //    }         
            //}

            //Console.ReadKey();


            /*************************************************************************************/


            //4.Cree un programa que solicite la base y la altura de un cuadrilátero y que lo dibuje con
            //asteriscos(*).

            //    int bas, alt;

            //    Console.WriteLine("ingrerse base del cuadrilatero");
            //    bas = int.Parse(Console.ReadLine());
            //    Console.WriteLine("ingrerse altura del cuadrilatero");
            //    alt = int.Parse(Console.ReadLine());

            //    for (int i = 1; i < bas ; i++)
            //    {
            //        //Console.WriteLine("*"); // se defasa.

            //        for (int x = 1; x < alt; x++)
            //        {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }

            //    Console.ReadKey();


            /*************************************************************************************/


            // 5.Cree un programa que permita al usuario ingresar su edad y le muestre todos los años
            // que ha vivido. 

            //int edad;
            //const int anoActual = 2024;

            //Console.WriteLine("Ingresa tu edad");
            //edad = int.Parse(Console.ReadLine());

            //int anoDeNacimiento = anoActual - edad;

            //for (int i = anoDeNacimiento; anoDeNacimiento <= anoActual; anoDeNacimiento++)
            //{
            //    Console.WriteLine(anoDeNacimiento);
            //}

            //Console.ReadKey();


            /*************************************************************************************/


            // 6.Cree un programa que le pida un número al usuario entre el 1 y el 5, y que lo compare
            // con un número aleatorio generado por el programa, también del 1 al 5, y si ambos
            // coinciden, mostrar un mensaje y terminar el programa.

            //Random random = new Random();// metodo random.
            //int numAleatorio = random.Next(1, 5);

            //Console.WriteLine("ingrese un numero entre 1 y 5");
            //int numUsuario = int.Parse(Console.ReadLine());

            //while (true)
            //{
            //    Console.Write("ingrese un número entre 1 y 5 ");
            //    string usuario = Console.ReadLine();
            
            //    numUsuario = int.Parse(usuario);
     
            //    if (numUsuario >= 1 && numUsuario <= 5)
            //    {
            //        break; //si el número es válido sale.
            //    }
            //    else
            //    {
            //        Console.WriteLine("numero entre 1 y 5.");
            //    }
            //}

            //if (numUsuario == numAleatorio)
            //{
            //    Console.WriteLine("coinciden");
            //}
            //else
            //{
            //    Console.WriteLine("no coinciden");
            //}

            //Console.WriteLine("terminar programa");
            //Console.ReadKey();
        }
    }
}
