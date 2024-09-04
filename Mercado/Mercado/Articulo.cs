using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Articulo
    {
        //___Propiedades privadas___
        private int _idArticulo;
        private string _descArticulo;
        private string _categoria;
        private int _stock;
        private int _precioUnitario;
        


        //___Constructores___
        public Articulo(int idArticulo, string descArticulo, string categoria, int stock, int precioUnitario )
        {
            this.IdArt = idArticulo;
            this.DescArt = descArticulo;
            this.Categoria = categoria;
            this.Stock = stock;
            this.PrecioUnitario = precioUnitario;
        }


        //___Propiedades publicas___
        public int IdArt
        {
            get
            {
                return this._idArticulo;
            }
            set
            {
                this._idArticulo = value;
            }
        }

        public string DescArt
        {
            get
            {
                return this._descArticulo;
            }
            set
            {
                this._descArticulo = value;
            }
        }

        public string Categoria
        {
            get
            {
                return this._categoria;
            }
            set
            {
                this._categoria = value;
            }
        }

        public int PrecioUnitario
        {
            get
            {
                return this._precioUnitario;
            }
            set
            {
                this._precioUnitario = value;
            }
        }

        public int Stock
        {
            get
            {
                return this._stock;
            }
            set
            {
                this._stock = value;
            }
        }


        //___Metodos___

    }
}
