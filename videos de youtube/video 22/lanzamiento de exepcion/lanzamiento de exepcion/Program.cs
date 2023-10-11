using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Lanzamiento de throw
 * Resumen
 * Elquin Cascavita 
 * version 4.7.2
 */
namespace lanzamiento_de_exepcion
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int numeroMes;

            //proceso
            Console.WriteLine("Introdume el numero del mes");

            numeroMes = int.Parse(Console.ReadLine());

            try
            {
                //resultado 
                Console.WriteLine(NombreDelMes(numeroMes));
            }
            catch(Exception e)
            {
                Console.WriteLine("Mensaje de la excepcion: " + e.Message);
            }

            //siguiente codigo
            Console.WriteLine("Continua el resto del programa");
        }//end main


        //metodo
        static string NombreDelMes(int mes)
        {
            

            switch(mes)
            {
                case 1:
                    return "Enero";
                    break;

                case 2:
                    return "Febrero";
                    break;

                case 3:
                    return "Marzo";
                    break;

                case 4:
                    return "Abril";
                    break;

                case 5:
                    return "Mayo";
                    break;

                case 6:
                    return "Junio";
                    break;

                case 7:
                    return "Julio";
                    break;

                case 8:
                    return "Agosto";
                    break;

                case 9:
                    return "Septiembre";
                    break;

                case 10:
                    return "Octubre";
                    break;

                case 11:
                    return "Noviembre";
                    break;

                case 12:
                    return "Diciembre";
                    break;

                default:
                    //se lanza la expcepcion
                    throw new ArgumentOutOfRangeException();


            }
        }
    }
}
