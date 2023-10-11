using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*Clases
 * Resumen:
 * Elquin Cascavita
 * Version 4.7.2
 */
namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {

            //cuando se crea un objeto se llama instanciacion, la clase se le conoce como el plano del objeto, el objeto la parte que se quiere crear

            //se instancia la clase 
            cubo miCubo = new cubo();
            
            //se le asigna el valor a un dato o atributo de objeto cubo
            miCubo.lado = 5;

            //invocacion del metodo 
            miCubo.CalcularArea();
            miCubo.CalcularVolumen();

            //imprimir los datos
            Console.WriteLine("Area = {0}, Volument = {1}", miCubo.area, miCubo.volumen);


            //segundo cubo
            cubo miCubo2 = new cubo();

            //Asignamos los atributos
            miCubo2.lado = 7;

            //invocamos metodos 
            miCubo2.CalcularArea();
            miCubo2.CalcularVolumen();

            //imprimir los datos
            Console.WriteLine("Area = {0}, Volument = {1}", miCubo2.area, miCubo2.volumen);

            //se trabaja ahora con prima 

            //se instancia prisma
            Prisma miPrisma = new Prisma();
            //se instancia otro objeto
            Prisma miPrisma2 = new Prisma(4, 3, 2);

            //datos
            miPrisma.Ancho = 7;

            //invocar los metodos del prisma 
            miPrisma.CalcularArea();
            miPrisma.CalcularVolumen();
            //invocar los metodos del prisma2
            miPrisma2.CalcularArea();
            miPrisma2.CalcularVolumen();

          //imprimir los datos
            Console.WriteLine(miPrisma.ToString());

            //imprimir solo algunos resultados
            miPrisma.ImprimirResultado();
            //imprimir los datos
            Console.WriteLine(miPrisma2.ToString());
        }
    }

    //declaracion de clases 
    class cubo
    {
        //declaramos los datos

        public int lado;
        public int area;
        public int volumen;
        
        //metodo para calcular el area 
        public void CalcularArea()
        {
            area = (lado * lado) * 6;
        }

        public void CalcularVolumen()
        {
            volumen = lado * lado * lado;
        }
    }

    class Prisma
    {
        //declarar los datos
        private int ancho;
        private int alto;
        private int espesor;
        private int area;
        private int volumen;

        //propiedades lectura, escrituta, lec/escritura - get , set 

        //definimos las propiedades
        //propiedades de lectura y escriitura
        public int Ancho
        {
            get
            {
                return ancho;
            }

            set
            {
                if (value <= 0)
                    ancho = 1;
                else
                    ancho = value;
            }
        }

        public int Alto
        {
            get
            {
                return alto;
            }

            set
            {
                if (value <= 0)
                    alto = 1;
                else
                    alto = value;
            }
        }

        public int Espesor
        {
            get
            {
                return espesor;
            }

            set
            {
                if (value <= 0)
                    espesor = 1;
                else
                    espesor = value;
            }
        }

        //propiedades de lectura 
        public int Area
        {
            get
            {
                return area;
            }
        }

        public int Volumen
        {
            get
            {
                return volumen;
            }
        }
        
        //constructor 
        public Prisma()
        {
            //Datos necesarios
            String valor = "";

            //pedimos los datos 
            Console.Write("Dame el ancho: ");
            ancho = int.Parse(Console.ReadLine());

            Console.Write("Dame el alto: ");
            alto = int.Parse(Console.ReadLine());

            Console.Write("Dame el espesor: ");
            espesor  = int.Parse(Console.ReadLine());

        }
        //mas de un constructor, se selecciona automaticamente

        public Prisma(int cAncho,int cAlto,int cEspesor)
        {
            //asignamos los valores 

            ancho = cAncho;
            alto = cAlto;
            espesor = cEspesor;
        }

        //definimos los metodos 
        public void CalcularVolumen()
        {
            volumen = ancho * alto * espesor;
        }
        public void CalcularArea()
        {
            int a1 = 0, a2 = 0, a3 = 0;

            a1 = 2 * CalcularRectangulo(ancho, alto);
            a2 = 2 * CalcularRectangulo(ancho, espesor);
            a3 = 2 * CalcularRectangulo(alto, espesor);
            area = a1 + a2 + a3; 
        }

        //los metodos privados solo son privados dentro de la clase o sea solo se pueden utilizar dentro del misma clase
        private int CalcularRectangulo(int a, int b)
        {
            return (a * b);
        }

        public override string ToString()
        {
            String mensaje = "";

            mensaje += "Ancho " + ancho.ToString() + " Alto " + alto.ToString() + " Espesor " + espesor.ToString() + " Area " + area.ToString() + " Volumen " + volumen.ToString();

            return mensaje;
        }
        //ahora solo imprimir algunos datos
        public void ImprimirResultado()
        {
            Console.WriteLine("El area es: {0} y el volumen es {1}", area, volumen);
        }

    }



}
