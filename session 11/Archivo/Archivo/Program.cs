using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*Archivo stream
 * resumen 
 * Elquin cascavita
 * Version 4.7.2
 * 
 */

namespace Archivo
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio de cadenas donde la consola le pide al usuario agregar cadenas.
            //declaracion de cadena
            string cadena = "", nombreArchivo = "";

            Console.Write("Dame el nombre del archivo: ");
            nombreArchivo = Console.ReadLine();

            FileStream fs = new FileStream(nombreArchivo + ".txt",FileMode.Create);

            //consola aparece
            Console.WriteLine("Escribir a continuacion la infromacion que tendra el archivo: ");
            do
            {
                Console.WriteLine("\t");
                //leyendo la cadena
                cadena = Console.ReadLine();
                //escribimos al stream la cadena 
                fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);


            } while (cadena != "");


            


            //cerrar el archivo 
            fs.Close(); 

            /*
            //agregar algo escrito
            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);

            */

            
        }
    }
}



//tarea 