using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio de temperaturas
 * Resumen: En este script se va hacer la transformacion de °C a °F
 * Elquin Cascavita Rios
 * Version .Net 4.7.2
 */
namespace transformacion_de_centigrados_a_F
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            double temperaturaC, temperaturaF;

            //se le pide al usuario ingresar la temepratura en °C
            Console.Write("Ingrese la temperatura actual en °C: ");
            temperaturaC = Convert.ToDouble(Console.ReadLine());

            temperaturaF = (temperaturaC * 9 / 5) + 32;

            Console.WriteLine("La temperatura en Fahrenheit es : {0}", temperaturaF);

        }
    }
}
