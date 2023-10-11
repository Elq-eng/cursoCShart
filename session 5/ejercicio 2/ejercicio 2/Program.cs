using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Ejercicios de tareas en session 2
 * Resumen:
 * Elquin Cascavita Rios
 * version 4.7.2
 */
namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables 
            byte opcion;
            string area;
            double resultado;
            (double num1A, double numB1) Calculo;

            //bucle para escoger la opcion del area que se quiere hallar
            do
            {
                Console.WriteLine("A que figura le quiere hallar el area: ");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Triangulo");
                Console.WriteLine("3. Circulo");
                opcion = Byte.Parse(Console.ReadLine());


            }
            while ((opcion < 1) || ( opcion > 4));

            switch (opcion)
           {
                case 1:
                    //para saber cuantas veces se tiene que llamar la funcion 
                    area = "Cuadrado";
                    Calculo = IngresarValor(area);

                    resultado = AreaCuadrado(Calculo.num1A, Calculo.numB1);

                    //mostrar resutlad
                    Console.WriteLine("El area del Cuadrado es: {0}", resultado);
                    break;
                case 2:

                    //para saber cuantas veces se tiene que llamar la funcion 
                    area = "Triangulo";
                    Calculo = IngresarValor(area);

                    resultado = AreaTriangulo(Calculo.num1A,Calculo.numB1);

                    //mostrar resutlad
                    Console.WriteLine("El area del Triangulo es: {0}", resultado);

                    break;
                case 3:
                    //para saber cuantas veces se tiene que llamar la funcion 
                    area = "Circulo";
                    Calculo = IngresarValor(area);


                    AreaCirculo(Calculo.num1A);

                    break;

            
            
            }
            
        }
        static void AreaCirculo(double numC1)
        {
            //Variables
            double pi = Math.PI, resultado;

            //Calculo del area del circulo
            resultado = Math.Pow(numC1, 2) * pi;

            //mostrar resultado 
            Console.WriteLine("El resultado del circulo es: {0}", resultado);

        }

        static double AreaTriangulo(double numA, double numB)
        {
            //variables
            double resultado=0;

            //calculo del area del teiangulo
            resultado = (numA * numB) / 2;

            return resultado;
        }

        static double AreaCuadrado(double numA, double numB)
        {
            //variables
            double resultado = 0;

            //calculo del area del teiangulo
            resultado = numA * numB;

            return resultado;

        }

        static  (double,double) IngresarValor(string AreaPa)
        {
            double num1=0, num2 = 0;

            if ((AreaPa == "Cuadrado") || (AreaPa == "Triangulo"))
            {
                //ingresar los valores de la longitud del cuadrado
                Console.WriteLine("Ingresar el primer valor del {0}",AreaPa);
                num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el segundo valor del {0}", AreaPa);
                num2 = Double.Parse(Console.ReadLine());

            }
            else
            {
                //ingresar los valores de la longitud del cuadrado
                Console.WriteLine("Ingresar el radio del Circulo");
                num1 = Double.Parse(Console.ReadLine());
               
            }

            return (num1,num2);
        }


    }
}
