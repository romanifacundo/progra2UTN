using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado(9999999, "jose","luz",11.0f);
            empleado.CrearArchivo();

            //foreach (Empleado empleado in empleados)
            //{
            //    cadena = $"{empleado.DNI},{empleado.Nombre},{empleado.Apellido},{empleado.Sueldo}";

            //    StreamGrabar.WriteLine(cadena);

            //    string[] parte = cadena.Split(',');

            //    Console.WriteLine($"DNI: {parte[0]}, Nombre: {parte[1]}, Apellido: {parte[2]}, Sueldo: {parte[3]}");
            //}

            Console.ReadKey();
        }
    }
}

