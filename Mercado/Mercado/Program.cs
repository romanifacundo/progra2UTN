﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            string _acrhEmp = "empleados.txt";
            string _acrhArt = "articulos.txt";
            int opcion;

            Mercado mercado = new Mercado("em", "em");
            
            Menu();
            Console.WriteLine("Debes elegir una opcion del MENU");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    mercado.CargarEmpleados(_acrhEmp);
                    mercado.EmpleadosContratados();
                    break;
                case 2:
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    mercado.CargarArticulos(_acrhArt);
                    mercado.ArticulosRegistrados();
                    break;
                default: 
                    break;
            }

            Console.ReadKey();
        }

        static void Menu() 
        {
            string[] menu = { "1)Reporte de empleados", "2)Reporte de artículos" };

            Console.WriteLine("_______________________________");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.WriteLine("_______________________________");
        }
    }
}
