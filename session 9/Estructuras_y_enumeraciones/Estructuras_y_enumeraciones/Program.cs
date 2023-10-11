using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Estructuras y enumeraciones
 * Resumen: las estructuras soon muy utiles para crear n almacenamiento de cambios en diferentes espacios, se pueden crear arrays para la implementacion, 
 * Elquin Cascavita Rios
 * Version 4.7.2 
 * 
 */
namespace Estructuras_y_enumeraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo de datos, donde se alamcena las estructuras, se definen los campos

            //definir la estructura 
            /* acceso struct nombre
         {
             acceso tipo campo1;
             acceso tipo campo 2;
                 ....
                 El acceso es public, private, 

         }*/
            //crear un nuevo tipo de variable 
            Agenda amigo;

            Agenda amigo1, amigo2, amigo3;

            //se crea una estructura con la estructura 
            Agenda[] amigos = new Agenda[15];
            Agenda[] clientes = new Agenda[3];

            //acceso al campo desde la estructura
            //variableEstructura.campo

            amigos[1].edad = 25;
            amigos[1].nombre = "Elquin";
            amigos[1].telefono = "41244224";

            //mostrar toda la infomacio
            Console.WriteLine(amigos[1].ToString());


            //probar el if del constructor 

            Agenda amigos5 = new Agenda("Mauricio", 21, "41244asassa224","Lomas",32);
            Console.WriteLine(amigos5.ToString());


            //probar el nuevo constructor 
            Agenda amigos6 = new Agenda("Mauricio", 21);
            Console.WriteLine(amigos6.ToString());

            //probar el nuevo constructor 
            Agenda amigos7 = new Agenda("Marcos");
            Console.WriteLine(amigos7.ToString());


            //Console.WriteLine("La edad es {0} ", amigo.edad);




            //para mostrar todos lo campos de la cadena se debe convertir en cadena 

            //crear una variable 
            /*Agenda amigo5 = new Agenda("Pedro", 25, "2342342");

            Console.WriteLine(amigo5.ToString());
            */
        }
        public struct Agenda
        {
         


            public String nombre;
            public int edad;
            public String telefono;
            public Direccion domicilio;

            //constructor 
            public Agenda(String pNombre, int pEdad, String pTelefono,String pCalle, int pNumero)

            {
                nombre = pNombre;
                edad = pEdad;

                //validar la informacion 
                if(pTelefono.Length == 10)
                {
                    telefono = pTelefono;
                }
                else
                {
                    telefono = "Telefono no es valido";
                }

                //instaciar la estructura enlazada 

                domicilio = new Direccion(pCalle, pNumero);
            }//sobre carga del constructor
            
            public Agenda (String pNombre, int pEdad)
            {
                nombre = pNombre;
                edad = pEdad;
                telefono = "Sin telefono";
                domicilio = new Direccion("Sin direccion", 0);

            }
            //nuevo constructor 

            public Agenda(String pNombre)
            {
                nombre = pNombre;
                
                //asignacion de la edad
                Console.Write("Dame La edad: ");
                edad = int.Parse(Console.ReadLine());

                //pedimos el telefono 
                Console.Write("Dame el telefono: ");
                telefono = Console.ReadLine();
               
                if (telefono.Length != 10)
                {
                    telefono = "Telefono no valido";
                }
               domicilio = new Direccion("Sin direccion", 0);
            }



            //programar el metodo ToStringen 

            public override string ToString()
            {

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("Nombre: {0}, Edad {1}, Telefono: {2}", nombre, edad, telefono
                    );

                //agregando la cadena proveniente de domicilio 
                sb.Append(domicilio.ToString());
                return (sb.ToString());

            }
        }//se acaba la primera estructura

        //segunda estructura 
        public struct Direccion
        {
            public String calle;
            public int numero;

            public Direccion(String pCalle, int pNumero)
            {
                calle = pCalle;
                numero = pNumero;
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendFormat(", Direccion: {0} #{1}",calle,numero);

                return (sb.ToString());
            }

        }
    }
}
