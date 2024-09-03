using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;

            Banco banco = new Banco();

            //Llamado al menu.
            Menu();

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:

                    banco.ListarClientes();

                    break;

                case 2:

                    int numId;
                    float depo;

                    Console.WriteLine("Cual es su ID para efectuar el deposito");
                    numId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Cuanto quieres depositar?");                            
                    depo = float.Parse(Console.ReadLine());

                    banco.Depositar(numId, depo);

                    break;

                case 3:

                    break;

                case 4:

                    break;

                case 5:

                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

        static void Menu()
        {
            //Menu array.
            string[] menu = { "1)MOSTRAR CLIENTE", "2)DEPOSITO CLIENTE", "3)EXTRAER CLIENTE", "4)TOTALES ", "5)SALIR" };

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________");

            for (int i = 0; i < menu.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(menu[i]);
            }

            Console.WriteLine("_______________________");

            Console.WriteLine("Ingresa Opcion del Menu");
        }
    }
}
