using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Mercado
    {
        //___Propiedades privadas___
        private string _razonSocial;
        private int _cantEmpleado;
        private string _direcInstitu;
        private int _cantArticulos;
        private List<Empleado> _listaEmpContra;
        private List<Articulo> _listaArticulosRegistrados;


        //___Constructores___
        public Mercado()
        {
            this._listaEmpContra = new List<Empleado>();
            this._listaArticulosRegistrados = new List<Articulo>();
        }

        public Mercado(string razSo, int cantEmp, string direc, int cantArt)
        {
            this.RazonSocial = razSo;
            this._cantEmpleado = cantEmp;
            this.Direccion = direc;
            this._cantEmpleado = cantArt;
        }


        //___Propiedades publicas___
        public string RazonSocial
        {
            get
            {
                return this._razonSocial;
            }
            set
            {
                this._razonSocial = value;
            }
        }

        public int CantidadEmpleado
        {
            get
            {
                return this._cantEmpleado;
            }
        }

        public string Direccion
        {
            get
            {
                return this._direcInstitu;
            }
            set
            {
                this._direcInstitu = value;
            }
        }

        public int CantArticulo
        {
            get
            {
                return this._cantArticulos;
            }
        }


        //___Metodos___
        public void LeerArchivoArticulosRegis(string archivoArticulos)
        {
            FileStream Archivo;
            StreamReader Leer;
            string cad;

            Archivo = new FileStream(archivoArticulos, FileMode.Open);
            Leer = new StreamReader(Archivo);

            if (File.Exists(archivoArticulos))
            {
                while (!Leer.EndOfStream)
                {
                    cad = Leer.ReadLine();
                    string[] datos = cad.Split(';');
                    Articulo art = new Articulo(
                         int.Parse(datos[0]),
                         datos[1],
                         datos[2],
                         int.Parse(datos[3]),
                         int.Parse(datos[4]));

                    this._listaArticulosRegistrados.Add(art);
                }
            }

            Leer.Close();
            Archivo.Close();
        }

        public void LeerArchivoEmpleado(string archivoEmple)
        {
            FileStream Archivo;
            StreamReader Leer;
            string cad;

            Archivo = new FileStream(archivoEmple, FileMode.Open);
            Leer = new StreamReader(Archivo);

            if (File.Exists(archivoEmple))
            {
                while (!Leer.EndOfStream)
                {
                    cad = Leer.ReadLine();
                    string[] datos = cad.Split(';');
                    Empleado emp = new Empleado(
                        long.Parse(datos[0]),
                        datos[1],
                        datos[2],
                        float.Parse(datos[3]));

                    this._listaEmpContra.Add(emp);
                }
            }

            Leer.Close();
            Archivo.Close();
        }

        public void EmpleadosContratados()
        {
            int totalEmp = 0;
            float tolSuel = 0;

            foreach (Empleado emp in this._listaEmpContra)
            {
                Console.WriteLine(emp.DNI + " " + emp.Apellido + " " + emp.Nombre + " " + emp.Sueldo);
                totalEmp = this._listaEmpContra.Count();
                tolSuel += emp.Sueldo;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("______________________________");
            Console.WriteLine($"El total del los empleados es: {totalEmp}");
            Console.WriteLine("______________________________");
            Console.WriteLine($"El total de sueldo es: {tolSuel}");
        }

        public void ArticulosRegistrados()
        {
            int cantAlm = 0;
            int cantLib = 0;
            int cantElec = 0;
            int totalAlm = 0;
            int totalLib = 0;
            int totalElec = 0;
            int promedioAlm = 0;
            int promedioLib = 0;
            int promedioElec = 0;

            foreach (Articulo art in this._listaArticulosRegistrados)
            {
                Console.WriteLine(art.IdArt + " " + art.DescArt + " " + art.Categoria + " " + art.Stock + " " + art.PrecioUnitario);
                
                if(art.Categoria == "almacen") 
                {
                    cantAlm += art.Stock;
                    totalAlm++;
                    promedioAlm = cantAlm / totalAlm;
                }
                else if(art.Categoria == "libreria")
                {
                    cantLib += art.Stock;
                    totalLib++;
                    promedioLib = cantLib / totalLib;
                }
                else
                {
                    cantElec += art.Stock;
                    totalElec++;
                    promedioElec = cantElec / totalElec;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("______________________________");
            Console.WriteLine($"La cantidad de articulos de la categotia almacen es: {cantAlm}");
            Console.WriteLine($"Promedio del precio unitario de categoría almacen es: {promedioAlm}");
            Console.WriteLine("______________________________");
            Console.WriteLine($"La cantidad de articulos de la categotia libreria es: {cantLib}");
            Console.WriteLine($"Promedio del precio unitario de categoría libreria es: {promedioLib}");
            Console.WriteLine("______________________________");
            Console.WriteLine($"La cantidad de articulos de la categotia electronica es: {cantElec}");
            Console.WriteLine($"Promedio del precio unitario de categoría electronica es: {promedioElec}");
        }

    }
}
