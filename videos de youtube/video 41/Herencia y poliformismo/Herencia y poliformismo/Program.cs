using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Herencia y poliformismo
 * Resumen: para hacer un constructor se debe tener en cuenta la instruccion :base(), donde modifica el constructor de cada una de las subclases, por itra aprte para saber quien hereda de qien se alica el el principio de "siempre es un "
 * 
 * Poliformismo: es donde hay un metodo heredado pero en cada subclase se le quiere agregar o modificar su contenido
 * virtual (va en el metodo principal) - override(va en el metodo heredado)
 * 
 * Modificador de acceso, public, private, protected es aquel que es un medio entre private y public, este es accesible desde las subclases heredadas, pero no se puede de otras clases,
 * Elquin Cascavita
 * Version 4.7.2 de .net
 */
namespace Herencia_y_poliformismo
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo babieca = new Caballo("Babieca");

            Humano Juan = new Humano("Elquin");

            Gorila Copito = new Gorila("Copito");

            babieca.cuidaCrias();

            Juan.getNombre();

            //principio de "es siempre un"

            Mamiferos animal = new Mamiferos("Bucefalo");

            Mamiferos persona = new Humano("Pedro");

            animal = babieca;
            //se crea un array pero solo se agregar caballos en este caso el objeto

            Caballo[] almacenAnimales = new Caballo[3];

            //pero si se hace un array de la super clase se puede agregar  todo tipo de objetos que sean heredados de ella pero no se tener acceso a los metodos que hhay en cada subclase 
            Mamiferos[] almacenesAnimales = new Mamiferos[3];

            almacenesAnimales[0] = babieca;
            almacenesAnimales[1] = Juan;
            almacenesAnimales[2] = Copito;

            for (int i = 0; i<3; i++)
            {
                almacenesAnimales[i].pensar();
            }

            //protected 
        }
    }

    //super clase
    class Mamiferos //super clase 
    {
        //campos de clase
        private String nombreSerVivo;

        //constructor 
        public Mamiferos(String nombre)
        {
            nombreSerVivo = nombre;
        }
        protected void respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public void cuidaCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan solas ");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: {0}", nombreSerVivo);
        }
        
    }//end of class mamifero


    //subclases
    class Caballo : Mamiferos //nombre de la clase actual, y hereda de mamiferos subclase 1
        
     
    {
        //se debe llamar el constructor padre
        public Caballo(String nombreCaballo):base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopear");
        }
    }

    class Humano: Mamiferos //subclase 2
    {
        public Humano(String nombreHumano): base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila : Mamiferos //subclase 3
    {
        public Gorila(String nombreGorila):base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valga por si solas");
        }
        public void pensar()
        {
            Console.WriteLine("Pensamiento instintivo avanzado");
        }
    }

}
