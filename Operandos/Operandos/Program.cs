using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operandos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operandos Binarios
            int num1 = 8;
            double nume2 = 4.5;
            double resultado;


            //sumando dos variables 
            resultado = num1 + nume2;
            Console.WriteLine(resultado);

            //operador resta 
            resultado = num1 - nume2;
            Console.WriteLine(resultado);

            //operador multiplicacion 

            resultado = num1 * nume2;
            Console.WriteLine(resultado);

            //sumar dos varialbles string 

            string saludo = "Hola", nombre = "Fabio";
                        
            Console.WriteLine(saludo + nombre);

            // ahora concatenar cadenas
            Console.WriteLine(saludo + " " + nombre + " Que se dice pues");

            //operador division 
            // toca poner los decimales en su divisor 
            // el decimal utiliza una mayor presicion 
            decimal h = 4.0M, resultado2;
            decimal h2 = 134567M;

            resultado2 = (h / h2);

            Console.WriteLine(resultado2);

            //modulo o resto 

            int num3 = 5;
            int num4 = 2;

            Console.WriteLine(num3 % num4);

            // modulo con numeros decimales 

            float num5 = 5.8F;
            float num6 = 2.2F;

            Console.WriteLine(num5 % num6);

        }
    }
}
