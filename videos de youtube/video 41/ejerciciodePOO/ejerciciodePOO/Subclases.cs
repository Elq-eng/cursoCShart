using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciodePOO
{
  class Avion : MedioTransporte 
    {
        public Avion(int rueda):base(rueda)
        {

        }

        public override void Conducir()
        {
            Console.WriteLine("El avion Solo lo vuelan los pilotos");
        }
    }
  class Vehiculo : MedioTransporte
    {
        public Vehiculo(int rueda) : base(rueda)
        {

        }
    }
    class Coche : MedioTransporte
    {
        public Coche(int rueda) : base(rueda)
        {

        }
        public override void Conducir()
        {
            Console.WriteLine("Solo se acepta licencia B1 para los coches");
        }
    }
}
