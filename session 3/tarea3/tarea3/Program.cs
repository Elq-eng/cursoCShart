using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Tarea 3
 * resumen: 1. hacer un programa para que el usuario ingrese un numero del 1,12 y aparezca el mes respectivo,
 * 2. hacer un programa que le diga al usuario si el numero ingresado es par o impar 
 * elquin cascavita rios 
 * version .net 4.7.2
 */
namespace tarea3
{
    class Program
    {
        static void Main(string[] args)
        {

            //EJERCICIO 1
            //variable 
            byte mes;

            //ingresar numero
            Console.Write("Ingresar un numero del 1 - 12: ");
            mes = Byte.Parse(Console.ReadLine());

            switch(mes)
            {
                case 1:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Enero", mes);
                    break;
                case 2:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Febrero", mes);
                    break;
                case 3:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Marzo", mes);
                    break;
                case 4:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Abril", mes);
                    break;
                case 5:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Mayo", mes);
                    break;
                case 6:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Junio", mes);
                    break;
                case 7:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Julio", mes);
                    break;
                case 8:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Agosto", mes);
                    break;
                case 9:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Septiembre", mes);
                    break;
                case 10:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Octubre", mes);
                    break;
                case 11:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Nomviembre", mes);
                    break;
                case 12:
                    Console.WriteLine("El mes que ingreso {0} pertenece a Diciembre", mes);
                    break;
                default:
                    Console.WriteLine("el numero que ingreso no pertenece a ningun mes calendario {0} ", mes);
                    break;
            }

            //EJERCICIO 2

            //VARIABLES
            long num1;

            //ingresar numero 2
            Console.Write("Ingresar un numero para verificar si es par o impar: ");
            num1 = Int64.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("El numero ingresado {0}  es par ", num1);
            }
            else
            {
                Console.WriteLine("El numero ingresado {0} es impar  ", num1);
            }

            //ejercicio numero 3

            //variabls 

            byte minutos, horas, tiempo;
            double precio,a;


            //ingresar si estuvo minutos u horas
            Console.Write("Escoja entre 1 y 2 si el tiempo que permanecio en el establecimiento fue en 1.Minutos o 2.Horas: ");
            tiempo = Byte.Parse(Console.ReadLine());

            if(tiempo == 2)
            {
                precio = 15.0;
                Console.WriteLine("Ingresar las horas: ");
                horas = Byte.Parse(Console.ReadLine());
                if (horas >= 3)
                {
                    precio = precio + (Math.Abs(horas - 2) * 40.00);
                }
               
            }
            else
            {
                precio = 5.0;
                Console.WriteLine("Ingresar los minutos");
                minutos = Byte.Parse(Console.ReadLine());

            }

            Console.WriteLine(" El precio a pagar es {0},00 peso", precio);

        }
    }
}
