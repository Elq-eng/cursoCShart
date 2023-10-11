using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Ejercicio de calificaciones
 * Resumen
 * Elquin Cascavita
 * Version 4.7,1
 */
namespace ejericio_for
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio de calificaciones 
            //variables 
            byte i, numAlumnos;
            double calificacion, sumCalif = 0, promedio;

            Console.Write("Ingrese el numero de alumnos: ");
            numAlumnos = Byte.Parse(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingrese la calificacion: ");
                calificacion = Double.Parse(Console.ReadLine());

                //sumar calidicaciones
                sumCalif = sumCalif + calificacion;

            }

            //Calculamos el promedio
            promedio = sumCalif / numAlumnos;

            //mostramos el promedio

            Console.WriteLine("el promedio es {0} ", promedio);

            // ejercicio 2
            //hallar el factorial de un numero 


            ulong i2, numero, factorial = 1;

            Console.Write("Ingresar el número para hallar el factorial: ");
            numero = ulong.Parse(Console.ReadLine());

            for (i2 = numero; i2 >= 1; i2--)
            {
                factorial = factorial * i2;
            }

            Console.WriteLine("El factorial del numero {0} es: {1}", numero, factorial);
        }
    }
}
