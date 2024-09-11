using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Negocio
    {
        //__Propiedades privadas - Lista de ensamble__
        private List<Producto> _listaProductos;

        //__Constructor__
        public Negocio()
        {
            this._listaProductos = new List<Producto>();
        }

        //__Metodos__
        public void LeerArchivo(string archivoProducto)
        {
            FileStream Archivo = new FileStream(archivoProducto, FileMode.Open);
            StreamReader Leer = new StreamReader(Archivo);

            while (!Leer.EndOfStream)
            {
                string cadena = Leer.ReadLine();
                string[] datos = cadena.Split(';');
                Producto prod = new Producto(
                    int.Parse(datos[0]),
                    datos[1],
                    datos[2],
                    int.Parse(datos[3]),
                    int.Parse(datos[4]));

                this._listaProductos.Add(prod);
            }

            Leer.Close();
            Archivo.Close();
        }

        public void ReporteProductos()
        {
            int totalProductos = 0;
            float acumPrecio = 0;
            float totalPromedio = 0;
            int cantlib = 0;
            int cantFerr = 0;
            int cantElec = 0;
            int cantKios = 0;

            foreach (Producto item in this._listaProductos)
            {
                item.MostrarDatosProducto();
                totalProductos = this._listaProductos.Count;
                acumPrecio += item.CalcularPrecio();

                if (item.Rubro == "libreria")
                {
                    cantlib++;
                }
                else if (item.Rubro == "ferreteria")
                {
                    cantFerr++;
                }
                else if (item.Rubro == "electronica")
                {
                    cantElec++; 
                }
                else if (item.Rubro == "kiosco")
                {
                    cantKios++; 
                }
            }

            totalPromedio = acumPrecio / totalProductos;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n");
            Console.WriteLine("total productos " + totalProductos);
            Console.WriteLine("\n");
            Console.WriteLine("Promedio del precio de cada producto " + totalPromedio);
            Console.WriteLine("\n");
            Console.WriteLine("TOTAL LIBRERIA: " + cantlib);
            Console.WriteLine("TOTAL FERRETERIA: " + cantFerr);
            Console.WriteLine("TOTAL ELECTRONICA: " + cantElec);
            Console.WriteLine("TOTAL KIOSCO: " + cantKios);
        }

    }
}
