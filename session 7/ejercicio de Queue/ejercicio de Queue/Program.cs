using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ejercicio Queue
 * Resumen: 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace ejercicio_de_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            //creamos Queue

            Queue fila = new Queue();

            do
            {
                //menu 
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Salir");

                //opcion 
                Console.Write("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        //pedir el valor 
                        Console.Write("Dame el valor a introducir el queue: ");
                        numero = Convert.ToInt32(Console.ReadLine());

                        //agragar el valor
                        fila.Enqueue(numero);
                        break;
                    case 2:
                        //obtener el elemento
                        numero = (int)fila.Dequeue();

                        //mostrar elemento
                        Console.WriteLine("El valor extraido es : {0}", numero);
                        break;
                    case 3:

                        fila.Clear();
                        break;
                    case 4:

                        Console.Write("Dame el valor que quieres encontrar: ");
                        numero = int.Parse(Console.ReadLine());

                        //verificar que el elemento este 
                        encontrado = fila.Contains(numero);

                        //mostrar el resultado
                        Console.WriteLine("Elemento encontrado = {0}", encontrado);
                        break;
                    case 5:
                        break;

                        
                        
                }
                //Mostrar la informacion
                Console.WriteLine("El Queue tiene {0} elementos", fila.Count);
                foreach (int n in fila)

                Console.Write("{0},", n);
                Console.WriteLine("");
                Console.WriteLine("......");

            } while (opcion != 5);

        }// cierre main
    }
}
