using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Conversion de entradas
 *Resumen: se hace toda la cnversion de entradas que se peude tener dentro del algoritmo
   clases tipo de referencia, valores int tipo de valor
 *Elquin Cascavita 
 *version: .Net 4.7
 
 */

namespace Conversion_entrada_movilidad_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada, entrada2;
            int num1 = 5, num2, resultado;

            //pregntamos al usuario el numero 
            Console.Write("Dame un numero: ");
            entrada = Console.ReadLine();

            //convertir numero entero se utili<a el Toint32 
            // porque en este lengaje es diferente dado que 
            // la entrada de la consola siempre en un string
            // por ello se tiene que convertir
            num2 = Convert.ToInt32(entrada);

            //mostrar la suma
            resultado = num1 + num2;

            Console.WriteLine("el resultado de la suma es: {0}",resultado);

            //tipo de estructura 

            num2 = Int32.Parse(entrada);
            num1 = 4;
            //mostrar la suma
            resultado = num1 + num2;

            Console.WriteLine("el resultado de la suma es: {0}", resultado);

            //ahora sumar numero flotante 

            
            //mostrar la suma
            float num3 = 4.3F, num4,resultado2;
            //ahora sumar numero flotante 

            Console.Write("Dame un numero: ");
            entrada2 = Console.ReadLine();

            num4 = Convert.ToSingle(entrada2);
            resultado2 = num3 + num4;

            Console.WriteLine("el resultado de la suma es: {0}", resultado2);

            //para disminuir las lineas de codigo con respecto a la variable string
            //primero va la clase y luego la estructura en el caso de convert
            

            int num5;

            Console.Write("Un número para verlo en una linea: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            resultado = num5 + num1;

            Console.WriteLine("el resultado es: {0}", resultado);

            //para parse va La estructura y luego parse

            
            Console.Write("Un número para verlo en una linea: ");
            num5 = Int32.Parse(Console.ReadLine());

            resultado = num5 + num1;

            Console.WriteLine("el resultado es: {0}", resultado);


        }
    }
}
