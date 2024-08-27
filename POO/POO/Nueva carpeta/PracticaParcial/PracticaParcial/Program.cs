using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //===============Clases y variables===============.
            FileStream Archivo;
            StreamWriter Grabar;
            StreamReader Leer;
            string cadena, nombre, apellido,cadenaValidar;
            int edad;

            //===============Pedido de datos===============
            Console.WriteLine("Ingresa tu Nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu Edad");
            cadenaValidar = Console.ReadLine();

            //===============Validacion.===============
            while (!int.TryParse(cadenaValidar, out edad)) 
            {
                Console.WriteLine("Debes ingresar un numero entero");
                cadenaValidar = Console.ReadLine();
            }

            cadena = $"{nombre}, {apellido} , {edad}";

            //===============Manejo de archivo apertura para crear===============
            Archivo = new FileStream("persona.txt" , FileMode.Append);
            Grabar = new StreamWriter(Archivo);

            Grabar.WriteLine(cadena);

            //===============Manejo de archivo cierre===============
            Grabar.Close();
            Archivo.Close();

            //===============Manejo de archivo apertura para leer===============
            Archivo = new FileStream("persona.txt", FileMode.Open);
            Leer = new StreamReader(Archivo);

            if (!File.Exists("persona.text")) 
            {
                while (!Leer.EndOfStream)//Lectura de linea por linea (true) sale del while.
                {
                    cadena = Leer.ReadLine();
                    string[] subCadenas = cadena.Split(',');
                    Console.WriteLine($"Nombre: {subCadenas[0]}, Apellido: {subCadenas[1]}, Edad: {subCadenas[2]}"); //Fragmenta en subCadenas.
                }
            }

            //===============Manejo de archivo cierre===============
            Leer.Close();
            Archivo.Close();

            Console.ReadKey();
        }
    }
}
