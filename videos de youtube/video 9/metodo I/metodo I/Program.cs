using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Metodos
 * Resumen: se puede hacer por ref o out para cuando se quiere aplicar los valores y hacer la modificaicion, 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */
namespace metodo_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int resultado;

            //invocacion del método
            mensajeEnPantalla();
            Console.WriteLine("Mensaje desde el main");

            //second method
            resultado = sumaNumero(3, 4);

            Console.WriteLine("El resultado de la suma es: {0}",resultado);
        }//end main


        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensajeEnPantalla");
        }

        static int sumaNumero(int num1, int num2)
        {
            //variables
            int resultado;

            //process
            resultado = num1 + num2;
            return resultado;
        }
        //sintaxis de un metodo con solo una linea de codigo 
        // static double divide(double num1, num2) => num1/num2;

        
    }
}
