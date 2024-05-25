using System;

class Program
{
    static int[,] tablero;
    static int puntaje;
    static int posicionX;
    static int posicionY;
    static int tamanoTablero;

    static void Main(string[] args)
    {
        InicializarJuego();

        bool salir = false;
        while (!salir)
        {
            // ORGANIZAR TABLERO

            MostrarTablero();

            Console.WriteLine("Puntos:" + puntaje);
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1. Flecha Derecha");
            Console.WriteLine("2. Flecha Izquierda");
            Console.WriteLine("3. Flecha Arriba");
            Console.WriteLine("4. Flecha Abajo");
            Console.WriteLine("Tecla Esc Para salir del juego");

            //CONSOLA

            ConsoleKeyInfo tecla = Console.ReadKey();
            Console.Clear();


            switch (tecla.Key)
            {
                case ConsoleKey.RightArrow:
                    MoverJugador(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    MoverJugador(0, -1);
                    break;
                case ConsoleKey.UpArrow:
                    MoverJugador(-1, 0);
                    break;
                case ConsoleKey.DownArrow:
                    MoverJugador(1, 0);
                    break;
                case ConsoleKey.Escape:
                    salir = true;
                    break;

            }
        }
    }

    static void InicializarJuego()
    {
        //Tamaño Tablero

        tamanoTablero = 5; // Tamaño del tablero
        tablero = new int[tamanoTablero, tamanoTablero];
        Random generadorAleatorio = new Random();
        for (int fila = 0; fila < tamanoTablero; fila++)
        {
            for (int columna = 0; columna < tamanoTablero; columna++)
            {
                tablero[fila, columna] = generadorAleatorio.Next(1, 10);
            }
        }
        posicionX = 0;
        posicionX = 0;
        puntaje = 0;
    }

    static void MostrarTablero()
    {
        for (int fila = 0; fila < tamanoTablero; fila++)
        {
            for (int columna = 0; columna < tamanoTablero; columna++)
            {
                if (fila == posicionX && columna == posicionY)
                {
                    Console.Write("0 ");
                }
                else
                {
                    Console.Write(tablero[fila, columna] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static void MoverJugador(int desplazamientoX, int desplazamientoY)
    {
        int nuevaPosX = posicionX + desplazamientoX;
        int nuevaPosY = posicionY + desplazamientoY;

        if (nuevaPosX >= 0 && nuevaPosY < tamanoTablero && nuevaPosY >= 0 && nuevaPosY < tamanoTablero)
        {
            puntaje += tablero[nuevaPosX, nuevaPosY];
            tablero[posicionX, posicionY] = 0;
            posicionX = nuevaPosX;
            posicionY = nuevaPosY;
        }
    }
}