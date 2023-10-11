using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Asignacion implicita
 * Resumen: 
 * Elquin Cascavita Rios 
 * Version .net 4.7.2
 * 
 */
namespace Asignacion_implicita
{
    class Program
    {
        static void Main(string[] args)
        {

            //asignacion de variable implicita
            var nombre = "Luis";
            var numero = 10;
            var calificacion = 6.5;
            var letra = "A";

            //Tupla 

            byte edad = 25;
            long numero2 = 353434;
            int dirPostal = 002222;

            //sintaxis 
            //(tipo) identificador = (valor);
            (string nombre, byte edad,long numero2, int dirPosal) persona1 = ("luis", 25, 35324234,79933739);
            var persona2 = (nombre: "PEPE", edad: 50, numero: 35324234, dirPostal: 79933739);

            //mostrar una tupla 
            //mostrar todo
            Console.WriteLine(persona1);


            //mostrar cada uno por item
            Console.WriteLine(persona1.nombre);
            Console.WriteLine(persona2.nombre);

        }
    }
}
