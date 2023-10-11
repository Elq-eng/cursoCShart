using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio de ramdon
 * Résumen: se crea un numero al random y se trata de adivinar si es mayor o menor hasta que sea igual
 * Elquin Cascavita
 * Version 4.7.2 .net
 */
namespace ejercicio_de_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int number,number2, count=1;

            //Ramdom number
            Random numero = new Random();
            number = numero.Next(0, 100);

            //number of input 
            Console.WriteLine("Ingrese un numero del 1-100, haber si acierta con el numero \nque se genero automaticamente ");
            number2 = Convert.ToInt32(Console.ReadLine());

            //validition of number
            while(number != number2)
            {
                if (number > number2)
                    Console.WriteLine("El numero ingresado {0} es menor", number2);
                else
                    Console.WriteLine("El numero ingresado {0} es mayor",number2);

                //number of input 
                Console.WriteLine("Ingrese nuevamente el numero");
                number2 = Convert.ToInt32(Console.ReadLine());
                count += 1;
            }

            Console.WriteLine("felicidades acertaste al numero, con un total de {0} veces intentadas!!",count);
        }
    }
}
