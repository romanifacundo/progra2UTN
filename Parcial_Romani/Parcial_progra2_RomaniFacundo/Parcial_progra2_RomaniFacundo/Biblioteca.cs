using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_progra2_RomaniFacundo
{
    internal class Biblioteca
    {
        //__Declaracion de listas privadas y relacion de ensamble con clase Libros__
        private List<Libro> libros_disponibles;
        private List<Libro> libros_no_disponibles;

        //__Propiedades privadas__
        private string _nombre;
        private string _direccion;

        //__Contructores__
        public Biblioteca()
        {
            this.Nombre = "";
            this.Direccion = "";
            this.libros_disponibles = new List<Libro>();
            this.libros_no_disponibles = new List<Libro>();
        }

        public Biblioteca(string nom, string direcci)
        {
            this.Nombre = nom;
            this.Direccion = direcci;
            this.libros_disponibles = new List<Libro>();
            this.libros_no_disponibles = new List<Libro>();
        }


        //__Metodos de propiedades publicas__
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Direccion
        {
            get { return this._direccion; }
            set { this._direccion = value; }
        }


        //__Metodos__
        public void LeerArchivoLibros()
        {
            FileStream Archivo = new FileStream("libros.txt", FileMode.Open);
            StreamReader Leer = new StreamReader(Archivo);

            bool dat1;
            bool dat2;

            while (!Leer.EndOfStream)
            {
                string cadena = Leer.ReadLine();
                string[] datos = cadena.Split(';');

                if (datos[4] == "si")
                {
                    dat1 = true;
                }
                else
                {
                    dat1 = false;
                }

                if (datos[5] == "si")
                {
                    dat2 = true;
                }
                else
                { 
                   dat2 = false;
                }

                Libro libro = new Libro(
                    datos[0],
                    datos[1],
                    datos[2],
                    int.Parse(datos[3]),
                    dat1,
                    dat2);

                if (dat2 == false)
                {
                    this.libros_no_disponibles.Add(libro);
                }
                
                if(dat2 == true) 
                {
                    this.libros_disponibles.Add(libro);
                }
            }

            Leer.Close();
            Archivo.Close();
        }

        public void GenerarReporte()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=============================");
            Console.WriteLine("Libros Disponibles");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            foreach (Libro item in this.libros_disponibles)
            {
                if (item.Disponibilidad == true)
                {
                    item.MostrarLibro();
                }
            }
        }

        public void GenerarReporteLibrosNoDisponibles()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            Console.WriteLine("=============================");
            Console.WriteLine("Libros no Disponibles");
            Console.WriteLine("=============================");
            Console.WriteLine("\n");
            foreach (Libro item in this.libros_no_disponibles)
            {
                if (item.Disponibilidad == false)
                {
                    item.MostrarLibro();
                }
            }
        }

    }
}
