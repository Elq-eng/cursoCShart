using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Constantes
 * Resumen: el nombre de las constantes siempre estan en mayusculas
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //para determinar variables constantes 
            const int VALOR = 5, VALOR2 = 7;

            Console.WriteLine("El valor de la constantes es: {0}",VALOR);


            //ejercicio de area,
            //variables
            const double PI = 3.1416;
            double radio,area;

            //inputs
            Console.WriteLine("Introduce la medida del radio");
            radio = Convert.ToDouble(Console.ReadLine());

            //process 
            area = Math.Pow(radio, 2) * PI;

            Console.WriteLine("El área del circulo es: {0}", area);

            
        }
    }
}
