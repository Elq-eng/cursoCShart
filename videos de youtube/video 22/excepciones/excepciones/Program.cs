using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Excepciones
 * Resumen: en algunas ocasion se debe poner bloque try-catch, se pueden adjuntar varios catch y cuando se genera varias excepciones puede poner una generica la cual llamada Exception
 * Elquin Cascavita
 * version 4.7.2 .net
 * 
 */
namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int number, number2, count = 0;

            //Ramdom number
            Random numero = new Random();
            number = numero.Next(0, 100);

            //number of input 
            Console.WriteLine("Ingrese un numero del 1-100, haber si acierta con el numero \nque se genero automaticamente ");
            

            //validition of number
            do
            {
                count += 1;

                //exception
                try
                {
                    number2 = Convert.ToInt32(Console.ReadLine());
                }
                /*
                catch(FormatException ex)
                {
                    Console.WriteLine("no has introducido un valor numéro válido. Se toma como # introducido Cero");
                    number2 = 0;
                }
                catch(OverflowException ox)
                {
                    Console.WriteLine("no has introducido un valor numéro válido. Se toma como # introducido Cero");
                    number2 = 0;
                }*/

                //Ep.GetType() entre el tipo de excepcion
                catch (Exception Ep) when (Ep.GetType() != typeof(FormatException))
                {
                    Console.WriteLine("ha habido un error, se toma el numero ingresado como 0");
                    Console.WriteLine(Ep.Message);
                    number2 = 0;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("no has introducido un valor numéro válido. Se toma como # introducido Cero");
                    number2 = 0;
                }

                if (number > number2)
                    Console.WriteLine("El numero ingresado {0} es menor", number2);
                if (number < number2)
                    Console.WriteLine("El numero ingresado {0} es mayor", number2);

                
                
            } while (number != number2);

            Console.WriteLine("felicidades acertaste al numero, con un total de {0} veces intentadas!!", count);
        }
    }
}
