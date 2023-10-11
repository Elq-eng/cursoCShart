using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Arrays
 * Resumen= se hace la manipualcion de array que entran como parametros y se devuelven como un array.
 * Elquin Cascavita Rios
 * version 4.7.2
 */
namespace Array_por_parametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];

            numeros[0] = 7;
            numeros[1] = 8;
            numeros[2] = 3;
            numeros[3] = 4;

            ProcesaDatos(numeros);
            foreach(int n in numeros)
            {
                Console.WriteLine(n);
            }

            //cuadno se llama un metodo con retorno de array 

            //se crea el array 
            int[] arrayElementos = LeerDatos();
            Console.WriteLine("Imprimiendo desde el main");

            //se imprime el array retornado
            foreach (int n in arrayElementos)
            {
                Console.WriteLine(n);
            }

        }
        static void ProcesaDatos(int [] datos)
        {

            for(int i = 0; i <datos.Length; i ++)
            {
                datos[i] *= 10;
            }
        }

        static int[] LeerDatos()
        {
            //input
            int input;
            int datosElemento;

            //entradas del usuario
            Console.WriteLine("cuantos elementos quiere que tenga el array");
            input = Convert.ToInt32(Console.ReadLine());

            int[] datos = new int[input];

            for (int i = 0; i < datos.Length; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion {i}");

                datosElemento = int.Parse(Console.ReadLine());

                datos[i] = datosElemento;

            }
            return datos;
        }
    }
}
