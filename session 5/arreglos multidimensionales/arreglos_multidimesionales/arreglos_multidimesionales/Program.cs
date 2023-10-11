using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Array multidiensional
 * Resumamen: 
 * Elquin Cascavita Rios
 * version 4.7.2
 */


namespace arreglos_multidimesionales
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] doble = new double[2, 2] { { 7,98},{ 8,9} };

            //dos filas, dos columnas, se alamcenas 3 datos 
            double[,,] doble3 = new double[3, 2, 3] { { { 1, 8,9 }, { 3, 9,83.9 } },{ {4,7,9},{7,8,78} },{ { 4, 7, 9 }, { 7, 8, 78 } } };


        }
    }
}
