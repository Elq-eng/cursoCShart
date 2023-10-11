using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Dowhile
 * Resumen
 * Elquin Cascavita
 * Version 4.7.2 de .net
 */
namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = 1;

            do
            {
                Console.WriteLine("Impresion de " + z);
                z += 1;
            } while (z <= 10);
        }
    }
}
