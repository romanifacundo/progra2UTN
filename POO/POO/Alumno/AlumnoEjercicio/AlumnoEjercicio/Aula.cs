using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnoEjercicio
{
    internal class Aula
    {
        //Propiedasdes privadas.
        private string _nombreAula;
        private List<Alumno> _alumnosLista;


        //Constructores.
        public Aula() 
        {
            this.NombreAula = "";
            this._alumnosLista = new List<Alumno>();
        }

        public Aula(string nombreAula)
        {
            this.NombreAula = nombreAula;
            this._alumnosLista = new List<Alumno>();
        }


        //Propiedades publicas.
        public string NombreAula 
        {
            get 
            { 
                return this._nombreAula; 
            }
            set 
            {
                this._nombreAula = value;
            }
        }


        //Metodos
        public void AgregarAlumno(Alumno alu) 
        {
            this._alumnosLista.Add(alu);
        }

        public void ListarAlumnos() 
        {
            foreach (Alumno alu in this._alumnosLista)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                alu.MostrarDatos();
            }
        }
        

    }
}
