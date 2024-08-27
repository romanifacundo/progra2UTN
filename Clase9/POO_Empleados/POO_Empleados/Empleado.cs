using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Empleados
{
    internal class Empleado
    {
        private int dni;
        private string nombre;
        private string apellido;
        private float sueldo;

        public Empleado(int dni, string nombre, string apellido, float sueldo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo;
        }

        //public Empleado()
        //{
            
        //}

        public int DNI
        {
            get { return this.dni; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public float Sueldo
        {
            get { return this.sueldo; }
        }

        public void CrearArchivo() 
        {
            FileStream Arch;
            StreamWriter StreamGrabar;
            StreamReader StreamLeer;
            string cadena;

            Empleado empleado1 = new Empleado(35221395, "Facundo", "Romani", 100.2f);
            Empleado empleado2 = new Empleado(99999999, "Naldo", "Velazquez", 200.2f);
            Empleado empleado3 = new Empleado(99999999, "Alexis", "Ruggiero", 300.2f);

            Empleado[] empleados = new Empleado[4];
            empleados[0] = empleado1;
            empleados[1] = empleado2;
            empleados[2] = empleado3;

            Arch = new FileStream("Empleados.txt", FileMode.Create);
            StreamGrabar = new StreamWriter(Arch);

            for (int i = 0; i < empleados.Length; i++)
            {
                cadena = $"{empleados[i].DNI},{empleados[i].Nombre},{empleados[i].Apellido},{empleados[i].Sueldo}";

                StreamGrabar.WriteLine(cadena);

                string[] parte = cadena.Split(',');

                Console.WriteLine($"DNI: {parte[0]}, Nombre: {parte[1]}, Apellido: {parte[2]}, Sueldo: {parte[3]}");
            }

            StreamGrabar.Close();
            Arch.Close();

            //___________________________________leer empleados___________________________________________//


            if (File.Exists("Empleados.txt"))
            {
                //Console.Clear();
                Console.WriteLine("Lista de empleados \n");
                Arch = new FileStream("Empleados.txt", FileMode.Open);
                StreamLeer = new StreamReader(Arch);

                while (!StreamLeer.EndOfStream)
                {
                    cadena = StreamLeer.ReadLine();
                    Console.WriteLine(cadena);
                }

                StreamLeer.Close();
                Arch.Close();
            }
            else
            {
                Console.WriteLine("No Existe el Archivo");
            }
        }
    }
}
