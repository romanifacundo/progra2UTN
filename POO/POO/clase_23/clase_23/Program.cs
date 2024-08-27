using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clase_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables y clases.
            FileStream Archivo;
            StreamWriter Grabar;
            StreamReader Leer;   
            string cadena;

            // Objetos.
            Empleado empleado1 = new Empleado(30300200, "Dario", "Apellido", 100000);
            Empleado empleado2 = new Empleado(38398592, "Alexis", "Ruggiero", 200000);
            Empleado empleado3 = new Empleado(40444555, "Facu", "Romani", 400000);

            // Lista empleados.
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);
            
            // Abre el archivo y crea los datos de los empleados.
            Archivo = new FileStream("Empleado.txt", FileMode.Create);
            Grabar = new StreamWriter(Archivo);
    
            foreach (Empleado emp in empleados)  // Emp es variable de control, y in el nombre del vector a recorrer.
            {
                Grabar.WriteLine($"{emp.DNI},{emp.Nombre},{emp.Apellido},{emp.Sueldo}");
                //emp.MostrarDatos();             
            }

            Grabar.Close();
            Archivo.Close();

            // Abre y lee el archivos
            Archivo = new FileStream("Empleado.txt", FileMode.Open);
            Leer = new StreamReader(Archivo);

            if (File.Exists("Empleado.txt"))
            {               
                while (!Leer.EndOfStream)
                {
                    cadena = Leer.ReadLine(); // Leer cadena.
                    string[] partes = cadena.Split(','); // Fragmentar cadena
                    Empleado emp = new Empleado(long.Parse(partes[0]), partes[1], partes[2], float.Parse(partes[3])); 
                    emp.MostrarDatos();
                }              
            }

            Leer.Close();
            Archivo.Close();

            Console.ReadKey();
        }
    }
}

