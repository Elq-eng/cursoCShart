using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*metodos 
 * Resumen
 * Elquin Cascavita 
 * version .net 4.72
 * 
 */
namespace metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            //ejercicio de seleccion matematica
            //Variable
            decimal resultado, num1AR, num2AR; //almacena el valor del metodo resta
            int opcion;

            //declaramos una tupla
            (decimal num1, decimal num2, decimal resultados) numeros;

            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");

                Console.Write("escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            while ((opcion < 1) || (opcion > 4));

            //hacer la operacion segun la opcion escogida

            switch (opcion)
            {

                case 1:
                    Sumar();
                    break;
                case 2:

                    numeros = Restar();
                    Console.WriteLine("La resta de los numeros {0} - {1} es: {2}", numeros.num1, numeros.num2, numeros.resultados);
                        
                    break;
                case 3:

                    num1AR = IngresarNumero("Ingrese el primer numero: ");
                    num2AR = IngresarNumero("Ingrese el segundo numero: ");

                    //invocacion del método con argumento
                    Multiplicacion(num1AR, num2AR);
                    break;
                case 4:
                    //pedir el valor de ambos numeros

                    num1AR = IngresarNumero("Ingrese el primer numero: ");
                    num2AR = IngresarNumero("Ingrese el segundo numero: ");

                    resultado = Dividir(num1AR, num2AR);
                    Console.WriteLine("La Division de los numeros {0} / {1}  es: {2}", num1AR, num2AR, resultado);
                    break;


            }
            


        }

        //[modificador][tipos][identificador][parametros]
        static void Nombre ()
        {
            //instrucciones
        }

        /*Tipos de metodos
         * 1. Metodos sin aprametros ni tipo
         * 2. Metodos con parametros
         * 3. Metodos que devuelven un tipo
         * 4. Metodos con parametros y que devuelven un tipo
         */

        //declarar los métodos 
        // metodo sin retornar nada, sin parametros
        static void Sumar()
        {
            //variables del método Sumar()
            decimal num1, num2, resultado;

            //pedir el valor de ambos numeros

            Console.Write("Ingresa el primer numero: ");
            num1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Decimal.Parse(Console.ReadLine());

            //calculamos operacion
            resultado = num1 + num2;

            Console.WriteLine("la suma de los numero {0} + {1} = {2}", num1, num2, resultado);

        }

        // metodo con retorno
        static (decimal,decimal,decimal) Restar()
        {
            //variables del método Sumar()
            decimal num1, num2, resultado;

            //pedir el valor de ambos numeros

            Console.Write("Ingresa el primer numero: ");
            num1 = Decimal.Parse(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            num2 = Decimal.Parse(Console.ReadLine());

            //calculamos operacion
            resultado = num1 - num2;


            //devolvemos multiples tipos 
            return (num1,num2,resultado);
           

        }

        //metodo con parametros
        static void Multiplicacion(decimal num1Pa,decimal num2Pa)
        {

            decimal resultado;

            //calculamos operacion
            resultado = num1Pa * num2Pa;

            Console.WriteLine("la Multiplicación de los numero {0} * {1} = {2}", num1Pa, num2Pa, resultado);


        }

        //metodo con parametros y con retorno

        static decimal Dividir(decimal num1Pa, decimal num2Pa)
        {

            decimal resultado;

            if (num2Pa != 0)
            {
                resultado = num1Pa / num2Pa;
            }

            else
            {
                Console.WriteLine("No se puede dividir entre cero");
                resultado = 0;
            }                

            return resultado;
        }

        static decimal IngresarNumero(String peticion)
        {
            //variables local
            decimal numero;

            //pedimos el valor segun corresponda 
            Console.Write(peticion);

            //Convertimos y asignamos 
            numero = Convert.ToDecimal(Console.ReadLine());

            //Devolvemos el valor de tipo decimal
            return numero; 
        }
    }
}
