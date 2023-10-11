using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Interfaces
 * Resumen:Conjunto de directrices que debn cumplir las clases, es lo que permite que la clase superclase, decida a quien heredar o no los metodos heredados, se inicia con I por convencion, la interface obliga a las clases heredadas que pongan el metodo a su manera,
 * 
 * Restricciones
 * no se definen campos en interfaces
 * no se define constrcutores, destructores
 * no se esspecifica el modificador de acceso en el metodo
 * Elquin Cascavita
 * Version .net version 4.7.2
 * 
 * 
 */
namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Caballo babieca = new Caballo("Babieca");

            IMamiferosTerrestres Ibabieca = babieca;

            Humano Juan = new Humano("Elquin");

            Gorila Copito = new Gorila("Copito");

            babieca.CuidaCrias();

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

            for (int i = 0; i < 3; i++)
            {
                almacenesAnimales[i].pensar();
            }

            Ballena miWally = new Ballena("Wally");

            miWally.nadar();

            Console.WriteLine("Se implementa la interface");
            Console.WriteLine("El numero de patas de que tiene Babieca es: {0}", Ibabieca.NumeroPatas());

            Console.WriteLine("Se implementa nuevamente la interface");
            Console.WriteLine("El numero de aletas que tiene Wally es: {0}", miWally.numeroAletas());
        }
    }
    //interface

    interface IMamiferosTerrestres
    {
        //metodos de interface
        int NumeroPatas();
    }

    interface IMamiferosAcuaticos
    {
        int numeroAletas();
    }

    interface IAnimalesYDeportes
    {
        string tipoDeporte();

        Boolean esOlimpicio();
    }
    interface ISaltoConPatas
    {
        int NumeroPatas();
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
        public void CuidaCrias()
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
    class Caballo : Mamiferos, IMamiferosTerrestres,IAnimalesYDeportes, ISaltoConPatas//nombre de la clase actual, y hereda de mamiferos subclase 1
    {
        //se debe llamar el constructor padre
        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopear");
        }

        //interface con ambiguedad
        int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }
        //interface
        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }

        

        public string tipoDeporte()
        {
            return "Hipica";
        }

        public Boolean esOlimpicio()
        {
            return true; 
        }
    }

    class Humano : Mamiferos //subclase 2
    {
        public Humano(String nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }

    class Gorila : Mamiferos, IMamiferosTerrestres //subclase 3
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
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
        public int NumeroPatas()
        {
            return 2;
        }
    }
    class Ballena : Mamiferos,IMamiferosAcuaticos
    {
        public Ballena(String nombraBallena):base(nombraBallena)
        {

        }
        public int numeroAletas()
        {
            return 6;
        }
        public void nadar()
        {
            Console.WriteLine("Soy capaz de nadar");
        }
       
    }
}
