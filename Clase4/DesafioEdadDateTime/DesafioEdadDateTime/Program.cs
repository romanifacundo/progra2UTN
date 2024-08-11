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

            DateTime fechaDeNacimiento;
            string cadena;

            //diaDeNacimiento = DateTime.Parse(Console.ReadLine()).Day;
            //mesDeNacimiento = DateTime.Parse(Console.ReadLine()).Month;

            Console.WriteLine("Ingresa tu fecha de nacimiento (formato: dd/mm/yyyy):");
            cadena = Console.ReadLine();

            while (!DateTime.TryParse(cadena, out fechaDeNacimiento))
            {
                Console.WriteLine("Fecha no válida. Por favor, ingresa tu fecha de nacimiento en el formato dd/mm/yyyy:");
                cadena = Console.ReadLine();
            }
            Console.WriteLine("Tu edad es: " + calcularEdad(fechaDeNacimiento));

            Console.ReadKey();

        }

        static int calcularEdad(DateTime fechaDeNacimiento)
        {
            int edad = DateTime.Now.Year - fechaDeNacimiento.Year;

            if (DateTime.Now < fechaDeNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;  
        }
    }
}
