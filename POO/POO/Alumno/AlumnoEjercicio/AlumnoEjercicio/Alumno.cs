using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoEjercicio
{
    internal class Alumno
    {
        // Propiedades privadas.
        private int edad;
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private string genero;

        // Constructor.
        public Alumno(int edad, string nombre, string apellido, DateTime fechaNacimiento, string genero) 
        {
            this.edad = edad;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechaNacimiento;
            this.Genero = genero;   
        }

        // Metodo
        public void MostrarDatos() 
        {
            Console.WriteLine("Edad: {0}, Nombre: {1}, Apellido {2}, Fecha de Nacimiento {3}, Genero {4}", this.Edad, this.Nombre, this.Apellido, this.FechaNacimiento, this.Genero);
        }

        // Propiedades publicas
        public int Edad 
        {
            get 
            {
                return this.edad; 
            }
        }

        public string Nombre 
        {
            get 
            {
                return this.nombre; 
            }
            set 
            {
                this.nombre = value;
            }
        }

        public string Apellido
        { 
            get 
            { 
                return this.apellido; 
            }
            set 
            { 
                this.apellido = value;
            }
        }
        
       public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
            set 
            {
                this.fechaNacimiento = value;            
            }

            
        }
        public string Genero
        {
            get
            {
                return this.genero; 
            }
            set 
            {
                this.genero = value; 
            }
        }
    }
}
