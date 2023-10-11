using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* paso_por_referencia_y_paso_por_valor
 * Resumen: Pasar por referencia es como trabajar en ovearleaf dadoq ue el documento siempre se va a modificar este donde este
 * en este caso se modifica la variable, tambien esta el valor out 
 * Elquin Cascavita Rios 
 * Version .net 4.7.2
 * 
 */
namespace paso_por_referencia_y_paso_por_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            //pasar por valor 
            byte numAr;

            string saludarAr;
            int numPrimoAr;

            //asinamos su valor en la consola
           // numAr = 10;
            //Console.WriteLine(numAr);

            //Invocacmos el método y mandamos al argumento
            Prueba(out numAr, out saludarAr,out numPrimoAr);// si se quiere pasar por referencia se escribe ref numAr y si se quiere pasar sin inicializar se pone out

            //Después de que el método cambió el valor, volvemos a mostrar 
            Console.WriteLine(numAr);
            Console.WriteLine(saludarAr);
            Console.WriteLine(numPrimoAr);
            //modificador sin inicializar la variable 

        }
        static void Prueba(out byte numPa, out string saludoPa, out int numPrimoPa)//(ref byte numPa)si se quiere pasar por referencia 
        {
            //Modificamos el valor del parametro
            numPa = 20;
            saludoPa = "Hola a todos";
            numPrimoPa = 7;
        }
    }
}
