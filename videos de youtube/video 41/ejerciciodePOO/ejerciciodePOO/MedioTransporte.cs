using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Super Clase 
namespace ejerciciodePOO
{
    class MedioTransporte
    {
        private int rueda;


        //metodo constructor 
        public MedioTransporte(int rueda)
        {
            this.rueda = rueda;
        }

        //metodo get
        public void getRuedas()
        {
            Console.WriteLine("Este medio de transporte tiene {0} ruedas",rueda);
        }

        public void ArrancarMotor()
        {
            Console.WriteLine("Inicia una vez se prende.");
        }

        public void PararMotor()
        {
            Console.WriteLine("Una vez se preisona el freno.");
        }

        public virtual void Conducir()
        {
            Console.WriteLine("Cualquier persona lo puede hacer desde que tenga la licencia.");
        }
    }
}
