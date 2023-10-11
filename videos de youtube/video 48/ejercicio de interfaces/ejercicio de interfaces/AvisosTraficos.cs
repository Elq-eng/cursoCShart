using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_interfaces
{
    class AvisosTraficos : IAviso
    {
        //campos 
        private string remitente, mensaje, fecha;

       //Constructores son 2, 

        //primer constructor
        public AvisosTraficos()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de 3 dias y se beneficiará de una reduccion en la sancion del 50%";
            fecha = "";
        }

        public AvisosTraficos(String remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void IMostraraviso()
        {

            Console.WriteLine("Mensaje {0} ha sido enviado por {1}, el dia {2}", mensaje,remitente,fecha);
        }
    }
}
