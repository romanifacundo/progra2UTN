using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    internal class Auto : Vehiculo
    {
        private string P_Nombre;

        public Auto(string nom) 
        {
            this.Nombre = nom;
        }

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
    }
}
