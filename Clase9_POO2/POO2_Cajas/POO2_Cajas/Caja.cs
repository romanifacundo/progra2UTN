using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2_Cajas
{
    internal class Caja
    {
        private float alto, ancho, largo;
        private string mat;

        public Caja()
        {
            this.pAlto = 0.00f;
            this.pAncho = 0.00f;
            this.pLargo = 0.00f;
        }

        public Caja(float alto)
        {
            this.pAlto = alto;
            this.pAncho = 0.00f;
            this.pLargo = 0.00f;
        }

        public Caja(float alto, float ancho, float largo)
        {
            this.pAlto = alto;
            this.pAncho = ancho;
            this.pLargo = largo;
        }

        public void datosCaja()
        {
            Console.WriteLine($"Datos de la caja:\n\t Medidas: {this.pAlto}x{this.pAncho}x{this.pLargo}\n\t Material: {this.pMat}\n\t Volumnen: {pVol}");
        }

        //GETTERS Y SETTERS
        public float pAlto
        {
            get
            {
                return this.alto;
            }
            set
            {
                this.alto = value;
            }
        }

        public float pAncho
        {
            get
            {
                return this.ancho;
            }
            set
            {
                this.ancho = value;
            }
        }

        public float pLargo
        {
            get
            {
                return this.largo;
            }
            set
            {
                this.largo = value;
            }
        }

        public string pMat
        {
            get
            {
                return this.mat;
            }
            set
            {
                if (value == "madera" || value == "carton")
                {
                    this.mat = value;
                }
                else
                {
                    this.mat = "Desconocido";
                }
            }
        }

        public float pVol //PROPIEDAD SOLO LECTURA
        {
            get
            {
                return this.pAlto * this.pAncho * this.pLargo;
            }
        }
    }
}
