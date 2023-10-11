using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*exercie jagged
 * Resumen: it is done the design of some alumn in different class room 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace exercie_jagged
{
    class Program
    {
        static void Main(string[] args)
        {

            int salones = 0, alumnos = 0;

            //order the amount of class room
            Console.Write("Give me the amount of class room ");
            salones = int.Parse(Console.ReadLine());

            //create the array jagged

            double[][] calificaciones = new double[salones][];

            Console.WriteLine();
            //order the alumns for each class room 
            for(int i =0; i < salones; i++)
            {
                Console.WriteLine("Class room {0}", i+1);
                Console.Write("Give me the amount of alumns: ");
                alumnos = Int32.Parse(Console.ReadLine());

                //asignar los alumnos (instanciar el arreglo)
                calificaciones[i] = new double[alumnos];
            }

            //shhow the size of each array inside of the container array
            /*Console.WriteLine("Show me the dimension of the index 0: {0}", calificaciones[0].GetLength(0));
            Console.WriteLine("Show me the dimension of the index 1: {0}", calificaciones[1].GetLength(0));
            Console.WriteLine("Show me the dimension of the index 2: {0}", calificaciones[2].GetLength(0));
            */

            Console.WriteLine();
            //recorrer the array
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Class room {0}", i + 1);
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Give me the calification of the alumn {0}: ", j + 1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //mostrar la informacion
            Console.WriteLine("\n\ninformacion\n");
            for (int i = 0; i < salones; i++)
            {
                Console.WriteLine("Class room {0}", i + 1);
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.WriteLine("El alumno {0}, tiene {1} de califiaciiones ", j + 1, calificaciones[i][j]);
                }
            }

            Console.WriteLine();
            //calculate of the average
            Average(calificaciones);

            Console.WriteLine();
            //calculate the value minimun
            ValueMin(calificaciones);

            Console.WriteLine();
            //calculate the value maximun
            ValueMax(calificaciones);

        }
        static void Average(double [][] arrayAverage)
        {
            double average = 0.0, sum = 0.0;

            //cicle "for" to do the average
            for(int i = 0; i < arrayAverage.Length; i++)
            {               
                Console.WriteLine("Class room {0}", i + 1);
                for (int j = 0; j < arrayAverage[i].GetLength(0); j++)
                {
                    sum += arrayAverage[i][j];
                }
                average = sum / arrayAverage[i].GetLength(0);
                Console.WriteLine("The Class room has a average de {0}", average);
                average = 0.0;
                sum = 0.0;
            }
        }

        static void ValueMin(double[][] arrayAverage)
        {
            //variables
            double valueMin = 10.0;
            //find value minimun
            for (int i = 0; i < arrayAverage.Length; i++)
            {
                Console.WriteLine("Class room {0}", i + 1);
                for (int j = 0; j < arrayAverage[i].GetLength(0); j++)
                {
                    if (arrayAverage[i][j] < valueMin)
                    {
                        valueMin = arrayAverage[i][j];
                    }
                }
                valueMin = 10.0;
                Console.WriteLine("The Class room has a value minimun of: {0}", valueMin);
            }
            
        }
        
        static void ValueMax(double[][] arrayAverage)
        {
            //variables
            double valueMax = 0.0;
            //find value minimun
            for (int i = 0; i < arrayAverage.Length; i++)
            {
                Console.WriteLine("Class room {0}", i + 1);
                for (int j = 0; j < arrayAverage[i].GetLength(0); j++)
                {
                    if (arrayAverage[i][j] > valueMax)
                    {
                        valueMax = arrayAverage[i][j];
                    }
                }
                Console.WriteLine("The Class room has a value maximun of: {0}", valueMax);
                valueMax = 0.0;
            }

        }
    }
}
