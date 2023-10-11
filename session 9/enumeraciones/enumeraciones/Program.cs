using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Enumeraciones
 * Resumen: ejercicio a enumeracion, la enumeracion debe saber de antemano un valor finito para que haga su iteracion.
 * Elquin Cascavita Rios
 * Version 4.7.2 
 * 
 */
namespace enumeraciones
{
    class Program
    {

        //las enumeaciones estan debajo del program
        enum semana {Lunes = 5,Martes,Miercoles,Jueves,Viernes, Sabado, Domingo}
        enum mes { Enero = 1, Febreo,Marzo, Abril,Mayo, Junio , Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre};

        enum color {Rojo = 4, Negro, Purpura};
        static void Main(string[] args)
        {
            // se debe tener en cuenta de antemano el numero  finito de opciones o los valores poibles,

            //Variables
            semana elDia = semana.Viernes;

            String mensaje = "El Dia es: ";
            mensaje = mensaje + elDia.ToString();

            Console.WriteLine(mensaje);

            //ahora mostrar como la posicion del valor de la enumeracion 
            int valor = 0;

            valor = (int)elDia;
            Console.WriteLine(valor);

            //casi siempre la enumeracion empiza en 0 para ellos se arregla la enumarcion 

            // enum semana {Lunes = 5,Martes,Miercoles,Jueves,Viernes, Sabado, Domingo}

            //typecast

            int salario = 0;
            int pagoDia = 200;

            salario = pagoDia * ((int)elDia);

            if((int)elDia == 3)
            {

            }

            //ejercicio de enum
            //variables 
            mes miMes = 0;

            //asignamos un valor 
            miMes = mes.Mayo;

            //pasamos de enumeracion a entero 
            int numero = (int)miMes;

            //mostramos la informacion 
            Console.WriteLine("El mes es: {0}, con valor de : {1}", miMes, numero);

            //creamos variables de tipo color

            color miColor = color.Rojo;

            //Pasamos el valor a numero 
            numero = (int)miColor;

            //Mostramos la informacion 
            Console.WriteLine("El color es: {0}, con valor de {1}", miColor, numero);

        }
    }
}
