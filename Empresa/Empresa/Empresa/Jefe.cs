using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Jefe : Empleado
    {
        //__Contructores__
        public Jefe(string nom, string ape, DateTime fechaNac) : base(nom, ape, fechaNac) //__Base le pasamos parametros al cosntructor padre__
        {

        }

        public void ContratarEmpleado()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_____________________________________________________________________________");
            Console.WriteLine($"Contratar al empleado Nombre: {this.Nombre}  Apellido: {this.Apellido} Edad: {this.Edad}");
            Console.WriteLine("_____________________________________________________________________________");
        }

    }
}
