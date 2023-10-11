using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*ejercicio Hashtable
 * Resumen: 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace Ejercicio_hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 
            int opcion = 0;
            bool encontrado = false;
            string llave = "";
            double precio = 0;

            Hashtable tabla = new Hashtable();

            do
            {
                //menu 
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Quitar elemento");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Encontrar key");
                Console.WriteLine("5. Encontrar value");
                Console.WriteLine("6. salir");

                Console.Write("Escoge una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        //se agregan los valores
                        Console.Write("Dame el nombre del producto: ");
                        llave = Console.ReadLine();

                        Console.Write("Dame el precio del producto: ");
                        precio = Double.Parse(Console.ReadLine());

                        tabla.Add(llave, precio);
                        break;
                    case 2:

                        //nombre del producto que se quiere eliminar 
                        Console.Write("Dame el nombre del prodcto que quieres eliminar: ");

                        llave = Console.ReadLine();

                        tabla.Remove(llave);
                        break;
                    case 3:

                        //limpiamos el hashtable
                        tabla.Clear();

                        break;
                    case 4:
                        //pedimos el key que se quiere encontrar 
                        Console.Write("Dame el key que quieres encontrar: ");
                        llave = Console.ReadLine();

                        encontrado = tabla.Contains(llave);
                        //mostrar si se encontro
                        Console.WriteLine("Elmento encontrado = {0}", encontrado);

                        break;

                    case 5:
                        //pedimos el key que se quiere encontrar 
                        Console.Write("Dame el value que quieres encontrar: ");
                        precio = Double.Parse(Console.ReadLine());

                        encontrado = tabla.ContainsValue(precio);
                        //mostrar si se encontro
                        Console.WriteLine("Elmento encontrado = {0}", encontrado);

                        break;
                    
                    

                }

                //mostrar la informacion
                Console.WriteLine("El hashtable tiene {0} parejas de key-value", tabla.Count);

                foreach (DictionaryEntry datos in tabla)
                    Console.WriteLine("[{0},{1}]\t", datos.Key, datos.Value);
                Console.WriteLine("");
                Console.WriteLine("....");


            } while (opcion != 6); 
        }
    }
}
