using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio de operadores
 * Resumen: Se hace un ejercicio, para verificar el funcionameinto de todas condiciones operacionales.
 * Elquin Cascavita 
 * .net 4.7.2
 */

namespace ejercicio_de_operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejercicio para el arranque de un avion 

            //variable s
            float energia;
            bool propulsorIzquierdo, propulsorDerecho;

            //ingresar el valor de energia 
            Console.Write("Ingrese el nivel de energia: ");
            energia = float.Parse(Console.ReadLine());

            //confirmar propulsores 

            Console.Write("el propulsor derecho esta en buen estado? (True/false): ");
            propulsorDerecho = Boolean.Parse(Console.ReadLine());

            Console.Write("el propulsor izquierdo esta en buen estado? (True/false): ");
            propulsorIzquierdo = Convert.ToBoolean(Console.ReadLine());


            // ahora condicio de verificacion 
            if(((propulsorDerecho && propulsorIzquierdo ) == true) && (energia >= 75)  || ((propulsorDerecho || propulsorIzquierdo) == true) && (energia == 100))
            {
                Console.WriteLine("Puedes despegar ");
            }
            else
            {
                Console.WriteLine("Lo siento, pero no es posible despegar ");
            }

        }
    }
}
