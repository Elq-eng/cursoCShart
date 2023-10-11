using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Explicacion do while 
 * Resumen: con el doo while permite ejecutar el código al menos una vez
 * Elquin Cascavita
 * Version .net 4.7.2
 */
namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {

            byte i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
                //código que se repite

            }
            while ( i <= 10  /*condición*/);

            //ejercicio  do while 

            //variables

            decimal num1, num2, resultado = 0M;
            byte opcion;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");

                //pedimos la opción 
                Console.Write("Escoge una opción");
                opcion = Convert.ToByte(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //pedimos los dos números
            Console.Write("Dame el primero número: ");
            num1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Dame el segundo número: ");
            num2 = Decimal.Parse(Console.ReadLine());

            //hacer la operacion según la opción escogida

            switch(opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    break;

                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }                        
                    break;
                
            }

            Console.WriteLine("El resultado es: {0}", resultado);

        }
    }
}
