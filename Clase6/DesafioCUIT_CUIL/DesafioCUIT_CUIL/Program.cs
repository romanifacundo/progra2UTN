﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCUIT_CUIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresa tu dni, luego ingresa si es
            //empresa 30
            //hombre 20
            //mujer 27
            //por ultimo devolver el CUIT/CUIL.

            int DNI;
            const int empresa = 30;
            const int hombre = 20;
            const int mujer = 27;

            Console.WriteLine("**************");
            Console.WriteLine("Ingresa tu DNI");
            Console.WriteLine("**************"); ;
            DNI = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("***********************"); ;
            Console.WriteLine("Ingresa tus IDENTIDAD");
            Console.WriteLine("1) Empresa");
            Console.WriteLine("2) Hombre");
            Console.WriteLine("3) Mujer");
            Console.WriteLine("***********************");

            int opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***********************"); ;
                    Console.WriteLine($"CUIT: {empresa}-{DNI}-" + Calculo(DNI));
                    Console.WriteLine("***********************");
                    break;

                case 2:
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***********************");
                    Console.WriteLine($"CUIL: {hombre}-{DNI}-" + Calculo(DNI));
                    Console.WriteLine("***********************");
                    break;

                case 3:
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("***********************");
                    Console.WriteLine($"CUIL: {mujer}-{DNI}-" + Calculo(DNI));
                    Console.WriteLine("***********************");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }

        static int Calculo(int DNI)
        {
            int[] vectorCalculo = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int acum = 0;
            int total = 0;
            int z, resultado, resultadoFinal;

            for (int i = 0; i < vectorCalculo.Length; i++)
            {
                total = DNI * vectorCalculo[i];
                acum += total;
            }

            z = total / 11;

            resultado = total - (z * 11);

            resultadoFinal = 11 - resultado;

            return resultadoFinal;
        }

    }
}

