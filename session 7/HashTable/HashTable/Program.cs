using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

/*Hashtable
 * Resumen: se hace una neueva coleccion que se quiere mirar como funciona
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace HashTable_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //el hashtable tiene una un indicador o identificador llamado key

            Hashtable tabla = new Hashtable();

            //afregar elementos 
            //Add() key-value
            tabla.Add("Iphone", 3000);
            tabla.Add("Huawei", 7687);
            tabla.Add("Refresco", 26.24);

            //recorrer el hashtable -DictionaryEntry

            foreach (DictionaryEntry datos in tabla)
                Console.WriteLine("key->{0}, value->{1}", datos.Key, datos.Value);

            ICollection valores = tabla.Values;

            
           // foreach (double valor in valores)
             //   Console.WriteLine("valor -> {0}", valor);

            //para borrar 
            //tabla.Clear();



            //encontrar key

            bool encontrado;
            encontrado = tabla.Contains("Huawei");

            Console.WriteLine(encontrado);

            //encontrar un value

            encontrado = tabla.ContainsValue(293874);

            Console.WriteLine(encontrado);

            //Saber cuantas cantidad de parejas hay en e hashtable

            int cantidad;

            cantidad = tabla.Count;
            Console.WriteLine(cantidad);

            //eliminar un elemento de hashtable
            //se necesita saber el key
            tabla.Remove("Iphone");
            cantidad = tabla.Count;
            Console.WriteLine("Hola {0}",cantidad);
        }
    }
}
