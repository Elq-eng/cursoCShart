using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Clases e instancias 
 * Resumen: primero en el video 28 se hace la instanciacion, ahora se hace la encapsulaicon donde cada clase se apropia de sus atributos, metodos y no permite que ninguna otra clase tenga acceso a ellos si no se lo permite, para ello se utiliza el private.
 * Elquin Cascavita 
 * Version 4.7.2 de .net
 */
namespace POO_clases_e_instancias
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo miCirculo = new Circulo();//iniciacion de variable objeto de tipo circulo

            int radio = 5;
            double resultado;
            
            resultado = miCirculo.CalculoArea(radio);

            Console.WriteLine("El calculo area de la clase circulo es: {0}", resultado);

            //ejercicio 2
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(-1.45);
            resultado = obj.Convierte(50);

            Console.WriteLine("los 50 euros en dolares son: {0}",resultado);
            
        }
    }

    class Circulo
    {
        //atributo
         private const double PI = 3.1416; // propiedades de la clase circulo, campo de clase 
        
         public double CalculoArea(int radio) // metodo de clase, ¿ que pueden hacer los objetos de tipo circulo?
        {
            double resultado;
            resultado = PI*Math.Pow(radio, 2);
            return resultado;
        }


    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void CambiaValorEuro (double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;
            else euro = nuevoValor;
        }
    }

}
