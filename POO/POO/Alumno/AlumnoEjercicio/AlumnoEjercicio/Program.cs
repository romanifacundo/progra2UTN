using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoEjercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno(30,"Facu","Romani", DateTime.Parse("05/07/1990"),"Masculino"); 
            alumno1.MostrarDatos();

            Console.ReadKey();
        }        
    }
}
