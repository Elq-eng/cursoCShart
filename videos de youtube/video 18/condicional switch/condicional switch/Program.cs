using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Codicional switch
 * Resumen
 * Elquin Cascavita 
 * Version 4.7.2
 * 
 */
namespace condicional_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //vriables 
            string medioTranspote;

            //entradas
            Console.WriteLine("Elige medio de transporte (coche, tren, avion)");
            medioTranspote = Console.ReadLine();
            
            switch (medioTranspote)
            {
                case "Coche":
                    Console.WriteLine("Velocidad media de : 100 / km");
                    break;

                case "tren":
                    Console.WriteLine("Velocidad media de : 250 / km");
                    break;

                case "avion":
                    Console.WriteLine("Velocidad media de : 800 / km");
                    break;

                default:
                    Console.WriteLine("No existe el medio de transporte");
                    break;

                    
            }
            //ejercicio 2
            //variable
            int nMes;

            //entrada
            Console.WriteLine("Introduce n° de mes para cálculo de la comisión");
            nMes = Int32.Parse(Console.ReadLine());

            switch(nMes)
            {
                case 1:
                    Console.WriteLine("Mes escogido: Enero");
                    break;

                case 2:
                    Console.WriteLine("Mes escogido: Febrero");
                    break;

                case 3:
                    Console.WriteLine("Mes escogido: Marzo");
                    break;

                case 4:
                    Console.WriteLine("Mes escogido: Abril");
                    break;

                case 5:
                    Console.WriteLine("Mes escogido: Mayo");
                    break;

                case 6:
                    Console.WriteLine("Mes escogido: Junio");
                    break;
                   
                case 7:
                    Console.WriteLine("Mes escogido: Julio");
                    break;

                case 8:
                    Console.WriteLine("Mes escogido: Agosto");
                    break;

                case 9:
                    Console.WriteLine("Mes escogido: Septiembre");
                    break;

                case 10:
                    Console.WriteLine("Mes escogido: Octubre");
                    break;

                case 11:
                    Console.WriteLine("Mes escogido: Noviembre");
                    break;

                case 12:
                    Console.WriteLine("Mes escogido: Diciembre");
                    break;

                default:
                    Console.WriteLine("Mes escogido: 'No existe'");
                    break;



            }
        }
    }
}
