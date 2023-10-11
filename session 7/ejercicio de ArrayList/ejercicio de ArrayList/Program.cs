using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio de ArrayList
 * Resumen:  
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace ejercicio_de_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables que vamos a utilizar
            int indice = 0,cantidad = 0;

            //declaracion del ArrayList "datos"
            ArrayList datos = new ArrayList();

            //Agregamos valores a nuestro ArrayList "Datos"
            datos.Add(7);
            datos.Add(5);
            datos.Add(1);

            Console.WriteLine("Mostramos los valores iniciales del Arraylist: ");
            Imprime(datos);

            //Adicionamos más elementos al ArrayList haciendolo creceer
            datos.Add(4);
            datos.Add(5);

            //obtenemos el indice
            indice = datos.Add(10);

            Console.WriteLine("Despues de agregar mas elementos: ");
            Imprime(datos);
            Console.WriteLine("El ultimo elemento tiene el indice de: {0}", indice);
            Console.WriteLine("\n.................");

            //imprimir un elemento en particular 
            Console.WriteLine("El valor en el indice 2 es de: {0}", datos[2]);
            Console.WriteLine("\n.................");

            //modificamos un dato 
            datos[3] = 55;
            Console.WriteLine("Despues de modificar el dato: ");
            Imprime(datos);

            //obtenemos la cantidad de los elementos 
            cantidad = datos.Count;
            Console.WriteLine("La cantidad de elementos en el array es: {0}", cantidad);

            //insertamos un elemento en una posicion en particulas
            datos.Insert(2, 88);
            Console.WriteLine("despues de usar la funcion Insert:");
            Imprime(datos);

            //eliminando un elemento 
            datos.RemoveAt(4);
            Console.WriteLine("Despues de eliminar un elemento en la posicion 4");
            Imprime(datos);

            //encontramos el indice donde se encuentra el primer numero 5
            indice = datos.IndexOf(5);
            Console.WriteLine("despues de buscar el primer numero 5 esta en la posicion {0}", indice);
            




        }//se terminar el main principal
        static void Imprime(ArrayList arreglo)
        {

            foreach(int n in arreglo)
            {
                Console.Write("{0}, ", n);
            }
            Console.WriteLine("\n.................");

        }//se termina el método de Imprime
    }
}
