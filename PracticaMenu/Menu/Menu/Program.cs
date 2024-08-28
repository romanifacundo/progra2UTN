using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Menu
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Array de Menu con opciones.
            string[] menuDeOpciones = { "CREAR", "AGREGAR", "LEER", "SALIR" };

            //Bool para corte de while.
            bool variableCorte = true;

            //Variable que guarda la opcion actual
            int seleccion = 0;

            //Toma la tecla ingresada.
            ConsoleKeyInfo tecla;

            Console.CursorVisible = false;

            while (variableCorte)
            {
                Console.Clear();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("╔════════════════════════════════╗");
                Console.WriteLine("  SELECCIONA UNA OPCION DEL MENU ");
                Console.WriteLine("╚════════════════════════════════╝");
                Console.ResetColor();
                Console.WriteLine("\n");

                Console.WriteLine("╔═══════════════╗");
                for (int i = 0; i < menuDeOpciones.Length; i++)
                {
                    if (seleccion == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("==" + (char)62 + " ");
                    }
                    else
                    {
                        Console.Write(" . ");
                    }

                    Console.WriteLine(menuDeOpciones[i]);
                    Console.ResetColor();
                }
                Console.WriteLine("╚═══════════════╝");

                tecla = Console.ReadKey();

                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        seleccion = Math.Max(0, seleccion - 1); //Primer valor 0 determina el limite, seleccion - 1 para manejar rango del arrays  
                        break;

                    case ConsoleKey.DownArrow:
                        seleccion = Math.Min(menuDeOpciones.Length - 1, seleccion + 1); //Largo de mi menu -1 para el rango.
                        break;

                    case ConsoleKey.Enter:
                    case ConsoleKey.Spacebar:

                        if (seleccion == menuDeOpciones.Length - 1)
                        {
                            variableCorte = false;
                        }

                        break;
                }
            }

            Console.ReadKey();

        }

        static void Clientes()
        {
            string[] clientes = { "JULIA", "CRISTIAN", "TOMAS" };

            for (int i = 0; i < clientes.Length; i++)
            {
                Console.WriteLine(clientes[i]);
            }
        }
    }
}
