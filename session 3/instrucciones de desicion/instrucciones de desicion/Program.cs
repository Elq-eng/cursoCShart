using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Instrucciones de desicion 
 Resumen: se hace las estructuras de decision con if else, else if, aqui se hace un ejemeplo donde se utiliza la optimizacion de codigo para mejorar el script con una escalera de if.
Elquin Cascavita 
.Net 4.7.2
 */
namespace instrucciones_de_desicion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir un numero al usuario y determinar si el numero es negativo o positivo
            // seleccion if
            //definicion de variables
            double numero;

            //pedir el numero
            Console.Write("Escribe un numero: ");
            numero = double.Parse(Console.ReadLine());

            //determinar si el numero es positivo o negrativo
            if (numero < 0)
            {
                Console.WriteLine("El numero es negativo {0}", numero);
            }
            else
            {
                Console.WriteLine("El numero es positivo {0}", numero);
            }

            //ejercicio 2  dividiendo numeros

            // variables

            double dividiendo, divisor, resultado;
            
            //usuario inserta el dividiendo
            Console.Write("Dame el dividiendo: ");
            dividiendo = Convert.ToDouble(Console.ReadLine());

            //el usuario inserta el divisor
            Console.Write("Dame el divisor: ");
            divisor = Convert.ToDouble(Console.ReadLine());

            //comprobar si el divisor es diferente de cero

            if (divisor != 0)
            {
                resultado = dividiendo / divisor;
                Console.WriteLine("El resultado de la division es: {0} ", resultado);
            }
            else
            {
                Console.WriteLine("La division no se puede ejecutar ");
            }

            // ejericio 3 suma resta multiplicacion y division con dos numeros ingresados
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

            if (opcion == 1)
            {
                resultado2 = num1 + num2;
                

            }
            else if (opcion == 2)
            {
                resultado2 = num1 - num2;
                
            }
            else if (opcion == 3)
            {
                resultado2 = num1 * num2;
                
            }
            else if (opcion == 4)
            {

                if (num2 != 0)
                {
                    resultado2 = num1 / num2;
                   
                }
                else
                {
                    Console.WriteLine("La division no se puede ejecutar ");
                }
                
            }
            else
            {
                Console.WriteLine("La opcion no existe");
            }

            Console.WriteLine("El resultado de la operacion es: {0}", resultado2);

            //Para optimizar el programa, se puede hcer una escalera de if dada por el else, para mejorar el rendimiento.
        }
    }
}
