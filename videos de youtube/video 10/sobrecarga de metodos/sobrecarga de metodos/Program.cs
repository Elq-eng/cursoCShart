using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Sobrecarga de metodos
 * Resumen:sobre cargar en los metodos debe ser dado por el numero de parametros de entrada,
 * Elquin Cascavita
 * Version 4.7.2
 */
namespace sobrecarga_de_metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            //cuando se hace la sobrecargar el mismo codigo se ejecuta escogiendo el metodo que mejor se adapte a los parametros de entrada,


            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 8.3;
            Console.WriteLine(Suma(5,6.4,valor3));
        }

       /* static int Suma(int operador1, int operador2) => operador1 + operador2;

        static int Suma(int numero1, double num2) => numero1 + (int)num2;*/


        //los parametros opcionales van despues de los obligatorios,
        static double Suma(int numero1, double num2, double num3 = 0)
        {
            return numero1 + num2 + num3;
        }
    }
}
