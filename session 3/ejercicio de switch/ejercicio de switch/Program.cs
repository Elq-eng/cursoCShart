using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*Ejercicio de switch de suma , resta, multiplicacion
 * resumen: pasar de if a switch
 * elquin cascavita rios 
 * version .net 4.7.2
 */
namespace ejercicio_de_switch
{
    class Program
    {
        static void Main(string[] args)
        {

            // ejericio 4 suma resta multiplicacion y division con dos numeros ingresados
            //variables 
            decimal num1, num2, resultado2 = 0.0M; //sufijo de decimal M
            byte opcion;

            //mostrar el menu

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");

            //pedimos al usuario que ingrese el primero numero 
            Console.WriteLine("Ingrese una opcion del menu");
            opcion = byte.Parse(Console.ReadLine());

            // ahora ingresa los dos numeros
            Console.WriteLine("Ingresa el primer numero");
            num1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero");
            num2 = Convert.ToDecimal(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    resultado2 = num1 + num2;
                    break;

                case 2:
                    resultado2 = num1 - num2;
                    break;

                case 3:
                    resultado2 = num1 * num2; 
                    break;
                case 4:

                    if (num2 != 0)
                    {
                        resultado2 = num1 / num2;

                    }
                    else
                    {
                        Console.WriteLine("La division no se puede ejecutar ");
                    }

                        break;
                default:
                    Console.WriteLine("La opcion no existe");
                    break;
            }

            Console.WriteLine("El resultado de la operacion es: {0}", resultado2);

            
        }
    }
}
