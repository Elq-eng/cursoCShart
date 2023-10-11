using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Sintaxis de variables 
 * Resumen 
 * Elquin Cascavita Rios
 * version 4.7.2
 */

namespace sintaxis_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int num1,num2,resultado;

            //entradas 
            Console.WriteLine("Introduce el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            //operacion 
            resultado = num1 + num2;

            //mostrar el resultado 
            Console.WriteLine("El resultado es " + (num1 + num2));





        }
    }
}
