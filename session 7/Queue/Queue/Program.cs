using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*Queue
 * Resumen: es una coleccion que almacena y deja salir segun como una pila fifo, con Queue.
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace Queue_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //queue son de configuracion fifo, 
            //declaracion de queue

            Queue fila = new Queue();

            //agregar elementos al queue
            fila.Enqueue(8);

            //para observar el elemento 

            var valor = fila.Peek();
            Console.WriteLine(valor);

            //extraer elemntos- este lo extrae y lo elmina del vector
            //var valor1 = fila.Dequeue();

            //saber si un elemento x esta dentro del queue
            if (fila.Contains(8) == true)
            {
                Console.WriteLine("El elemento existe");
            }

            //para eliminar todos los elementos 
            fila.Clear();

            //conocer la cantidad de elementos en el queue
            int conteo = fila.Count;

            //mostrar los elementos
            foreach(int n in fila)
            {
                Console.WriteLine("{0} ", n);
            }
        }
    }
}
