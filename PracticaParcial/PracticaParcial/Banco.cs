using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Banco
    {
        FileStream Archivo;
        StreamWriter Guardar;
        StreamReader Leer;
        string cadena;
        private List<Cliente> _clientes;


        //Contructor
        public Banco()
        {
            this._clientes = new List<Cliente>();
        }


        //Metodos.

        public void ListarClientes()
        {
            if (File.Exists("clientes.txt"))
            {
                Archivo = new FileStream("clientes.txt", FileMode.Open);
                Leer = new StreamReader(Archivo);
       
                while (!Leer.EndOfStream)
                {
                    cadena = Leer.ReadLine();
                    string[] sub = cadena.Split('|');

                    if (sub.Length == 4)//tamaño cad.
                    {
                        Cliente cli = new Cliente(
                           int.Parse(sub[0]),
                           sub[1],
                           long.Parse(sub[2]),
                           float.Parse(sub[3]));

                        this._clientes.Add(cli);
                    }

                    //Cliente cli = new Cliente(int.Parse(sub[0]), sub[1], long.Parse(sub[2]), float.Parse(sub[3]));
                    //this._clientes.Add(cli);
                }
            }
            else
            {
                Console.WriteLine("El archivo clientes.txt no existe.");
            }

            Leer.Close();
            Archivo.Close();

            //Listar.
            foreach (Cliente cli in this._clientes)
            {
                Console.WriteLine($"ID: {cli.Id} | NOMBRE: {cli.Nombre} | CUIT: {cli.CUIT} | SALDO: {cli.Saldo}");
            };
        }

        public void Depositar(int numId, float depo)
        {

            //__Probar si llega vacia la lista___
            //if (this._clientes.Count == 0)
            //{
            //    Console.WriteLine("lista vacía");
            //    return;
            //}

            ListarClientes();//**IMPORTANTE**
            
            bool encontrado = false;

            foreach (Cliente cli in this._clientes)
            {
                if (cli.Id == numId)
                {
                    cli.Saldo += depo;
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {     
                Archivo = new FileStream("clientes.txt", FileMode.Create);
                Guardar = new StreamWriter(Archivo);

                //Guardar.WriteLine($"{this._clientes[num]} | {cli.Nombre} | {cli.CUIT} | {cli.Saldo}");

                foreach (Cliente cli in this._clientes)
                {
                    Guardar.WriteLine($"{cli.Id} | {cli.Nombre} | {cli.CUIT} | {cli.Saldo}");
                }

                Guardar.Close();
                Archivo.Close();
     
                //ListarClientes();
            }
            else
            {
                Console.WriteLine("Cliente no encontrado");
            }
        }
    }
}

