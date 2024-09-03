using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ClienteBanco
{
    class Banco
    {
        //___Propiedades privadas___
        private List<Cliente> _listaClientes;


        //___Constructores___
        public Banco()
        {
            this._listaClientes = new List<Cliente>();
        }


        //___Metodos___
        public void LeerArchivo(string archivoClientes)
        {
            FileStream Arch;
            StreamReader Leer;
            string cadena;
            string[] datos;

            if (File.Exists(archivoClientes))
            {
                Arch = new FileStream(archivoClientes, FileMode.Open);
                Leer = new StreamReader(Arch);

                while (!Leer.EndOfStream) 
                {
                    cadena =Leer.ReadLine();
                    datos = cadena.Split('|');

                    Cliente cli = new Cliente(
                        int.Parse(datos[0]), 
                        datos[1], 
                        long.Parse(datos[2]), 
                        float.Parse(datos[3]));

                    _listaClientes.Add(cli);
                }

                Leer.Close();
                Arch.Close();
            }
        }

        public void GrabarArchivo(string archivoClientes)
        {
            FileStream Arch;
            StreamWriter Grabar;

            if (File.Exists(archivoClientes))
            {
                Arch = new FileStream(archivoClientes, FileMode.Create);
                Grabar = new StreamWriter(Arch);

                for (int i = 0; i < this._listaClientes.Count; i++)
                {
                    Grabar.WriteLine(_listaClientes[i].Id + " | " + _listaClientes[i].Nombre + " | " + _listaClientes[i].CUIT + " | " + _listaClientes[i].Saldo);
                }

                Grabar.Close();
                Arch.Close();
            }
        }

        public void ListarClientes() 
        {

            foreach (Cliente cli in this._listaClientes)
            {
                Console.WriteLine(cli.Id + " " + cli.Nombre + " " + cli.CUIT + " " + cli.Saldo);
            }
        }

        public void Depositar(int id, float monto) 
        {
            for (int i = 0; i < this._listaClientes.Count; i++)
            {
                if(this._listaClientes[i].Id == id) 
                {
                    this._listaClientes[i].Saldo += monto;  //___Acumulador___             
                }
            }
        }

        public void Extraer(int id, float monto)
        {
            for (int i = 0; i < this._listaClientes.Count; i++)
            {
                if (this._listaClientes[i].Id == id)
                {
                    this._listaClientes[i].Saldo -= monto;              
                }
            }
        }
    }
}
