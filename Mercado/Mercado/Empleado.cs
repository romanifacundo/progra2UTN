using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Empleado
    {
        //___Propiedades privadas___
        private long _dni;
        private string _apellido;
        private string _nombre; 
        private float _sueldo;


        //___Constructores___
        public Empleado()
        {
            this.DNI = 0;
            this.Apellido = "";
            this.Nombre = "";
            this.Sueldo = 0;
        }
        public Empleado(long dni, string apellido , string nombre, float sueldo) 
        {
            this.DNI = dni;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Sueldo = sueldo;
        }


        //___Propiedades publicas___
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

        public float Sueldo
        {
            get
            {
                return this._sueldo;
            }
            set
            {
                this._sueldo = value;
            }
        }

        public long DNI
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }


        //___Metodos___
        public void MostrarDatosEmpleado() 
        {
            Console.WriteLine($"DNI: {this.DNI} , Apellido: {this.Apellido}, Nombre: {this.Nombre}, Sueldo: {this.Sueldo}");
        }
    }
}
