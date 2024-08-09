using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TPNro1_Programacion2
{
    class Program
    {
        // DECLARACION Globales.
        static string[] codigos = new string[7];
        static string[] descripciones = new string[15];
        static int[] stockActual = new int[5];
        static int[] stockMinimo = new int[5];
        static string[] marcas = new string[10];
        static decimal[] preciosUnitarios = new decimal[8];

        static int totalProductos = 0;
        static void Main(string[] args)
        {

            //string[] Codigos = new string[15];
            //string[] Descripciones = new string[15];
            //int[] StockActual = new int[15];
            //int[] StockMinimo = new int[15];
            //string[] Marcas = new string[15];
            //decimal[] PreciosUnitarios = new decimal[15];

            //int totalProductos = 0;

            char opcion;

            while (true)
            {
                Console.Clear();
                MenuPrincipal();
                opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcion)
                {
                    case 'A':
                    case 'a':
                        AgregarHerramienta();
                        break;
                    case 'B':
                    case 'b':
                        BuscarPorMarca();
                        break;
                    case 'L':
                    case 'l':
                        MostrarListaDeProductos(codigos, descripciones, stockActual, stockMinimo, marcas, preciosUnitarios, totalProductos);
                        break;
                    case 'S':
                    case 's':
                        SalirDelMenu(opcion);
                        return;
                    default:
                        Console.WriteLine("Opción no es válida en el MENU. Por favor, seleccione una opción válida.");                   
                        break;
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }



        //Procedimiento del MENU PRINCIPAL.
        public static void MenuPrincipal()
        {
            Console.WriteLine("****CONTROL DE STOCK FERRETERIA****");
            Console.WriteLine();
            Console.WriteLine("A - Agregar un registro");
            Console.WriteLine("B - Buscar por marca");
            Console.WriteLine("L - Lista completa de herramientas");
            Console.WriteLine("S - Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");
        }



        // Función para salir del programa.
        public static bool SalirDelMenu(char opcion)
        {
            if (opcion == 'S' || opcion == 's')
            {
                Console.WriteLine("Saliendo del programa.");
                return true;
            }

            return false;
        }



        // PROCEDIMIENT0 para AÑADIR Producto.
        public static void AgregarHerramienta()
        {

            Console.WriteLine("Ingresar Producto al STOCK:");

            Console.Write("Código: ");
            codigos[totalProductos] = Console.ReadLine();

            Console.Write("Descripción: ");
            descripciones[totalProductos] = Console.ReadLine();

            //BANDERA. 
            bool ingresoValido = false;

            while (!ingresoValido)
            {
                Console.Write("Stock Actual: ");
                if (int.TryParse(Console.ReadLine(), out stockActual[totalProductos]) && stockActual[totalProductos] >= 0)
                {
                    ingresoValido = true;
                }
                else
                {
                    Console.WriteLine("ERROR Stock Actual debe ser un número positivo.");
                    Console.WriteLine("VUELVA A INGRESAR NUEVAMENTE: ");
                }
            }
            
            ingresoValido = false;

            while (!ingresoValido)
            {
                Console.Write("Stock Mínimo: ");
                if (int.TryParse(Console.ReadLine(), out stockMinimo[totalProductos]) && stockMinimo[totalProductos] >= 0)
                {
                    ingresoValido = true;
                }
                else
                {
                    Console.WriteLine("ERROR Stock Mínimo debe ser un número positivo.");
                    Console.WriteLine("VUELVA A INGRESAR NUEVAMENTE: ");
                }
            }

            Console.Write("Marca: ");
            marcas[totalProductos] = Console.ReadLine();

            ingresoValido = false;

            while (!ingresoValido)
            {
                Console.Write("Precio Unitario: ");
                if (decimal.TryParse(Console.ReadLine(), out preciosUnitarios[totalProductos]) && preciosUnitarios[totalProductos] >= 0)
                {
                    ingresoValido = true;
                }
                else
                {
                    Console.WriteLine("ERROR Precio Unitario debe ser un número decimal.");
                    Console.WriteLine("VUELVA A INGRESAR NUEVAMENTE: ");
                }
            }

            // CARACTERES.
            string nuevoRegistro = $"{codigos[totalProductos],-7} {descripciones[totalProductos],-15} {stockActual[totalProductos],-5:D} {stockMinimo[totalProductos],-5:D} {marcas[totalProductos],-10} {preciosUnitarios[totalProductos],-8:F2}";

            FileStream archivo = new FileStream("StockDeProductos.txt", FileMode.Append);
            StreamWriter streamGrabar = new StreamWriter(archivo);

            streamGrabar.WriteLine(nuevoRegistro);

            streamGrabar.Close();
            archivo.Close();

            totalProductos++; // Incrementa el contador de productos

            Console.WriteLine();
            Console.WriteLine("***********************************");
            Console.WriteLine("El Producto fue agregado con éxito.");
            Console.WriteLine("***********************************");
        }




        // Función PARA Listar los Producto.
        static void MostrarListaDeProductos(string[] Codigos, string[] Descripciones, int[] StockActual, int[] StockMinimo, string[] Marcas, decimal[] PreciosUnitarios, int totalProductos)
        {

            Console.WriteLine("┌─────────────┬─────────────────┬──────┬──────┬───────┬─────────┐");
            Console.WriteLine("│   Código    │   Descripción   │ St.A │ St.M │ Marca │   P.U   │");
            Console.WriteLine("├─────────────┼─────────────────┼──────┼──────┼───────┼─────────┤");

            for (int i = 0; i < totalProductos; i++)
            {
                Console.WriteLine($"│ {Codigos[i],-12} │ {Descripciones[i],-16} │ {StockActual[i],-5} │ {StockMinimo[i],-5} │ {Marcas[i],-10} │ {PreciosUnitarios[i],-8:F2} │");

                if (i < totalProductos - 1)
                {
                    Console.WriteLine("├─────────────┼─────────────────┼──────┼──────┼───────┼─────────┤");
                }
            }

            Console.WriteLine("└─────────────┴─────────────────┴──────┴──────┴───────┴─────────┘");
        }



        //PROCEDIMIENTO BUSCAR POR MARCA.
        public static void BuscarPorMarca()
        {
            bool seEncontroHerramienta = false;

            while (!seEncontroHerramienta)
            {
               
                Console.WriteLine("***************************************** ");
                Console.Write("Ingrese nuevamente la marca que quiere buscar: ");
                string marcaBuscada = Console.ReadLine();

                
                Console.WriteLine("RESULTADOS marca: ");
                Console.WriteLine("***************************************** ");

                for (int i = 0; i < totalProductos; i++)
                {
                    if (marcas[i] == marcaBuscada)
                    {
                        Console.WriteLine($"Código: {codigos[i]}");
                        Console.WriteLine($"Descripción: {descripciones[i]}");
                        Console.WriteLine($"Stock Actual: {stockActual[i]}");
                        Console.WriteLine($"Stock Mínimo: {stockMinimo[i]}");
                        Console.WriteLine($"Marca: {marcas[i]}");
                        Console.WriteLine($"Precio Unitario: {preciosUnitarios[i]}");
                        Console.WriteLine();

                        // BANDERA2
                        seEncontroHerramienta = true;
                    }
                }

                if (!seEncontroHerramienta)
                {
                    Console.WriteLine("No se encontraron productos con el nombre de la MARCA ingresada.");
                    Console.WriteLine("VUELVA A INGRESAR LA MARCA.");
                }
            }
        }


    }
}








