using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* ejercicios 
 * Resumen
 * Elquin Cascavita
 * version 4.7.2 .net
 * 
 */
namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio de potencias 
            //varaiables
            int bases, potencia = 0;
            decimal resultado = 1M;

            //ingresar variables
            Console.Write("Ingrese la base: ");
            bases = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la potencia: ");
            potencia = int.Parse(Console.ReadLine());
            
            //calculo de la potencia 

            if (potencia >= 1)
            {
                for(int i = 1; i <= potencia; i++)
                {
                    resultado *= bases;
                }
		
		        
            }
            else
            {
                potencia *= -1;
                for (int i = 1; i <= potencia; i++)
                {
                    resultado *= bases;
                }

                resultado = 1 / (resultado);
            }

            Console.WriteLine("{0} ^ {1} = {2}",bases,potencia,resultado);

            //ejercicio de numeros primos 

            //variables 
            int primo = 0, noprimo = 0, contador = 0; 
            double resultado2;

            Console.Write("Los numeros primos son: ");
            //calculo de numero primos del 1-100
            for (int i2 = 1; i2 <= 100; i2++)
            {
                primo = 0;
                for (double j = 1; j <= i2; j++)
                {
                    
                    
                    if(i2 % j == 0)
                    {
                        primo += 1;
                    }
                   
                }

                if(primo == 2)
                {
                    
                    Console.Write("{0} ", i2);
                    contador++;
                }

                
            }
            Console.WriteLine(contador);
        }
    }
}
