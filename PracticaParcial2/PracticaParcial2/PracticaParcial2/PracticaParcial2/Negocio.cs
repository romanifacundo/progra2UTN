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
            int contLibreria = 0;
            float sumaPrecioLib = 0;
            int contFerreteria = 0;
            float acumFerreteria = 0;
            int contElectronica = 0;
            float acumElectronica = 0;
            int contKiosco = 0;
            float acumKiosco = 0;

            foreach (Producto item in this._listaProductos)
            {
                item.MostrarDatosProducto();
                totalProductos = this._listaProductos.Count;
                acumPrecio += item.Precio;

                if (item.Rubro == "libreria")
                {
                    contLibreria++;
                    sumaPrecioLib += item.Precio;
                }
                if (item.Rubro == "ferreteria")
                {
                    contFerreteria++;
                    acumFerreteria += item.Precio;
                }
                if (item.Rubro == "electronica")
                {
                    contElectronica++;
                    acumElectronica += item.Precio;
                }
                if (item.Rubro == "kiosco")
                {
                    contKiosco++;
                    acumKiosco += item.Precio;
                }
            }

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Resumen solicitado:");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n");
            Console.WriteLine(" La cantidad de los articulos es: " + totalProductos);
            Console.WriteLine("\n");
            Console.WriteLine(" El promedio de precios de libreria es: " + sumaPrecioLib / contLibreria);
            Console.WriteLine(" La cantidad de atriculos en libreria es: " + contLibreria);
            Console.WriteLine("\n");
            Console.WriteLine(" El promedio de precios de ferreteria es: " + acumFerreteria / contFerreteria);
            Console.WriteLine(" La cantidad de atriculos en ferreteria es: " + contFerreteria);
            Console.WriteLine("\n");
            Console.WriteLine(" El promedio de precios de electronica es: " + acumElectronica / contElectronica);
            Console.WriteLine(" La cantidad de atriculos en electronica es: " + contElectronica);
            Console.WriteLine("\n");
            Console.WriteLine(" El promedio de precios de kiosco es: " + acumKiosco / contKiosco);
            Console.WriteLine(" La cantidad de atriculos en Kiosco es: " + contKiosco);

        }

    }
}
