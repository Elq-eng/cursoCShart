using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio de interfaces
 * Resumen
 * Elquin Cascavita Rios
 * Version 4.7.2 de .NET
 * 
 */
namespace ejercicio_de_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se llama el primer aviso 
            AvisosTraficos av1 = new AvisosTraficos();

            av1.IMostraraviso();

            //segundo constructor 

            AvisosTraficos av2 = new AvisosTraficos("Jefatura provincial Madrid", "Sanciona de velocidad: 300", "12-23-2020");
            av2.IMostraraviso();
        }
    }
}
