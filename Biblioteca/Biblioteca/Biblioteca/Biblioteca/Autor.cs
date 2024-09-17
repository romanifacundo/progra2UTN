using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Autor
    {
        //__Propiedades Privadas__
        private int _idAutor;
        private string _nombre;
        private string _apellido;

        //__Constructores__
        public Autor(int idAut, string nom, string apell) 
        {
            this.IDAutor = idAut;
            this.Nombre = nom;
            this.Apellido = apell;
        }

        //__Metodo de propiedades publicas__
        public int IDAutor 
        {
            get { return this._idAutor; }
            set { this._idAutor = value;}
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
    }
}
