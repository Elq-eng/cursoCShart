using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lectura_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            //preguntaos el nombre del usuario 
            Console.Write("Como te llamas ");
            nombre = Console.ReadLine();

            //saludamos al usuario 
            Console.WriteLine("Hola {0} es un placer", nombre);
        }
    }
}
