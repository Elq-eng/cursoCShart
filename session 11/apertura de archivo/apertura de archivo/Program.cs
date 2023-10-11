using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace apertura_de_archivo
{
    class Program
    {
        static void Main(string[] args)
        {

            //arreglo de bytes 
            byte[] recibeInformacion = new byte[100];

            string nombreArchivo = "";

            Console.Write("Dame el nombre del archivo a abrir: ");

            nombreArchivo = Console.ReadLine();

            //creacion del stream para lectura
            FileStream fs = new FileStream(nombreArchivo + ".txt", FileMode.Open);

            //leer el contenido del archivo

            fs.Read(recibeInformacion, 0, (int)fs.Length);

            //mostrar el contenido 
            Console.Write(ASCIIEncoding.ASCII.GetString(recibeInformacion));

            //cerramos el stream 
            fs.Close();
        }
    }
}
