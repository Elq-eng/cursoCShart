using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Bucle While
 * Résumen: explicar lo que es while
 * Elquin Cascavita
 * Version 4.7.2 .net
 * 
 */
namespace bucle_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            string answer,name;

            //input
            Console.WriteLine("Deseas entrar en el bucle while?");
            answer = Console.ReadLine();


            //proceso
            while(answer != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle while");

                Console.WriteLine("Introduce tu nombre, por favor");
                name = Console.ReadLine();

                Console.WriteLine("Saldras del bucle {0} cuando respondas no!", name);
                Console.WriteLine("¿Deseas repetir otra vez?");

                answer = Console.ReadLine();

            }

            Console.WriteLine("Has salido del bucle");
        }
    }
}
