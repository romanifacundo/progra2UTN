﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOClase1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alumno alumno1 = new Alumno();
            //alumno1.nombre = "Luis";
            //alumno1.apellido = "Lopez";
            //alumno1.edad = 20;

            //Alumno alumno2 = new Alumno();
            //alumno1.nombre = "Gomez";
            //alumno1.apellido = "Laura";
            //alumno1.edad = 22;

            //Alumno alumno3 = new Alumno();
            //alumno1.nombre = "Diaz";
            //alumno1.apellido = "Juan";
            //alumno1.edad = 21;

            ////otra manera de asignar valores al array
            //Alumno[] alumnos = new Alumno[3];
            //alumnos[0] = new Alumno { apellido = "Lopez", nombre = "Luis", edad = 20, correo = "luis@gmail.com" };
            //alumnos[1] = new Alumno { apellido = "Gomez", nombre = "Laura", edad = 22 , correo = "laura@gmail.com" };
            //alumnos[2] = new Alumno { apellido = "Diaz", nombre = "Juan", edad = 21 , correo = "juan@gmail.com" };

            //for (int i = 0; i < alumnos.Length; i++)
            //{
            //    //Console.WriteLine(aula[i].apellido + " " + aula[i].nombre + " " + aula[i].edad + " " + aula[i].correo);
            //    alumnos[i].Mostrar();
            //}

            /*************************************************************************************************************/

            Alumno a1 = new Alumno("Lopez", "Luis", 20, "luis@gmail.com");
            Alumno a2 = new Alumno("Gomez", "Laura", 22, "laura@gmail.com");
            Alumno a3 = new Alumno("Diaz", "Juan", 21, "juan@gmail.com");

            Alumno[] aula = { a1, a2, a3 };

            foreach (Alumno item in aula)
            {
                //Console.WriteLine(item.apellido + " " + item.nombre + " " + item.edad + " " + item.correo);
                item.Mostrar();
            }

            Console.ReadLine();
        }
    }

    class Alumno
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string correo;

        public Alumno(string ap, string no, int ed, string co)
        {      
            this.apellido = ap;
            this.nombre = no;
            this.edad = ed;
            this.correo = co;
        }

        public void Mostrar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Apellido: {0}  |  Nombre: {1}  |  Edad: {2}  |  Correo: {3}", apellido, nombre, edad, correo);
        }

    }
}
