using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoEjercicio
{
    internal class Alumno
    {
        //Propiedades privadas.
        private int _edad;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNac;
        private string _genero;


        //Constructores.
        public Alumno()
        {
            this._edad = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.FechaNac = DateTime.MinValue;
            this.Genero = "";
        }

        public Alumno(string nombre, string apellido, DateTime fechaNac, string genero) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNac = fechaNac;
            this.Genero = genero;   
        }


        //Propiedades publicas.
        public int Edad 
        {
            get 
            {
                return DateTime.Now.Year - this._fechaNac.Year; 
            }
        }

        public string Nombre 
        {
            get 
            {
                return this._nombre; 
            }
            set 
            {
                this._nombre = value;
            }
        }

        public string Apellido
        { 
            get 
            { 
                return this._apellido; 
            }
            set 
            { 
                this._apellido = value;
            }
        }
        
       public DateTime FechaNac
        {
            get
            {
                return this._fechaNac;
            }
            set 
            {
                this._fechaNac = value;            
            }    
        }

        public string Genero
        {
            get
            {
                return this._genero; 
            }
            set 
            {
                this._genero = value; 
            }
        }


        //Metodos.
        public void MostrarDatos()
        {
            Console.WriteLine("Edad: {0}, Nombre: {1}, Apellido {2}, Fecha de Nacimiento {3}, Genero {4}", this.Edad, this.Nombre, this.Apellido, this.FechaNac, this.Genero);
        }
    }
}
