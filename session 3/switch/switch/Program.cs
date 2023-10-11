using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Condicional switch
 * Resumen: se hace el proceso de enteder paso a paso el switch de condicion
 * Elquin Cascavita Rios 
 * .net version 4.7.2
 */

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            string color;

            //ingresar el color
            Console.Write("Ingresa el color RGB: ");
            color = Console.ReadLine();

            //condicion swit
            switch (color)//expresion de coincidencia)
            {
                case "Red": //si se ponen mayusculas
                case "RED":
                    Console.WriteLine("El codigo RGB para {0} es: 255,0,0", color );
                    break;
                case "Green":
                    //codigo
                    Console.WriteLine("El codigo RGB para {0} es: 0,255,0", color);
                    break;
                case "Blue":
                    //codigo
                    Console.WriteLine("El codigo RGB para {0} es: 0,0,255", color);
                    break;
                //QUE PASA CUANDO LA ETIQUETA DE COINCIDENCIA NO SE ENCUENTRA EN EL CASE
                default:
                    Console.WriteLine("no se encontro codigo RGB para el  color {0} ", color);
                    break;
            }

        }
    }
}
