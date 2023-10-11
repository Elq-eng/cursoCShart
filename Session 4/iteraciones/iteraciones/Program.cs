using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*ITERACIONES
 *RESUMEN: se muestra cada una de los espacios del for, en que momento aplicarlo, y mirar la asignacion compuesta
 * ELQUIN CASCAVITA RIOS 
 * VERSION .NET 4.7.2
 */

namespace iteraciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //ITERACION FOR 
            double calif1, calif2, calif3, promedio;

            //ingresar la nota del primer alumno 
            Console.Write("dame la califacion del primer alumno: ");
            calif1 = double.Parse(Console.ReadLine());

            //ingresar la nota del segundo alumno 
            Console.Write("dame la califacion del primer alumno: ");
            calif2 = double.Parse(Console.ReadLine());

            //ingresar la nota del tercer alumno 
            Console.Write("dame la califacion del primer alumno: ");
            calif3 = double.Parse(Console.ReadLine());


            //sumar las notas
            promedio = (calif1 + calif2 + calif3) / 3;

            //mostrar el promedio 
            Console.WriteLine("El promedio que se tiene de los alumnos es: {0}", promedio);

            //cambiar esto por for 

            //variable de bulce 
            //int i;

            for(int i = 1; i <= 10; i++)//inicializador, condicion,iterador 
            {
                Console.WriteLine(i);
            }

            //declaracion e inicializacion de una variable
            //una instruccion de asignacion 

            //asignacion compuesta
            int x = 2;

            //sumar acumulacion 
            x = x + 5;

            //nuevo formato

            x += 25;

            Console.WriteLine(x);


            //aplicar asignacion compuesta en el for

            for (int i = 1; i <= 10; i+=2)//inicializador, condicion,iterador 
            {
                Console.WriteLine(i);
            }

            //el contador siempre se inicia en 0
            int contador = 0;

            //acumulador 

            int acumulador = 0,precio;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ingrese el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());

                acumulador = acumulador + precio; //o se peude hacer acumulador += precio; 
            }

            Console.WriteLine("El total es: {0}", acumulador);

        }
    }
}
