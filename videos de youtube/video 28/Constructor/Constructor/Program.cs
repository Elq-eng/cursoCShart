using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Constructores
 * Resumen 
 * Elquin Cascavita
 * Version 4.7.2 .net 
 */
namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();

            Coche coche2 = new Coche();

            Console.WriteLine(coche2.getInforCoche());

            //cuando se crea un constructor con diferentes aprametros
            Coche coche3 = new Coche(2323.334, 2323.5);

            //llamar lo que esta dentro del constructor de coche 3
            Console.WriteLine(coche3.getInforCoche());

            coche3.setExtras(true, "cuero");
            Console.WriteLine(coche3.getExtras());
            

        }
    }

    partial class Coche
    {
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapiceria;

        //construcot 
        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";

        }
        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }
    }
    //------------------------------------------------------------------------------------------------------------
    partial class Coche
    {
        //para manipular los datos privador
        public string getInforCoche()
        {
            return "Informacion del coche: " + ruedas + " ruedas " + largo + " de largo " + ancho + " de ancho";
        }

        public void setExtras(bool paramClimatizador, string paratapiceria)
        {
            climatizador = paramClimatizador;
            tapiceria = paratapiceria;

        }
        public string getExtras()
        {


            return "extras del coche; \n" + "Tapiceria: " + tapiceria + " Climatizador: " + climatizador;
        }

    }
}
