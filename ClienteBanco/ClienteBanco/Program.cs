using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ClienteBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            //___Variables___
            string _archivoDeClientes = "cli.txt";
            int opcion;
            bool bucle = true;

            Banco banco = new Banco();//___Instancia de clase Banco para acceder a los metodos___
            banco.LeerArchivo(_archivoDeClientes);
            
            Menu();//___Llamado al Menu___

            while (bucle)
            {
                               
                opcion = int.Parse(Console.ReadLine());
            
                switch (opcion)
                {
                    case 1:
                        
                        Console.Clear();
                        banco.ListarClientes();            
                        
                        break;

                    case 2:

                        Console.WriteLine("Ingresa ID del cliente para el deposito");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el monto a depositar");
                        float monto = float.Parse(Console.ReadLine());

                        banco.Depositar(id , monto);
                        banco.GrabarArchivo(_archivoDeClientes);
                        banco.ListarClientes();
                        
                        break;
                    case 3:

                        Console.WriteLine("Ingresa ID del cliente para la extraccion");
                        int idExtr = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa el monto a extraer");
                        float montoExtr = float.Parse(Console.ReadLine());

                        banco.Extraer(idExtr, montoExtr);
                        banco.GrabarArchivo(_archivoDeClientes);
                        banco.ListarClientes();

                        break;
                    case 4:

                        break;
                    case 5:
                        bucle = false;
                        break;
                    default:
                        break;
                }
            }
        }


        //___Menu___
        static void Menu() 
        {
            string[] menu = { "MOSTRAR CLIENTES", "DEPOSTITO CLIENTES", "EXTRAER CLIENTE", "TOTALES", "SALIR" };

            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(menu[i]);
            }
        }
        
    }
}
