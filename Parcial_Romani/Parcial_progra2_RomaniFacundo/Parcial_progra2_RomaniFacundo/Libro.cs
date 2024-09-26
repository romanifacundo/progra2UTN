using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_progra2_RomaniFacundo
{
    internal class Libro
    {
        //__Propiedades privadas__
        private string _titulo;
        private string _autor;
        private string _genero;
        private int _precio;
        private bool _tapaDura;
        private bool _disponibilidad;

        //__Contructores__
        public Libro()
        {
            this.Titulo = "";
            this.Autor = "";
            this.Genero = "";
            this.Precio = 0;
            this.TapaDura = true;
            this.Disponibilidad = false;
        }
        public Libro(string tit, string aut, string gen, int pre, bool td, bool dis)
        {
            this.Titulo = tit;
            this.Autor = aut;
            this.Genero = gen;
            this.Precio = pre;
            this.TapaDura = td;
            this.Disponibilidad = dis;
        }

        //__Metodos de propiedades publicas__
        public string Titulo
        {
            get { return this._titulo; }
            set { this._titulo = value; }
        }

        public string Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }

        public string Genero
        {
            get { return this._genero; }
            set { this._genero = value; }
        }

        public int Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }

        public bool TapaDura
        {
            get { return this._tapaDura; }
            set { this._tapaDura = value; }
        }

        public bool Disponibilidad
        {
            get { return this._disponibilidad; }
            set { this._disponibilidad = value; }
        }

        public float PrecioFinal
        {
            get
            {
                if (TapaDura)
                {
                    float preFinal = this._precio;
                    preFinal += this._precio * 0.10f;
                    return preFinal;
                }
                else
                {
                    return this.Precio;
                }
            }
        }

        //__Metodos__

        public void MostrarLibro()
        {
            Console.WriteLine($"Título: {this.Titulo} – Autor: {this.Autor} – Género: {this.Genero} – Precio: {this.Precio} - Tapa: {this.TapaDura} - Disponibilidad: {this.Disponibilidad} - Precio Final {this.PrecioFinal}" );
        }

    }
}
