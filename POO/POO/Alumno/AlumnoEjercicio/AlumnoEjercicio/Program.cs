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
            //Objetos Alumnos.
            Alumno alumno1 = new Alumno("Facu","Romani", DateTime.Parse("05/07/1990"),"Masculino");
            Alumno alumno2 = new Alumno("Jorge", "Sager", DateTime.Parse("05/07/2000"), "Masculino");
            Alumno alumno3 = new Alumno("Naldo", "Velazquez", DateTime.Parse("05/07/2000"), "Masculino");
            Alumno alumno4 = new Alumno("Daiana", "Godoy", DateTime.Parse("05/07/2000"), "Femenino");
            Alumno alumno5 = new Alumno("Agus", "Kern", DateTime.Parse("05/07/2000"), "Masculino");
            Alumno alumno6 = new Alumno("Ale", "Ruggiero", DateTime.Parse("05/07/2000"), "Masculino");

            //Objeto Aula contructor cargado.
            Aula aula1 = new Aula("Laboratorio 2");
            Console.WriteLine(":::::::::::::::::");
            Console.WriteLine(aula1.NombreAula);
            Console.WriteLine(":::::::::::::::::");
            aula1.AgregarAlumno(alumno1);
            aula1.AgregarAlumno(alumno2);
            aula1.AgregarAlumno(alumno3);
            aula1.AgregarAlumno(alumno4);
            aula1.AgregarAlumno(alumno5);
            aula1.AgregarAlumno(alumno6);

            aula1.ListarAlumnos();

            Console.ReadKey();
        }        
    }
}
