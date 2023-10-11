using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Finally
 * Resumen: el cierre de base de datos se pone en finally, cierre de ficheros
 * Elquin Cascavita 
 * version 4.7.2
 */

namespace finally_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader archivo = null;

            try
            {
                string linea;
                int count = 0;
                string path = @"C:\Users\Elkin\Desktop\prueba.txt";

                archivo = new StreamReader(path);

                //lectura
                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    count += 1;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }

            finally
            {
                //siempre cerrar algo,
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexion cerrada");
            }

        }
    }
}
