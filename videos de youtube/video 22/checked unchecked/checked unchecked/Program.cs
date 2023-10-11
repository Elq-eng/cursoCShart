using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*checked unchecked
 * resumen
 * Elquin Cascavita 
 * version 4.7.2 .net
 */
namespace checked_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //la idea del checked es que compruebe esta compilacion 
            // para saltarse una excepcion se usa el unchecked
            //uno puede obligar a crear una exepcion
            
                int numero = int.MaxValue;

                int resultado = checked(numero + 20);

                Console.WriteLine(resultado);
            
        }
    }
}
