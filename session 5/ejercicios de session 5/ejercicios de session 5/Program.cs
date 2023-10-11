using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicios de tareas en session 5
 * Resumen:
 * Elquin Cascavita Rios
 * version 4.7.2
 */

namespace ejercicios_de_session_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear una tupla para mirar el resultado del calculo
            (double grade,double result) calculo;

            //método de grados a radianes
            calculo = Gra_Rad();

            Console.WriteLine("De {0} grados a {1} resultado", calculo.grade, calculo.result);
        }

        static (double,double) Gra_Rad()
        {
            //variables
            double grados,resultado;
            var pi = (Math.PI);

            //
            Console.WriteLine("Ingrese el valor en grados para hacer transoformala a radianos :");
            grados = Byte.Parse(Console.ReadLine());

            //calculo 
            resultado =  pi/180 * grados;


            return (grados, resultado);
        }
    }
}
