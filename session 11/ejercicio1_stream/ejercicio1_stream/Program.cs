using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Ejercicio del stream
 * Resumen:
 * Elquin Cascavita
 * version .net 4.7.2
 * 
 */
namespace ejercicio1_stream
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos el Stream
            MemoryStream ms = new MemoryStream(70);

            //cadena para el Stream
            String cadenaStream = "";

            //variables restantes
            int capacidad = 0;
            long longitd = 0;
            long posicion = 0;

            //arreglo 
            byte[] buffer = new byte[70];

            //peticion de la cadena al usuario 
            Console.Write("Dame la cadena para usar en el flujo: ");
            cadenaStream = Console.ReadLine();

            ms.Write(ASCIIEncoding.ASCII.GetBytes(cadenaStream),0, cadenaStream.Length);

            capacidad = ms.Capacity;
            longitd = ms.Length;
            posicion = ms.Position;

            //mostramos la informacion
            Console.WriteLine("Capacidad: {0}, longitud {1}, posicion: {2}", capacidad, longitd, posicion);

            //nos estamos ubicando a cero distancia del inicio
            ms.Seek(0, SeekOrigin.Begin);
            ms.Read(buffer, 0, 7); //posicion donde nos encontramos , leemos 7 bytes 

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));

            ms.Seek(5, SeekOrigin.Begin); // no ubicamos en un punto de l posicion 5 
            ms.Read(buffer, 0, 6);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));


            //AHORA UBICAMOS EL PUNTERO EN LA POSICION FINAL 
            ms.Seek(-17, SeekOrigin.End);
            ms.Read(buffer, 0, 8);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(buffer));


            //cerramos el flujo 
            ms.Close();
        }
    }
}
