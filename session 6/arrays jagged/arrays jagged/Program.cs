using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*arrays jagged
 * Resumen: This array is a array container that to inside is the other arrrays the differents size; 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace arrays_jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            //how to assign
            // tipo[][] Nombre = nwe tipo[tamaño arreglo contenedor][]

            //variables 
            double resultado;
            //container array
            double[][] Prueba = new double[5][];

            // inicialization the arrays 
            Prueba[0] = new double[3];
            Prueba[1] = new double[5];
            Prueba[2] = new double[1];
            Prueba[3] = new double[4];
            Prueba[4] = new double[2];

            //if you know of size the arrays
            //calificaciones[0] = new double[] {7.0,8,}
            //if you know the size of the container array
            //double[][] Prueba = new double[5+][];
            /*{
             *  new double[] {7.0,8,}
             *  new double[] {7.0,8,}
             * }
             */

            //how to assing values the cells 
            Prueba[1][3] = 7.4;

            resultado = Prueba[1][3] * 3; 

            Console.WriteLine(Prueba[1][3]);
            Console.WriteLine(resultado);


        }
    }
}
