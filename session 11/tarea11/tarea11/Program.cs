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
namespace tarea11
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombreArchivo = "";
            string cadena = "";
            string ubicacionArchivo= "";

            Console.Write("Dame la ubicacion del archivo: ");
            ubicacionArchivo = Console.ReadLine();

            Console.Write("Dame el nombre del archivo: ");
            nombreArchivo = Console.ReadLine();

            


            //Creando el FileStream 

            FileStream fs = new FileStream(ubicacionArchivo + "\\" + nombreArchivo + ".doc", FileMode.Append);

            //cadena para introducir en el archivo
            Console.Write("Dame la cadena que quieres introducir en el archivo: ");
            cadena = Console.ReadLine();

            fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);


        }
    }
}
