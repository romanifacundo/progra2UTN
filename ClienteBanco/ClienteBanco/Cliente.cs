using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBanco
{
    class Cliente
    {
        //___Propiedades privadas___
        private int _id;
        private string _nombre;
        private long _cuit;
        private float _saldo;


        //___Constuctores___
        public Cliente(int id , string nombre , long CUIT , float saldo) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.CUIT = CUIT;
            this.Saldo = saldo;
        }


        //____Propiedades publicas___
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
                return this._cuit;
            }
            set
            {
                this._cuit = value;
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


        //___Metodos___
        
    }
}
