using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101); // Genera un número aleatorio entre 1 y 100

        Console.WriteLine("¡Bienvenido al juego de adivinanza de números!");
        Console.WriteLine("Estoy pensando en un número entre 1 y 100. ¿Puedes adivinar cuál es?");

        int intentos = 0;
        int intentoUsuario;

        do
        {
            Console.Write("Introduce tu adivinanza: ");
            if (int.TryParse(Console.ReadLine(), out intentoUsuario))
            {
                intentos++;

                if (intentoUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El número que estás buscando es mayor.");
                }
                else if (intentoUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El número que estás buscando es menor.");
                }
                else
                {
                    Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número válido.");
            }

        } while (intentoUsuario != numeroAleatorio);

        Console.WriteLine("¡Gracias por jugar!");
    }
}

