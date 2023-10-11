using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Juego tictactoe
 * resumen
 * elquin cascavita
 * version 4.7.2
 */
namespace juego_tictactoee
{
    class Program
    {
        //creamos un arreglo bidimensional para el tablero
        static int[,] tablero = new int[3, 3];

        //creamos un arreglo para los simbolos del tablero: espacio en blanco, jug.1 jug.2

        static char[] simbolo = { ' ', 'O', 'X' };

        static void Main(string[] args)
        {

            bool terminado = false;

            //llmar tablero
            DibujarTablero();
            Console.WriteLine("Jugador 1 = O\nJugador 2= X");

            do
            {
                //le da el runo a jugador 1
                PreguntarPosicion(1);

                //dibujar la cacina 
                DibujarTablero();

                //comprobar si ha ganado la partida
                terminado = ComprobarGanador();

                if (terminado == true)
                {
                    Console.WriteLine("El jugadir 1 ha ganado");

                }
                else //de lo contrario hay empate
                {
                    terminado = ComprobarEmpate();
                    if(terminado == true)
                    {
                        Console.WriteLine("Esto es un empate!");
                    }
                    else
                        {
                        PreguntarPosicion(2);
                        DibujarTablero();
                        //comprobar si ha ganado la partida el jugador
                        terminado = ComprobarGanador();

                        if(terminado == true)
                        {
                            Console.WriteLine("El jugador 2 ha ganado");
                        }
                        }
                    
                }
            } while (terminado == false);

        }
        //cierre de main 
        static void DibujarTablero()
        {
            int fila = 0;
            int columna = 0;

            Console.WriteLine(); //espacio antes de dibujar el tablero
            Console.WriteLine("------------");
            for (fila = 0; fila < 3; fila++)
            {
                Console.Write("|"); //Dibujar la segunda linea horizontal

                for (columna = 0; columna < 3; columna++)
                {
                    //asigna un espacio, o ,x segun corresponda
                    Console.Write(" {0} |", simbolo[tablero[fila, columna]]);

                }
                Console.WriteLine(" ");
                Console.WriteLine("------------");
            }

        }

        //pregunta donde escribir y lo dibuja en el tablero
        static void PreguntarPosicion(int jugador)
        {
            int fila, columna;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Turno del jugador: {0}", jugador);

                //pedimos el numero de final

                do
                {
                    Console.Write("Selecciona la fila (1 a 3): ");
                    fila = int.Parse(Console.ReadLine());
                } while ((fila < 1) || (fila > 3));//el codigo se ejecuta mientras no se cupla la condicion 
                do
                {
                    Console.Write("Seleccion la columna (1 a 3): ");
                    columna = int.Parse(Console.ReadLine());
                } while ((columna < 1) || (columna > 3));

                if (tablero[fila - 1, columna - 1] != 0)
                {
                    Console.Write("Casilla ocupada");
                }

            } while (tablero[fila - 1, columna - 1] != 0);
            //si todo es correcto, se le asigna al conetarlo algo de 
            tablero[fila - 1, columna - 1] = jugador;
        }

        static bool ComprobarGanador()
        {
        int fila = 0, columna = 0;
        bool  tictactoe = false;

        for (fila = 0; fila<3 ; fila++)
            {
                if ((tablero[fila, 0] == tablero[fila, 1]) && (tablero[fila, 0] == tablero[fila, 2])
                    && (tablero[fila, 0] != 0))
                {
                    tictactoe = true;
                }

            }

        //Verticales
        for (columna = 0; columna <3; columna ++)
            {
                if((tablero[0,columna] == tablero[1, columna]) && (tablero[0,columna] == tablero[2, columna])
                    && (tablero[0, columna] != 0))
                {
                    tictactoe = true;
                }
            }

        if ((tablero[0, 0] == tablero[1, 1]) && (tablero[0, 0] == tablero[2, 2])
                    && (tablero[0, 0] != 0))
        {
            tictactoe = true;
        }

        if ((tablero[0, 2] == tablero[1, 1]) && (tablero[0, 2] == tablero[2, 2])
                    && (tablero[0, 2] != 0))
        {
            tictactoe = true;
        }

            return tictactoe;

        }

        //devuelve "true " si hay empate

        static bool ComprobarEmpate()
        {
            bool hayEspacio = false;
            int fila = 0;
            int columna = 0;


            for (fila = 0;fila < 3; fila++)
            {
                if (tablero[fila,columna] == 0)
                {
                    hayEspacio = true;
                }
            }

            return !hayEspacio;
        }
    }
}
