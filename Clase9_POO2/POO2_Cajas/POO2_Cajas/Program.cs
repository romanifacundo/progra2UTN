using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2_Cajas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja(10, 20, 20);
            caja2.pMat = "madera";
            caja2.datosCaja();

            Console.ReadKey();
        }
    }
}
