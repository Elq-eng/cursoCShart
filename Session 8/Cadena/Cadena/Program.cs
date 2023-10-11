using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Cadenas
 * Resumen 
 * Elquin Casacvita Rios
 * Versio 4.7.2
 * 
 */
namespace Cadena
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = "Hola mundo";
            String formato = "";

            DateTime miTiempo = DateTime.Now; //para las fechas
            formato = String.Format("La fecha es: {0:d MMMM yyyy}",miTiempo);

            Console.WriteLine(formato);

            //metodo ToString(), regresa una cadena

            Double valor = -74.87;
            formato = String.Format("{0:$#,###0.00;-$#,###0.00;Cero}",valor);

            Console.WriteLine(formato);


            //concatenar 

            String nombre = "Elquin", apellido = "Cascavita", NombreCompleto = "";
            NombreCompleto = nombre + " " + apellido;

            Console.WriteLine(NombreCompleto);

            //metodo para concatenera

            NombreCompleto = String.Concat(nombre, String.Concat(" ",apellido));

            Console.WriteLine(NombreCompleto);

            //string Builder


            StringBuilder sb = new StringBuilder("Hola Mundo");

            sb.Append("Hola Mundo");

            //comparacion de string
            int comparacion = 0;
            String nombre2 = "juan";

            comparacion = String.Compare("pedro", nombre);

            if (comparacion == 0)
            {
                Console.WriteLine("Los nombres son iguales");
            }
            else
            {
                Console.WriteLine("Los nombres son diferentes");
            }

            if (String.Equals("juan",nombre2))
            {
                Console.WriteLine("equals funciona bien");
            }

            //encontrar una cadena 

            String nombre2Completo = "Juan Pedro Lopez";
            String nombreBuscar = "Pedro";

            if (nombre2Completo.Contains(nombreBuscar) == true) ;
            Console.WriteLine("El nombre se encuentra");
            //es sensible para mayusculas y minusculas


            //extraer subcadena 
            String cadena1 = "Hola mundo redondo", resultado1 = "";
            resultado1 = cadena1.Substring(11, 7);
            Console.WriteLine(resultado1);

            //si la cadena temrna en algo particular

            cadena1 = "Juan pedro Lopez";
            String cadena2 = "Lopez";

            if(cadena1.EndsWith(cadena2)==true)
            {
                Console.WriteLine("La cadena termina en {0}", cadena2);
            }

            //copiar parte de una cadena
            //CopyTo(,cadena de tipo char,) =

            char[] destino = new char[10];

            cadena1.CopyTo(5, destino, 0, 5);
            Console.WriteLine(destino);

            //insertando una cadena
            //insert


            //encontrar la posicion de subcadena

            int indice = 0;
            String cadena3 = "Hola a todos. Hola";

            indice = cadena3.LastIndexOf("Hola");

            Console.WriteLine(indice);

            //metodo que hace pad para justificar
            String cadena4 = "Hola mundo, soy programador ";
            String resultado4 = "";

            //implementacion del metodo 
            resultado4 = cadena4.PadLeft(10);
            Console.WriteLine(resultado4);

            //eliminar partes de la cadena

            resultado4 = cadena4.Remove(11, 16);

            Console.WriteLine(resultado4);

            resultado4 = resultado4.PadLeft(10);
            Console.WriteLine(resultado4);

            //reemplazar una subcadena
            //replace

            //dividir una cadena
            String cadena6 = "Hola, este es un ejemplo; para subdividr una. Cadena";

            String[] resultado8 = cadena6.Split(new char[] { ',', ';', '.' });

            for (int i = 0; i < resultado8.Length; i++)
            {
                Console.WriteLine(resultado8[i]);
            }

            //intercambiar entre mayusculas y minusculas 
            String mex = "    Mexico ES UN PAIS MUY GRANDE   ";
            resultado1 = "";

            //para minusculas
            resultado1 = mex.ToLower();

            Console.WriteLine(resultado1);

            //para mayusculas

            resultado1 = mex.ToUpper();
            Console.WriteLine(resultado1);

            //podar una cadena

            string resultado3 = mex.Trim();
            Console.WriteLine(resultado3);

        }//Cierre de Main 
    }
}
