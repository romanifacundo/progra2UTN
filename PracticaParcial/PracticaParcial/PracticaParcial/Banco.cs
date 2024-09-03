using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Banco
    {
       List<Cliente> clientes;


        //Contructor
        public Banco() 
        {

        }

        public Banco(List<Cliente> Cliente)
        {
            this.clientes = new List<Cliente>();
        }

        //Metodos.

        //public void ListarClientes() 
        //{
        //    foreach (Cliente cli in clientes) 
        //    {
        //       Console.WriteLine($"{cli.Id},{cli.Nombre},{cli.CUIT},{cli.Saldo}");
        //    }
        //}
    }
}
