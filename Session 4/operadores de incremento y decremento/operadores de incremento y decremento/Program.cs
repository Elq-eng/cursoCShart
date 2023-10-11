using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Operadores de incremento
 * Resumen
 * Elquin Cascavita
 * .net 4.7.2
 */
namespace operadores_de_incremento_y_decremento
{
    class Program
    {
        static void Main(string[] args)
        {

            int i; //operando

            i = 10;

            //valor actual 
            Console.WriteLine("Valor inicial del operador: {0}", i);

            //valor de incremento con subfijo
            Console.WriteLine("Valor inicial del operador: {0}", i++);

            //valor de incremento con prefijo
            Console.WriteLine("Valor inicial del operador: {0}", ++i);

            //igual sucede con --


        }
    }
}
