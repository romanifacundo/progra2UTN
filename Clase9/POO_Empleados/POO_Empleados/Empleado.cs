using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Empleados
{
    internal class Empleado
    {
        private int dni;
        private string nombre;
        private string apellido;
        private float sueldo;

        public Empleado(int dni, string nombre, string apellido, float sueldo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
        }

        public int DNI
        {
            get { return this.dni; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public float Sueldo
        {
            get { return this.sueldo; }
        }
    }
}
