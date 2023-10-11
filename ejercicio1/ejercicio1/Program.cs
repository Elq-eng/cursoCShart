using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Ejercicio 1
 * resumen: se hizo la division del problema en subproblemas, luego pseudocodigo, se hace el digrama de flujo, por ultimo el algoritmo.
 * Elquin Cascavita
 * Version .net 4.7.2
 
 */

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///// Realizar un progra,a de computadore que haga el calculo del area y preimtro de un rectangulo
            ///
            //variables 
            double altura, ancho, area, perimetro;

            //pedimos la altura  convertimos a tipo double 
            Console.Write("Dame la altura: ");
            altura = Double.Parse(Console.ReadLine());

            //pedimos la base convertimos a tipo double 
            Console.Write("Dame la base: ");
            ancho = Convert.ToDouble(Console.ReadLine());

            //calculo del área
            area = altura * ancho;

            //calculo del perimetro 
            perimetro  = 2 * (altura + ancho); 

            //mostrar en pantalla el area y el perimetro 

            Console.WriteLine("El área del rectagunlo {0} y el perimetro es {1}", area, perimetro);

        }
    }
}
