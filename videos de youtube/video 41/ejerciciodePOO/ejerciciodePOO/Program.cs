using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicio de POO
 * Resumen
 * Elquin Cascavita 
 * Version .net 4.7.2
 */
namespace ejerciciodePOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancias de las subclases 
            Avion bbva = new Avion(3);
            Coche Transmilenio = new Coche(6);
            Vehiculo Renault = new Vehiculo(7);

            MedioTransporte[] Todos = new MedioTransporte[3];

            try
            {
            Todos[0] = bbva;
            Todos[1] = Transmilenio;
            Todos[2] = Renault;

            
            foreach (MedioTransporte N in Todos)
            {
                N.Conducir();
                N.getRuedas();
            }
            }
            catch(IndexOutOfRangeException a)
            {
                Console.WriteLine("No se ha podido por que hay un error");
            }

            //poliformismo
            //creo un objeto de la superclase y a ese objeto le asigno los objetos creados apartir de las subclases

            Console.WriteLine();

            Console.WriteLine("Poliformismo en accion!");
            MedioTransporte miVehiculo = Transmilenio;

            miVehiculo.Conducir();

            miVehiculo = Renault;

            miVehiculo.Conducir();


            //TODO: 
        }
    }
}
