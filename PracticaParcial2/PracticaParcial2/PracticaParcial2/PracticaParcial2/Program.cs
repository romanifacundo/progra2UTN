using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _archProduc = "productos.txt";

            Negocio negocio = new Negocio();
            negocio.LeerArchivo(_archProduc);
            negocio.ReporteProductos();

            Console.ReadKey();        
        }
    }
}
