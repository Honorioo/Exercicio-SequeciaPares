using System;

namespace Exercicio_SequeciaPares_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0, numeros;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Números pares entre 0 e ? ");
            numeros = int.Parse(Console.ReadLine());
            Console.ResetColor();

            while (pares <= numeros)
            {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write($"{ pares } ");
                pares = pares + 2;
            Console.ResetColor();
            }
        }
    }
}