using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Una empresa desea tener una aplicación en donde se pueda cargar y 
            // consultar los datos de sus empleados. Debe tener un menu con 3 opciones: 
            // cargar datos, leer datos y salir.Para la carga de datos se debe solicitar al usuario el dni, apellido, nombre y sueldo del empleado.
            // Los datos se deben guardar en un archivo de texto. 
            // Al leer los datos se de cada empleado se debe mostrar una linea 
            // por empleado: DNI XXXXXXXXXX -Apellido XXXXXXXXXX - Nombre - XXXXXXXXXX - Sueldo XXXXXXXXX.

            FileStream Archivo;
            StreamWriter StreamGrabar;
            StreamReader StreamLeer;

            //string DNI;
            //string apellido;
            //string nombre;
            //double sueldo;
            string cad;

            Char Opcion;

            Menu();
            Opcion = Console.ReadKey().KeyChar;

            switch (Opcion)
            {
                case '1':

                    Console.WriteLine("\n");
                  
                    Archivo = new FileStream("Lista.txt", FileMode.Append);
                    StreamGrabar = new StreamWriter(Archivo);
                    StreamGrabar.WriteLine(PedirDatos2());

                    StreamGrabar.Close();
                    Archivo.Close();

                break;

                case '2':

                    if (File.Exists("Lista.txt"))
                    {
                        Console.Clear();
                        Console.WriteLine("Lista de empleados \n");
                        Archivo = new FileStream("Lista.txt", FileMode.Open);
                        StreamLeer = new StreamReader(Archivo);

                        while (StreamLeer.EndOfStream == false)
                        {
                            cad = StreamLeer.ReadLine();
                            Console.WriteLine(cad);
                        }

                        StreamLeer.Close();
                        Archivo.Close();
                    }
                    else
                    {
                        Console.WriteLine("No Existe el Archivo");
                    }

                break;

                case '3':
                    Console.Clear();
                    Console.WriteLine("Salio del Sistema");
                break;
            }

            Console.ReadKey();
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1) - Cargar Datos | 2) - Leer Datos | 3) - Salir ");
        }

        static void PedirDatos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ingresa DNI - Ingresa Apellido - Ingresa Nombre - Ingresa Sueldo");
        }

        static string PedirDatos2()
        {
            string DNI;
            string apellido;
            string nombre;
            double sueldo;
            string cad;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Ingresa DNI - Ingresa Apellido - Ingresa Nombre - Ingresa Sueldo");
            Console.WriteLine("Ingresa DNI");
            DNI = Console.ReadLine();
            Console.WriteLine("Ingresa Apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingresa Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa Sueldo");
            sueldo = Double.Parse(Console.ReadLine());

            cad = $"DNI: {DNI} - Apellido: {apellido} - Nombre: {nombre} - Sueldo: {sueldo}";

            return cad;
        }

    }
}

