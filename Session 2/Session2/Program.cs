using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Precalentar Horno");
            Console.WriteLine("2. Mezclar harina y mantequilla");
            Console.WriteLine("3. Agregar azúcar y 1 huevo");
            Console.WriteLine("4. Amasar la mezcla");
            Console.WriteLine("5. Darles forma y colocar en charola");
            Console.WriteLine("6. Hornear durante 10 min");


            //Declaracion de variables enteras
            int numeroLibros, librosNiños = 100, librosMatematicas = 200;

            //Declaro una variable de tipo double y asigno valor
            double promedioFinal = 9.8;

            numeroLibros = 500; //Asigno el valor de 500 

            /* asi es un bloque de comentario 
             */
            char salon;
            salon = 'A';

            String saludo = "Hola";

            bool x = false;

            decimal prmedioExamenes = 8.5M;

            float promedioExa = 8.5F;

            //Mostrar valores en la consola
            string saludo2 = "Hola";


            Console.WriteLine(saludo2);

            //cadena de formato,
            double precioCamisa = 399;
            string colorCamisa = "Azul";
            Console.WriteLine("precio de la camisa es: {0}y su color es: {1}", precioCamisa, colorCamisa);
            Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

        }
    }
}
