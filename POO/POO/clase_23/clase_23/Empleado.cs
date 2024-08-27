using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_23
{
    internal class Empleado
    {
        // Propiedades privadas.
        private long dni;
        private string nombre;
        private string apellido;
        private float sueldo;


        // Constructores.
        public Empleado()
        {
            this.DNI = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Sueldo = 0;
        }
            
        
        public Empleado(long dni, string nombre, string apellido, float sueldo)
        {
            this.DNI = dni;
            this.Nombre = nombre;   
            this.Apellido = apellido; 
            this.Sueldo = sueldo;
        }

        // Metodos.
        public void MostrarDatos()
        {
            Console.WriteLine("DNI: {0} - Nombre: {1} - Apellido {2} - Sueldo: {3} ", this.DNI, this.Nombre,this.Apellido,this.Sueldo);
        }

        // Propiedades publicas.
        public long DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
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

        public float Sueldo
        {
            get
            {
                return this.sueldo;
                
            }
            set 
            {
                this.sueldo = value; 
            }
        }
    }
}
