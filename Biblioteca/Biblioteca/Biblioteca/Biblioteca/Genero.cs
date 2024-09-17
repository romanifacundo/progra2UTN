using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Genero
    {
        //__Propiedades Privadas__
        private int _idGenero;
        private string _gener;

        //__Constructores__
        public Genero(int idGen, string gen) 
        {
            this.IdGenero = idGen;
            this.Gener = gen;
        }

        //__Metodo de propiedades publicas__
        public int IdGenero 
        {
            get { return this._idGenero; }
            set { this._idGenero = value;}
        }
        public string Gener
        {
            get { return this._gener; }
            set { this._gener = value; }
        }
    }
}
