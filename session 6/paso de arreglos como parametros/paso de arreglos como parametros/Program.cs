using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*exercie jagged
 * Resumen: 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace paso_de_arreglos_como_parametros
{
    class Program
    {
        

        static void Main(string[] args)
        { //double [] arreglo
          //nombre del método(arreglo)
            int a = 1;
            int b = 8;
            int c = 4;

            do
            {
                a = a * 2;
            }
            while (a <= b);
           Console.WriteLine(a);
            //declarar un arra 
            double[] calificaciones = new double[4];

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.Write("Give me the calification: ");
                calificaciones[i] = Double.Parse(Console.ReadLine());
            }

            ImprimirArreglo(calificaciones);
            AverageArreay(calificaciones); 

        }//close main 

        //cofiguracion de un metodo con array 
        //static void Nombre(tipo [] Nombre)

        //metodo 
        static void ImprimirArreglo(double[] arregloRecibe)
        {
          for(int i = 0; i < arregloRecibe.Length; i++)
            {
                Console.WriteLine("The grade is: {0}", arregloRecibe[i]);
            }

        }

        static void AverageArreay(double[] arregloPromedio)
        {
            double sumGrade = 0.0;
            double average = 0.0;

            for(int i = 0; i < arregloPromedio.Length; i ++)
            {
                sumGrade += arregloPromedio[i];
            }
            average = sumGrade / arregloPromedio.Length;
            Console.WriteLine("The average is: {0}", average);
        }
    }
}
