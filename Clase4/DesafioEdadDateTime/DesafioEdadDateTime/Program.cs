using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEdadDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Desafio usando DateTime debemos desarrollar un metodo que realice la logica del calculo de la edad de una persona
            // el usuario debe ingresar su fecha de nacimiento.

            int fechaDeNacimiento , diaDeNacimiento, mesDeNacimiento;

            Console.WriteLine("Ingresa tu fecha de nacimiento");
            fechaDeNacimiento = DateTime.Parse(Console.ReadLine()).Year;
            diaDeNacimiento = DateTime.Parse(Console.ReadLine()).Day;
            mesDeNacimiento = DateTime.Parse(Console.ReadLine()).Month;

            Console.WriteLine(calcularEdad(fechaDeNacimiento));

            Console.ReadKey();

        }

        static int calcularEdad(int fechaDeNacimiento) 
        {
            int edad;
            int anoActual = DateTime.Now.Year; 

            edad = anoActual - fechaDeNacimiento;

            return edad;
        }
    }
}
