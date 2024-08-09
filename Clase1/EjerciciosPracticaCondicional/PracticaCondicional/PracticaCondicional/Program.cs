using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracticaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1.Cree un programa que permita saber, en base a la nota final del curso de un alumno, si
            ha aprobado o ha desaprobado. Si la nota es mayor que 6, el alumno ha aprobado, en
            caso contrario, ha desaprobado.*/

            //int notaFinal;

            //Console.WriteLine("Ingresa la nota final para ver tu condicion de aprobar o no.");
            //notaFinal = int.Parse(Console.ReadLine());

            //if (notaFinal >= 6) 
            //{
            //    Console.WriteLine("Aprobaste");
            //}
            //else 
            //{
            //    Console.WriteLine("Desaprobaste");
            //}

            //Console.ReadKey();


            /***************************************************************************************/


            /* 2.Cree un programa que valide si el número ingresado es par o impar*/

            //int num;

            //Console.WriteLine("Ingresa un numero");
            //num = int.Parse(Console.ReadLine());

            //if (num %2 == 0) 
            //{
            //    Console.WriteLine("El numero ingresado {0} es PAR!", num );
            //}
            //else 
            //{
            //    Console.WriteLine("El numero ingresado {0} es IMPAR!", num);
            //}

            //Console.ReadKey();


            /***************************************************************************************/


            /*3.Cree un programa que solicite al usuario el lado de un cuadrado.Luego le debe pedir
            una opción al usuario, si elige 1, le debe mostrar el perímetro del cuadrado, si elige 2, 
            le debe mostrar el área del cuadrado.*/

            //int lado, opcion;

            //Console.WriteLine("Ingresa el lado de un cuadrado");
            //lado = int.Parse(Console.ReadLine());
            //Console.WriteLine("\n");

            //Console.WriteLine("Elija una de las dos opciones");
            //Console.WriteLine("- 1) -");
            //Console.WriteLine("- 2) -");
            //opcion = int.Parse(Console.ReadLine());

            //if ( opcion == 1 ) 
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("El Perimetro del cuadrado es {0}", lado * 4);
            //}
            //else if ( opcion == 2 ) 
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("El Area del cuadrado es {0}", lado*lado);
            //}

            //Console.ReadKey();


            /***************************************************************************************/


            ///*5.Cree un programa que valide la edad actual del usuario.Considerar días y meses, y si, 
            //en el momento de la evaluación cumple años, imprimir un mensaje con la felicitación.*/

            //const int mesActual = 8; //se debe variar en este algoritmo manual digamos.
            //const int diaActual = 1; //se debe variar en este algoritmo manual digamos.
            //const int anoActual = 2024;
            //int mesNacimiento, diaNacimiento, anoNacimiento, edad;

            //Console.WriteLine("Ingresa tu dia de nacimiento");
            //diaNacimiento = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingresa tu mes de nacimiento");
            //mesNacimiento = int.Parse(Console.ReadLine());

            //Console.WriteLine("Ingresa tu año de nacimiento");
            //anoNacimiento = int.Parse(Console.ReadLine());

            //edad = anoActual - anoNacimiento; 

            //if (diaActual == diaNacimiento && mesActual == mesNacimiento) 
            //{
            //    Console.WriteLine("FELIZ CUMPLEAÑOS cumpliste {0} ", edad);             
            //}
            //else
            //{
            //    Console.WriteLine("Tu edad es {0}", edad);
            //}

            //Console.ReadKey();


            /***************************************************************************************/


            /*6.Cree un programa que solicite la siguiente información: Nombre, sexo, cantidad de
            hijos y monto total de compra. En base a esa información, se debe realizar lo siguiente.
            Si el cliente es hombre y no Ɵene hijos, le debes aplicar un descuento de 2.5 % al monto
            total de compra. Si Ɵene 1 a más hijos, debes aplicarle un descuento de 5 % al monto
            de compra.Si es mujer y no Ɵene hijo, debe aplicarle 10 % de descuento, si Ɵene 1 o 2, 
            debes aplicar 15 % de descuento y si Ɵene 3 a más hijos, debes aplicar el 20 % de
            descuento a la compra. El programa debe imprimir “Señor”, “Señorita” o “Señora” 
            respecƟvamente y su nombre. La mujer es señorita si no Ɵene hijos. Además, debe
            imprimir el subtotal, el descuento y el monto final de compra.*/

            //const string generoMasculino = "hombre";
            //const string generoFemenino = "mujer"; 
            //string nombre, sexo;
            //int edad,cantHijos,totalCompra;

            //Console.WriteLine("Ingresa tu Nombre");
            //nombre = Console.ReadLine();
            //Console.WriteLine("Ingresa tu Sexo hombre/mujer");
            //sexo = Console.ReadLine();
            //Console.WriteLine("Ingresa tu Edad");
            //edad = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa Cantidad de hijos");
            //cantHijos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingresa monto Total de compra");
            //totalCompra = int.Parse(Console.ReadLine());

            //if(sexo == generoMasculino && cantHijos == 0)
            //{
            //    int subtotal = totalCompra;
            //    double descuentoMasculino1 = (totalCompra * 2.5) / 100;
            //    double montoFinal = totalCompra - descuentoMasculino1;
            //    Console.WriteLine("Señor {0} el subtotal de la compra es {1} con el descuento aplicado del 2.5% es {2} nos daria como importe final ${3} ", nombre, subtotal, descuentoMasculino1, montoFinal);
            //}
            //else if(sexo == generoMasculino && cantHijos >= 1)
            //{
            //    int subtotal = totalCompra;
            //    int descuentoMasculino2 = (totalCompra * 5) / 100;
            //    int montoFinal = totalCompra - descuentoMasculino2;
            //    Console.WriteLine("Señor {0} el subtotal de la compra es {1} con el descuento aplicado del 5% es {2} nos daria como importe final ${3} ", nombre, subtotal, descuentoMasculino2, montoFinal);
            //}
            //else if (sexo == generoFemenino && cantHijos == 0)
            //{
            //    int subtotal = totalCompra;
            //    int descuentoFemenino1 = (totalCompra * 10) / 100;
            //    int montoFinal = totalCompra - descuentoFemenino1;
            //    Console.WriteLine("Señorita {0} el subtotal de la compra es {1} con el descuento aplicado del 10% es {2} nos daria como importe final ${3} ", nombre, subtotal, descuentoFemenino1, montoFinal);
            //}
            //else if ((sexo == generoFemenino) && cantHijos == 1 || cantHijos == 2) 
            //{
            //    int subtotal = totalCompra;
            //    int descuentoFemenino2 = (totalCompra * 15) / 100;
            //    int montoFinal = totalCompra - descuentoFemenino2;
            //    Console.WriteLine("Señora {0} el subtotal de la compra es {1} con el descuento aplicado del 15% es {2} nos daria como importe final ${3} ", nombre, subtotal, descuentoFemenino2, montoFinal);
            //}
            //else if (sexo == generoFemenino && cantHijos >= 3)
            //{
            //    int subtotal = totalCompra;
            //    int descuentoFemenino3 = (totalCompra * 20) / 100;
            //    int montoFinal = totalCompra - descuentoFemenino3;
            //    Console.WriteLine("Señora {0} el subtotal de la compra es {1} con el descuento aplicado del 20% es {2} nos daria como importe final ${3} ", nombre, subtotal, descuentoFemenino3, montoFinal);
            //}

            //Console.ReadKey();


            /***************************************************************************************/


            /* 7.Cree un programa que pida los tres lados de un triángulo e indique el tipo de triángulo
            que es según sus lados: Equilátero, Isósceles o Escaleno.*/


            //int ladoA, ladoB, ladoC;

            //Console.WriteLine("Ingrese LADO A del triangulo");
            //ladoA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese LADO B del triangulo");
            //ladoB = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese LADO C del triangulo");
            //ladoC = int.Parse(Console.ReadLine());

            //if (ladoA == ladoB && ladoA == ladoC && ladoB == ladoC) 
            //{
            //    Console.WriteLine("triangulo equilatero");
            //}
            //else if (ladoA == ladoB ||  ladoA == ladoC || ladoC == ladoB) 
            //{
            //    Console.WriteLine("triangulo isósceles");
            //}
            //else 
            //{
            //    Console.WriteLine("triangulo escaleno");
            //}

            //Console.ReadKey();


            /***************************************************************************************/


            /*8.Cree un programa que permita ingresar una vocal y te devuelva una palabra que
            empiece por esa vocal(A: avión, E: elefante, I: iglesia, O: octubre, U: universidad).*/

            //char vocal;
            //string palabra;
          
            //Console.WriteLine("Ingrese una vocal A, E, I, O, U ");
            //vocal = char.ToUpper(Console.ReadLine()[0]);// paso de mauyuscula .ToUpper

            //if (vocal == 'A')
            //{
            //    palabra = "avión";
            //}
            //else if (vocal == 'E')
            //{
            //    palabra = "elefante";
            //}
            //else if (vocal == 'I')
            //{
            //    palabra = "iglesia";
            //}
            //else if (vocal == 'O')
            //{
            //    palabra = "octubre";
            //}
            //else if (vocal == 'U')
            //{
            //    palabra = "universidad";
            //}
            //else 
            //{
            //    palabra = "debe ingresar una vocal A, E, I, O, U";
            //}

            //Console.WriteLine(palabra);
            
            //Console.ReadKey();
        }
    }

}


