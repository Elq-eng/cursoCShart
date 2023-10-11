using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Stream (Flujos)
 * Resumen:
 * Elquin Cascavita Rios 
 * Version 4.7.2 .net
 * 
 */ 
namespace stream
{
    class Program
    {
        static void Main(string[] args)
        {
            //para mover datos a otro lugar por ejemplo (disco duro) 

            //variable 
            int size = 30, capacity;
            long longitud = 0;
            long posicion = 0;

            MemoryStream ms = new MemoryStream(size);//tamaño del stream

            //datos que se obtiene del stream

            //tamaño del stream

            capacity = ms.Capacity;
            Console.WriteLine("La capacidad del stream es de {0}", capacity);

            //conocer la longitud del stream 
            longitud = ms.Length;
            
            Console.WriteLine("La longitud del stream es de {0}", longitud);

            //conocer la posicion del byte de que esta siendo procesado
            posicion = ms.Position;


            Console.WriteLine("La posicion del byte actual dentro del stream es {0}", posicion);

            //colocar laposicion actual en un sitio determinado seek(), seekOrigin(Begin, Current, end)
            //el 0 la distancia desde el punto de referencia de donde va a quedar la nueva posicion del stream 
            ms.Seek(6,SeekOrigin.Begin);


            //lectura del byte READ(arreglo,capacidad del offset, cantidad de byte de que se va a leer)

            byte[] buffer = new byte[30];

            ms.Read(buffer,0,7);

            //escribir write(arreglo, inicia,fin)
            ms.Write(buffer, 0, 7);

            //metodo close, si el stream es cerrado no se puede hacer nada 

            ms.Close();



        }
    }
}
