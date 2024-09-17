using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.LeerArchivo();
            biblioteca.MostrarTodosLosLibros();
            biblioteca.ReporteLibrosPrestados();
            biblioteca.BusquedaDeUnLibro();
            biblioteca.BusquedaDeLibriosPorAutor();
            Console.ReadKey();
        }
    }
}
