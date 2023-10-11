using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Operadores de igualdad, operadores de comparacion 
 Resumen: se muestra un poco de los operadores logicos que se pueden usar en c#
Elquin Cascavita 
.Net 4.7.2
 */
namespace operadores_de_igualdad
{
    class Program
    {
        static void Main(string[] args)
        {
            // operadores de Igualdad
            //igualdad
            Console.WriteLine(6 == 6);

            //Desigualdad 
            int a = 5, b = 6;
            Console.WriteLine(b != a);

            //operadores de comparacion 

            //menor que 
            Console.WriteLine(b < a);

            //mayor que 
            Console.WriteLine(b > a);

            //mayor o igual 
            Console.WriteLine(b >= a);

            //menor que  o igual 
            Console.WriteLine(b <= a);
        }
    }
}
