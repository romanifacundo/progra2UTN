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
            //Clase Archivo y variables.
            FileStream Archivo;
            StreamWriter Guardar;
            StreamReader Leer;
            string cadena;
            int opc;

            //Llamado al menu.
            Menu();

            opc = int.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    Cliente cliente1 = new Cliente(1, "Martin", 20123456781, 14520f);
                    Cliente cliente2 = new Cliente(2, "Pedro", 20123456782, 5130f);
                    Cliente cliente3 = new Cliente(3, "Rosa", 27123456781, 78952f);
                    Cliente cliente4 = new Cliente(4, "Juana", 27123456782, 924f);

                    List<Cliente> clientes = new List<Cliente>();
                    clientes.Add(cliente1);
                    clientes.Add(cliente2);
                    clientes.Add(cliente3);
                    clientes.Add(cliente4);

                    Archivo = new FileStream("clientes.txt", FileMode.Create);
                    Guardar = new StreamWriter(Archivo);

                    //Grabar en el archivo la lista.
                    foreach (Cliente cli in clientes)
                    {
                        Guardar.WriteLine($"ID: {cli.Id} | NOMBRE: {cli.Nombre} | CUIT: {cli.CUIT} | SALDO:{cli.Saldo}");
                    }

                    Guardar.Close();
                    Archivo.Close();


                    Archivo = new FileStream("clientes.txt", FileMode.Open);
                    Leer = new StreamReader(Archivo);

                    if (File.Exists("clientes.txt"))
                    {
                        while (!Leer.EndOfStream)
                        {
                            cadena = Leer.ReadLine();
                            //string[] sub = cadena.Split(',');
                            //Cliente cli = new Cliente(int.Parse(sub[0]), sub[1], long.Parse(sub[2]), int.Parse(sub[3]));
                            Console.WriteLine(cadena);
                        }
                    }

                    Leer.Close();
                    Archivo.Close();

                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }

        static void Menu()
        {
            //Menu array.
            string[] menu = { "1)MOSTRAR CLIENTE", "2)DEPOSITO CLIENTE", "3)EXTRAER CLIENTE", "4)TOTALES" };

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
