using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Cliente
    {
        //Propiedad privada.
        private int _id;
        private string _nombre;
        private long _CUIT;
        private float _saldo;
    

        //Constructor.
        public Cliente()
        {
          
        }

        public Cliente(int id, string nombre, long CUIT, float saldo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.CUIT = CUIT; 
            this.Saldo = saldo;
        }


        //Propiedad publica.
        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string Nombre 
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public long CUIT
        {
            get
            {
                return this._CUIT;
            }
            set
            {
                this._CUIT = value;
            }
        }

        public float Saldo 
        {
            get
            {
                return this._saldo;
            }
            set
            {
                this._saldo = value;
            }
        }

        //Metodos.

    }
}

