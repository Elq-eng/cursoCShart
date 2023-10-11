using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Marices
 * Resumen: show how is declare the variables, how assign values in matrices 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {

            //configuracion de arreglos 
            //tipo [] nombre = new tipo[tamaño]
            int a = 8;
            double resultado;


            double[] calificaciones = new double[a];
            //si se conoce los valores del arreglo entonces es 
            //double[] calificaciones = {7.0 8.9};

            //asignar valores al arreglo

            calificaciones[2] = 7.5;
            resultado = calificaciones[2] * 2;

            Console.WriteLine(calificaciones[2]);

            //ejercicio de calificaciones 
            //variable 
            int cantidadA = 0;
            int i = 0; //variable para control de ciclo 

            double suma = 0.0;
            double promedio = 0.0;

            double calificacionMinima = 10.0;
            double calificacionMaxima = 0.0;

            Console.Write("DAme la cantidad de alumnos: ");
            cantidadA = Int32.Parse(Console.ReadLine());

            //creacion arreglo
            double[] calificaciones2 = new double[cantidadA];

            for (i = 0; i < cantidadA; i++)
            {
                //agregar al array cada una de las calificaciones dependiendo el alumno 
                Console.Write("Dame la calificacion del alumno {0}:  ", i);
                calificaciones2[i] = Double.Parse(Console.ReadLine());

            }

            for(i = 0; i < cantidadA; i++)
            {
                suma += calificaciones2[i];
            }

            promedio = suma / cantidadA;

            //calificaicon minima
            for (i=0; i < calificaciones2.Length; i++)
            {
                if (calificaciones2[i] < calificacionMinima)
                {
                    calificacionMinima = calificaciones2[i];
                }
            }
            // calificaicon Maxima
            for (i = 0; i < calificaciones2.Length; i++)
            {
                if (calificaciones2[i] > calificacionMaxima)
                {
                    calificacionMaxima = calificaciones2[i];
                }
            }

            //Mostrar los resultados

            Console.WriteLine("El primedio es: {0}", promedio);
            Console.WriteLine("La calificacion minima es: {0}", calificacionMinima);
            Console.WriteLine("La calificacion maxima es: {0}", calificacionMaxima);

            ///matrices 
            //la primera coordenada corresponde a las filas y la siguiente a la columna

            //configuracion  de las matrices 
            //tipo[,] nombre = new tipo[filas, columns]

            int v = 4;
            int b = 3;
            double[,] calificaciones3 = new double[v, b];

            //how to assing dates 
            calificaciones3[2, 1] = 9.0;
            Console.WriteLine(calificaciones3[2, 1]);

            calificaciones3[0, 2] = 7.0;
            Console.WriteLine(calificaciones3[0 , 2]);

            calificaciones3[3,0] = calificaciones3[2, 1]* calificaciones3[0, 2];
            Console.WriteLine(calificaciones3[3,0]);


            //exercie of array of two dimensions
            
            for(int n = 0; n < 3; n++)
            {
                for(int j = 0; j < 4; j ++)
                {
                    Console.WriteLine("room {0}, Alumn {1}", n, j);
                }
                Console.WriteLine();
            }

        }
    }
}
