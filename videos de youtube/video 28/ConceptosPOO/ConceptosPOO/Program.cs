using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;

/*Conceptos POO
 * resumen: se utiliza el cometario //TODO: para especificar donde se quedo el programador, nomenclatura, se agrega una clase en la solucion llamada punto, ademas se trabaja las clases anonimas que son utilizadas en simplificar el codigo,ahorrar lineas de codigo, y cuando se agregar las query
 * Elquin Cascavita Rios
 * version 4.7.2 .net
 */
namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //se llama el metodo realziar tarea
            //realizarTarea();

            //clases anonimas
             var miVariable = new { Nombre = "Juan", Edad = 19 };
            WriteLine(miVariable.Edad);

            var miOtraVariable = new { Nombre = "ana", edad = 25 };
        }
        static void realizarTarea()
        {
            Punto origen = new Punto();

            Punto destino = new Punto(3445, 23423);

            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine("La distanncia entre los dos puntos es: {0}",distancia);


            //solo se uede llamar la clase 
            Console.WriteLine("Numero de objetos creados: {0}", Punto.ContadorObjetos());
        }
    }
}
