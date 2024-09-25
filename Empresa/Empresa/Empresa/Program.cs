using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaNac = new DateTime(1990, 07, 05);//__Manipular DateTime__

            Jefe jefe = new Jefe("Facundo", "Romani", fechaNac);
            jefe.ContratarEmpleado();

            Supervisor sup1 = new Supervisor("Facundo", "Romani" , fechaNac);
            sup1.MandarEmpleado();

            Console.ReadKey();
        }
    }
}
