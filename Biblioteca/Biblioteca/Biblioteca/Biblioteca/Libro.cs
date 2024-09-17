using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro
    {
        //__Propiedades Privadas__
        private int _idLibro;
        private string _titulo;
        private int _idGenero;
        private int _idAutor;
        private int _anio;
        private string _ubicacion;
        private char _estado;

        //__Constructores__
        public Libro(int idLib,string titu,int gen,int idAut, int anio, string ubi,char esta) 
        {
            this.IDLibro = idLib;
            this.Titulo = titu;
            this.IdGenero = gen;
            this.IdAutor = idAut;
            this.Anio = anio;
            this.Ubicacion = ubi;
            this.Estado = esta;
        }

        //__Metodo de propiedades publicas__
        public int IDLibro 
        {
            get { return this._idLibro; }
            set { this._idLibro = value;}
        }

        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public int IdGenero
        {
            get { return this._idGenero; }
            set { this._idGenero = value; }
        }

        public int IdAutor
        {
            get { return this._idAutor; }
            set { this._idAutor = value; }
        }

        public int Anio
        {
            get { return this._anio; }
            set { this._anio = value; }
        }

        public string Ubicacion
        {
            get { return this._ubicacion; }
            set { this._ubicacion = value; }
        }

        public char Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }

        //__Metodos__
        public void CambioDeEstado() 
        {

        }

        public void MostrarLibro() 
        {
            Console.WriteLine($"IdLibro: {this.IDLibro},Titulo: {this.Titulo},IdGenero: {this.IdGenero},IdAutor {this.IdAutor},Anio: {this.Anio}, Ubicacion: {this.Ubicacion}, Estado: {this.Estado}");
        }
    }
}
