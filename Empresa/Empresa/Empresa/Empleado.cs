using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    internal class Empleado
    {
        //__Propiedades privadas__
        private string P_Nombre;
        private string P_Apellido;
        private DateTime P_FechaNacimiento;

        //__Contructores__
        public Empleado(string nom, string ape, DateTime fechaNac)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.FechaNacimiento = fechaNac; 
        }

        //__Metodos de propiedades publicas__
        public string Nombre
        {
            get 
            { 
                return this.P_Nombre;
            }
            set 
            { 
                this.P_Nombre = value; 
            }
        }

        public string Apellido
        {
            get 
            { 
                return this.P_Apellido; 
            }
            set 
            { 
                this.P_Apellido = value; 
            }
        }

        public DateTime FechaNacimiento
        {
            get 
            { 
                return this.P_FechaNacimiento; 
            }
            set 
            { 
                this.P_FechaNacimiento = value; 
            }
        }

        public int Edad
        {
            get 
            { 
                return DateTime.Now.Year - this.FechaNacimiento.Year; 
            }      
        }

    }
}
