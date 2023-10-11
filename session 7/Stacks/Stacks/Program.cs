using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*Marices
 * Resumen: show how is declare the variables, how assign values in matrices 
 * Elquin Cascavita Rios 
 * version 4.7.2
 */

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de stacks
            Stack miTorre = new Stack();

            //agragar informacion al Stack
            miTorre.Push(4);
            miTorre.Push(5);
            miTorre.Push(6);
            miTorre.Push(8);

            //sacar informacion dle stack 

            int value = 0;

            value = (int)miTorre.Pop();
            Console.WriteLine(value);

            //como recorrer el Stack
            foreach(int n in miTorre)
            {
                Console.WriteLine("{0} ", n);
            }
            
            //Contar los elementos del Stack
            int cantidad =  miTorre.Count;
            Console.WriteLine("{0} ", cantidad);

            //si se quiere limpiar todo el stack
            miTorre.Clear();

            //tratar de encontrar u valor 
            bool enStack = miTorre.Contains(5);
            Console.WriteLine(enStack);

            //---------------------------------------------------------------------------------------------------------
            //ejercicio de Stack 
            //determinar variables
            int opcion = 0;
            string valor = "";
            int numero = 0;
            bool encontrado = false;

            //se declara el Stack
            Stack miOpcion = new Stack();

            //mostramos el menu
            do
            {
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Dame la opcion: ");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        //pedimos el valor que se vaya a introducir 
                        Console.Write("Dame el valor a introducir: ");
                        numero = int.Parse(Console.ReadLine());

                        miOpcion.Push(numero);
                        break;
                    case 2:
                        //pedimos el valor que se vaya a introducir 
                        Console.Write("Que numero quieres sacar: ");
                        numero = int.Parse(Console.ReadLine());

                        numero = (int)miOpcion.Pop();
                        break;
                    case 3:
                        miOpcion.Clear();
                        Console.Write("Se ha borrado todo el Stack");
                        break;
                    case 4:
                        //Quiere encontrar algun numero 
                        Console.Write("El numero ingresado se buscara y sera True/False si esta o no: ");
                        numero = int.Parse(Console.ReadLine());
                        enStack = miTorre.Contains(numero);
                        Console.Write("Encontrado - {0}",enStack);
                        break;
                    case 5:

                        break;



                }
                foreach(int n in miOpcion)
                {
                    Console.WriteLine(" {0} ", n);
                }
                Console.WriteLine("");
                Console.WriteLine(".........");


            } while (opcion != 5);
           





        }
    }
}
