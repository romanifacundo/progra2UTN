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
        //__Listas privadas relacion de ensamble a clases LIBRO-GENERO-AUTOR.
        private List<Libro> _libros;
        private List<Genero> _generos;
        private List<Autor> _autores;

        //__Constructores__
        public Biblioteca()
        {
            this._libros = new List<Libro>();
            this._generos = new List<Genero>();
            this._autores = new List<Autor>();
        }

        //__Metodos__
        public void LeerArchivoLibros()
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

        public void LeerArchivoAutores() 
        {
            FileStream Archivo3 = new FileStream("autores.txt", FileMode.Open);
            StreamReader Leer3 = new StreamReader(Archivo3);

            while (!Leer3.EndOfStream)
            {
                string cadena = Leer3.ReadLine();
                string[] datos = cadena.Split(';');
                Autor aut = new Autor(
                    int.Parse(datos[0]),
                    datos[1],
                    datos[2]);

                this._autores.Add(aut);
            }

            Leer3.Close();
            Archivo3.Close();
        }

        public void LeerArchivoGenero() 
        {
            FileStream Archivo2 = new FileStream("generos.txt", FileMode.Open);
            StreamReader Leer2 = new StreamReader(Archivo2);

            while (!Leer2.EndOfStream)
            {
                string cadena = Leer2.ReadLine();
                string[] datos = cadena.Split(';');
                Genero gen = new Genero(
                    int.Parse(datos[0]),
                    datos[1]);

                this._generos.Add(gen);
            }

            Leer2.Close();
            Archivo2.Close();
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
            int idIngresado = int.Parse(Console.ReadLine());

            foreach (Libro item in this._libros)
            {
                if (idIngresado == item.IDLibro)
                {
                    Console.WriteLine($"TITULO: {item.Titulo} , ESTADO: {item.Estado} , UBICACION: {item.Ubicacion}");
                }
            }
        }

        public void BusquedaDeLibriosPorAutor()
        {
            LeerArchivoAutores();
            LeerArchivoGenero();

            Console.WriteLine("Ingresa el ID Autor de libro para buscar");
            string IdAutor = Console.ReadLine();

            foreach (Autor item in this._autores)
            {
                if (IdAutor == item.Nombre)
                {
                    foreach (Libro item2 in this._libros)
                    {
                        if (item.IDAutor == item2.IDAutor)
                        {
                            foreach (Genero item3 in this._generos)
                            {
                                if (item3.IdGenero == item2.IdGenero) 
                                {
                                    Console.WriteLine($"{item2.Titulo}, {item3.Gener}, {item.Nombre}, {item2.Estado}, {item2.Ubicacion}");
                                }                             
                            }
                        }
                    }
                }
            }
        }

        //public void BusquedaDeLibriosPorGenero()
        //{

        //    FileStream Archivo = new FileStream("generos.txt", FileMode.Open);
        //    StreamReader Leer = new StreamReader(Archivo);

        //    while (!Leer.EndOfStream)
        //    {
        //        string cadena = Leer.ReadLine();
        //        string[] datos = cadena.Split(';');
        //        Genero gen = new Genero(
        //            int.Parse(datos[0]),
        //            datos[1]);

        //        this._generos.Add(gen);
        //    }

        //    Leer.Close();
        //    Archivo.Close();
        //}
    }
}


