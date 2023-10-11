using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ejercicio de poligonos
 * Resumen: En este script se realiza el calculo del perimetro de cualquier poligono regular, teniendo en cuenta dos entradas del usuario
 * Elquin Cascavita Rios
 * .NET VERSION 4.7.2
 */

namespace ejercicio_de_poligonos
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            double lados, longitud, perimetro;

            //SE LE PIDE AL USUARIO INGRESAR EL NUMERO DE LADOS QUE TIENE EL POLIGONO 
            Console.Write("Ingresar El numero de lados que tiene el poligono regular: ");
            lados = Double.Parse(Console.ReadLine());

            //SE LE PIDE AL USUARIO INGRESA LA LONGITUD DE LOS LADOS
            Console.Write("Ingresar la longitud de cada lado que tiene el poligono regular: ");
            longitud = Double.Parse(Console.ReadLine());

            //calcular perimetro 
            perimetro = lados * longitud;

            Console.WriteLine("El perimetro del poligono de {0} lados es: {1} ", lados, perimetro);
        }
    }
}
