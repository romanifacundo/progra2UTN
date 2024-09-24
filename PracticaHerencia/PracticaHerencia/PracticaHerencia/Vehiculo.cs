using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaHerencia
{
    internal class Vehiculo
    {
        private long P_Patente;
        private string P_Color;

        public Vehiculo(long pat, string col) 
        {
            this.Patente = pat;
            this.Color = col;
        }

        public long Patente
        {
            get
            {
                return this.P_Patente;
            }
            set
            {
                this.P_Patente = value;
            }
        }

        public string Color
        {
            get
            {
                return this.P_Color;
            }
            set
            {
                this.P_Color = value;
            }
        }
    }
}
