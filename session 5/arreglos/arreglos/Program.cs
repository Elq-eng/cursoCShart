using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Arrays 
 * Resumen como hacer arrays 
 * Elquin Cascavita Rios 
 * Version 4.7.2
 * 
 */
namespace arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglo
            string[] cadenas = new string[5];

            cadenas[0] = "Hola mundo";
            Console.WriteLine("Resultados {0}", cadenas.Length);
            Console.WriteLine(cadenas[0]);


        }
    }
}
