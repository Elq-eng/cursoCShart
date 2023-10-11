using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Marices ejercicio
 * abstract: show how is declare the variables, how assign values in matrices 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare of the class room 
            int salones = 0;
            int alumnos = 0;
            //variables
            double suma = 0.0;
            double promedio = 0.0;

            double calMinima = 10.0;
            double calMaxima = 0.0;

            //order the amount of class room
            Console.Write("Give me the amount of class room: ");
            salones = Convert.ToInt32(Console.ReadLine());
            //order the amount of alumns
            Console.Write("Give me the amount of alumns for class room : ");
            alumnos = Convert.ToInt32(Console.ReadLine());


            //we create the array 
            double[,] calificaciones = new double[salones,alumnos];

            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("We are in the class room: {0}", i+1);
                for (int j = 0; j < alumnos; j++)
                {
                    Console.Write("Give me the calification of the alumn {0}: ", j+1);
                    calificaciones[i,j] = Double.Parse(Console.ReadLine()); ;
                }
               
            }

            //Calcule the average

            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < alumnos; j++)
                {
                    suma += calificaciones[i, j];
                }

            }

            promedio = suma / (salones * alumnos);

            //calification minimum
            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < alumnos; j++)
                {
                    if (calificaciones[i,j] < calMinima)
                    {
                        calMinima = calificaciones[i, j];
                    }
                }

            }

            //calification maximun
            for (int i = 0; i < salones; i++)
            {
                for (int j = 0; j < alumnos; j++)
                {
                    if (calificaciones[i, j] > calMaxima)
                    {
                        calMaxima = calificaciones[i, j];
                    }
                }

            }

            //mshow the results
            Console.WriteLine("The average is: {0}", promedio);
            Console.WriteLine("The note minimun is: {0}", calMinima);
            Console.WriteLine("The note maximun is: {0}", calMaxima);

        }
    }
}

/*
  
 * 
*/
