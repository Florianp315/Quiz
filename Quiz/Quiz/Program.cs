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

                    


        