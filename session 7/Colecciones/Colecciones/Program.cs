using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colecciones;
/*Colecciones
 * Resumen: para las colecciones se debe poner un namespace using colecciones, una de estas colecciones es arraylist, y sus prpiedades son conteo y capacidad
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //como declarar un arraylist instanciar 
            //ArrayList Nombre = new ArrayList();
            ArrayList miArraylist = new ArrayList();

            //agregar informacion al arraylist
            miArraylist.Add(10);
            miArraylist.Add(3);

            miArraylist.Add(5);

            Console.WriteLine(miArraylist[1]);

            miArraylist[1] = 80;

            Console.WriteLine(miArraylist[1]);

            //para insertar un dato en el array en alguna posicion se ponte .insert(posicion, dato)
            miArraylist.Insert(1, 5);
            Console.WriteLine(miArraylist[1]);

            //para insertar un dato en el array en alguna posicion se ponte .RemoveAt(posicion)
            miArraylist.RemoveAt(1);
            Console.WriteLine(miArraylist[1]);

            //para buscar un elemento en el array se utiliza el indexOf y devuelve un valor entero que e sla posicion donde se encuentra lo que se esta buscando

            int indice = miArraylist.IndexOf(80);
            Console.WriteLine("indice donde esta guardado el 80 es {0}",indice);

            //iterado foreach
            //configurador de foreach
            //foreach (tipo identificador in expresion(arreglo)){}

            foreach(int valor in miArraylist)
            {
                Console.WriteLine("El valor es de: {0}", valor);
            }
        }
    }
}
