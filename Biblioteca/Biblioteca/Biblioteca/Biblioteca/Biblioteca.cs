using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Biblioteca
    {
        private List<Libro> _libros;

        public Biblioteca() 
        {
            this._libros = new List<Libro>();
        }

        //__Metodos__
        public void LeerArchivo() 
        {
            FileStream Archivo = new FileStream("libros.txt", FileMode.Open);
            StreamReader Leer = new StreamReader(Archivo);

            while (!Leer.EndOfStream)
            {
                string cadena = Leer.ReadLine();
                string[] datos = cadena.Split(';');
                Libro lib = new Libro(
                    int.Parse(datos[0]),
                    datos[1],
                    int.Parse(datos[2]),
                    int.Parse(datos[3]),
                    int.Parse(datos[4]),
                    datos[5],
                    char.Parse(datos[6]));

                this._libros.Add(lib);
            }

            Leer.Close();
            Archivo.Close();
        }

        public void MostrarTodosLosLibros() 
        {
            foreach (Libro item in this._libros)
            {
                item.MostrarLibro();
            }
        }

        public void ReporteLibrosPrestados()
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************************");
            Console.WriteLine("Reporte de libros prestados");

            foreach (Libro item in this._libros)
            {             
                if (item.Estado == 'P')
                {
                      
                    item.MostrarLibro();
                }              
            }
            Console.WriteLine("****************************");
        }

        public void BusquedaDeUnLibro() 
        {
            Console.WriteLine("Ingresa el ID para buscar el libro");
            int idIngresado =int.Parse(Console.ReadLine());

            foreach (Libro item in this._libros) 
            {
                if (idIngresado == item.IDLibro) 
                {
                    Console.WriteLine($"{item.Titulo}");
                }
            }
        }

        public void BusquedaDeLibriosPorAutor()
        {
            Console.WriteLine("Ingresa titulo del libro");
            string titulo = Console.ReadLine();

            foreach (Libro item in this._libros)
            {
                if (titulo == item.Titulo)
                {
                    Console.WriteLine($"{item.Titulo}");
                }
            }
        }

        public void BusquedaDeLibriosPorGenero()
        {
            Console.WriteLine("Ingresa genero del libro");
            string genero = Console.ReadLine();

            foreach (Libro item in this._libros)
            {
                if (genero == item.IdGenero)
                {
                    Console.WriteLine($"{item.Titulo}");
                }
            }
        }
    }
}
