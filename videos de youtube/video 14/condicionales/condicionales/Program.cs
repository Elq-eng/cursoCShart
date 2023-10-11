using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Condicionales
 * Resumen
 * Elquin Cascavita Rios
 *Version 4.7.2 .net
 * 
 */


namespace condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJEMPLO I

            //variables
            int edad, compara;
            string carnet= "No";

            //algoritmo
            Console.WriteLine("Vamos a evaluear su puedes conducior un vehiculo");

            //entradas
            Console.WriteLine("Introduce tu edad, por favor");
            
            edad = Convert.ToInt32(Console.ReadLine());

            //condicionales
            if (edad < 18) Console.WriteLine("No puedes conducir vehiculos");
            else
            {
                Console.WriteLine("¿Tienes carnet?");
                carnet = Console.ReadLine();

                compara = String.Compare(carnet, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");
                else Console.WriteLine("Lo sient mucho no puedes conducir");
                
            }


            //EJEMPLO II

            //variables
            double parcial1, parcial2, parcial3;

            //proceso
            Console.WriteLine("Introduce el primer parcial");
            parcial1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo parcial");
            parcial2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer parcial");
            parcial3 = double.Parse(Console.ReadLine());

            if (parcial1 > 5 || parcial2 > 5  ||  parcial3 > 5)
                Console.WriteLine("La nota media es: {0}",((parcial3+parcial2+parcial1)/3));
            else Console.WriteLine("Vuelve en septiembre");

        }
    }
}
