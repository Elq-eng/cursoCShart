using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*Arrays
 * Resumen= se hace la declaracion de arrays tipo int duble pero tambien tipo objeto, que se hace una instancia de la clase y se rea diferentes objetos que le permiten tener acceso a los campos de clase, luego se implementa un for para imprimir en pantalla todo lso datos, el foreach solo sirve para mostrar lo elementos de un array si quiere modificarlos toca el for clasico
 * Elquin Cascavita Rios
 * version 4.7.2
 */

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades = new int[8];

            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 43;
            edades[3] = 34;

            int[] edades1 = { 15, 27, 98, 34 };

            Console.WriteLine(edades1[2]);

            // array implicitos

            var datos = new[] {"Juan", "Diaz", "España"};

            //array de objetos
            Empleado[] arrayEmpleados = new Empleado[3];

            //crear el objeto y luego agregarlo en el array
            Empleado e = new Empleado("pedro", 23);
            arrayEmpleados[0] = new Empleado("Sara", 23);
            arrayEmpleados[1] = e;
            arrayEmpleados[2] = new Empleado("Perez", 223);

            //array de tipos o clases anonimas

            var personas = new[]
            {
                new{Nombre = "Juan", Edad = 19},
                new{Nombre = "Pedro", Edad = 29},
                new{Nombre = "choxo", Edad =3}

            };

            //for clasico
            for(int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getinfo());
            }

            //foreach (iterador (debe ser del mismo tipo dela rray ) in "array")
            //tipo de objetos
            foreach(Empleado variable in arrayEmpleados)
            {
                Console.WriteLine(variable.getinfo());
            }
            //tipo string
            foreach (String variable in datos)
            {
                Console.WriteLine(variable);
            }
        }
    }

    class Empleado
    {
        //campos de clase 
        private string nombre;
        private int edad;
        public Empleado(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public string getinfo()
        {
            return "Nombre del empleado " + nombre + " tiene edad de: " + edad;
        }

    }
}
