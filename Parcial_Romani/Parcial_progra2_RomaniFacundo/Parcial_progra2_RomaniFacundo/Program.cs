using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_progra2_RomaniFacundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //__Instacia de objeto__
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.LeerArchivoLibros();
            biblioteca.GenerarReporte();
            biblioteca.GenerarReporteLibrosNoDisponibles();

             Console.ReadLine();
        }
    }
}
