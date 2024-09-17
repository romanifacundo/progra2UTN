using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial2
{
    internal class Producto
    {
        
        //__Propiedades privadas__
        private int _codigo;
        private string _descripcion;
        private string _rubro;
        private int _ganancia;
        private int _costo;
  

        //__Constructor__
        public Producto(int codigo, string rubro, string descripcion, int ganancia, int costo)
        {
            this.Codigo = codigo;
            this.Rubro = rubro;
            this.Descripcion = descripcion;
            this.Costo = costo;
            this.Ganancia = ganancia;
        }

        //__Metodos de propiedades publicas__
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        }
        public string Rubro
        {
            get { return this._rubro; }
            set { this._rubro = value; }
        }
        public int Costo
        {
            get { return this._costo; }
            set { this._costo = value; }
        }
        public int Ganancia
        {
            get { return this._ganancia; }
            set { this._ganancia = value; }
        }

        public float Precio
        {
            get { return this._costo + (this._costo * this._ganancia / 100);  }
        }


        //__Metodos__
        public void MostrarDatosProducto()
        {
            //Codigo: xxxx – Rubro: xxxx – Descripcion: xxxx – Costo: xxxx - % de ganancia: xx – Precio: xxxx
            Console.WriteLine($"Codigo: {this.Codigo} – Rubro: {this.Rubro} – Descripcion: {this.Descripcion} – Costo: {this.Costo} - % de ganancia: {this.Ganancia} – Precio: {this.Precio}");
            //Console.WriteLine("Codigo: {0} – Rubro: {1} – Descripcion: {2} – Costo: {3} - % de ganancia: {4} – Precio: {5}", this.Codigo,this.Rubro,this.Descripcion,this.Costo,this.Ganancia,this.Precio);
        }

        //public float CalcularPrecio()
        //{
        //    return this._precio = this._costo + (this._costo * this._ganancia) / 100;
        //}
    }
}
