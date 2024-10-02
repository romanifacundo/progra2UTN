using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Supervisor : Jefe
    {
        //__Contructores__
        public Supervisor(string nom, string ape, DateTime fechaNac) : base(nom, ape, fechaNac) //__Base le pasamos parametros al cosntructor padre__
        {

        }

        public void MandarEmpleado()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Le damos orden de ejecucion en su trabajo al empleado: {Nombre} {Apellido}");
            Console.WriteLine("_____________________________________________________________________________");
        }
    }
}
