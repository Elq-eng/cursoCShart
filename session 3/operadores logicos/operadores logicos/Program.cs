using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*Instrucciones de desicion 
Resumen: 
Elquin Cascavita 
.Net 4.7.2
 */

namespace operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //negacion !
            bool p = true, bateria;

            Console.WriteLine(p);
            Console.WriteLine(!p);

            //  ejercicio de bateria para la negacion 

            Console.Write("Hay bateria True/False: " );
            bateria = Boolean.Parse(Console.ReadLine());

            if (!(bateria == true))
            {
                Console.WriteLine("Conecta la bateria");
             }
            else
            {
                Console.WriteLine("no es necesario conectar una bateria");
            }

            //Operador Logico AND &&


            bool  f = true , q = true;

            Console.WriteLine(f && q);

            // ejercicio de logico &&

            //variables

            byte edad;
            bool licencia;

            //usuario ingresar edad
            Console.Write("¿Que edad tienes? ");
            edad = Convert.ToByte(Console.ReadLine());

            //confirmar si tiene licencia 
            Console.Write("¿Tienes licencia true/false? ");
            licencia = Boolean.Parse(Console.ReadLine());

            //confirmar en una decision si cumple con las dos condiciones 

            if ( (edad >= 18 ) && (licencia == true))
            {
                Console.WriteLine("Eres acto de conducir un Auto");
            }
            else
            {
                Console.WriteLine("Aun no puedes conducir un Automovil");
            }

            //Operador OR ||

            

           // declarar variables 
            float calPrepa, calExamen;
           
           //ingresar el valor de preparatoria
            Console.Write("Con que promedio concluiste tus estudios de preparatoria: ");
            calPrepa = float.Parse(Console.ReadLine());

            //ingresar el valor del exament
            Console.Write("cual fue tu calificacion en el examen final: ");
            calExamen = Convert.ToSingle(Console.ReadLine());

            // verificar la condicion OR

            if ( (calPrepa >= 9.0) || (calExamen >= 9.5))
            {
                Console.WriteLine("Felicidades tienes la Beca ");

            }
            else
            {
                Console.WriteLine("Lo siento, no obtienes la beca ");
            }

                
        }
    }
}
