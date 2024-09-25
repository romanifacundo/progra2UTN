using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> _ListaAutos = new List<Auto>();
            int opc;
            string confirmar;

            do
            {
                Menu();
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: 

                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("================");
                            Console.WriteLine("Ingresa numero de patente");
                            long Patente = long.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa Color");
                            string Color = Console.ReadLine();
                            Console.WriteLine("Ingresa Nombre");
                            string Nombre = Console.ReadLine();
                            Console.WriteLine("================");
       
                            Auto auto = new Auto(Patente, Color, Nombre);
                            _ListaAutos.Add(auto);

                            Console.WriteLine("QUIERES SEGUIR CARGANDO AUTOS ingresa S/N  S(SI) N(NO)");
                            confirmar = Console.ReadLine().ToLower();

                        } while (confirmar == "s");
                        
                        break;
                    
                    case 2:

                        Console.Clear();
                        Console.WriteLine("================");
                        Console.WriteLine("Listado de vehículos:");
                        
                        foreach (Auto i in _ListaAutos)
                        {
                            Console.WriteLine($"Patente: {i.Patente} - Color: {i.Color} - Nombre: {i.Nombre}");
                        }

                        Console.WriteLine("================");
                        Console.ReadKey();

                        break;

                    default:

                        if (opc != 0)
                        {
                            Console.WriteLine("Opción inválida");
                        }

                        break;
                }
            } while (opc != 0);

            Console.ReadKey();
        }


        static void Menu()
        {
            string[] menu = { "1) Agregar vehiculo", "2) Listar vehiculo" };

            Console.WriteLine("================");
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("================");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
        }
    }
}
