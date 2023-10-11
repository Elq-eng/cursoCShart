using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*iteraciones anidadas
 * Resumen
 * Elquin Cascavita
 * version .net 4.7.2
 */
namespace iteraciones_anidadas
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio de tablas de multiplicar
            //variables
            int i, j, resultado;

            //tablas de multiplicar 
            //bloque exterior
            for (i = 1; i <= 10; i++ )
            {
                //bucle inferior

                Console.WriteLine("Tabla de multiplicar del {0}", i);
                for (j = 1; j <= 10; j++)
                {
                    resultado = i * j;

                    Console.WriteLine("{0} x {1} = {2}",i,j,resultado);
                }
            }
        }
    }
}
