using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Explicacion de while 
 * Resumen: Ejercicio de while
 * Elquin Cascavita
 * Version .net 4.7.2
 */
namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {

            byte numero = 1; 

            while ( numero <= 10)
            {
                Console.WriteLine(numero);
                numero += 1;
            }

            //ejercicio de contraseñas 

            string contraseña, contraseña2 = "";

            //ingresar contraseña

            Console.Write("Escribe tu contraseña: ");
            contraseña = Console.ReadLine();

            while (contraseña != contraseña2)
            {
                Console.Write("Confirma tu contraseña: ");
                contraseña2 = Console.ReadLine();
            }

            Console.WriteLine("¡Contraseña guardada!");


        }
    }
}
