using System;

namespace sda_csharp_exercises
{
    /*
    Namaluj trójkąt z gwiazdek o zadanej liczbie linii.Dopełnij pod spodem odwróconym trójkątem tak
    jak w przykładzie poniżej.Zwróć uwagę, że linia z maksymalną liczba gwiazdek jest tylko jedna.
    Np.dla 3 linii:
    *
    **
    ***
    **
    **/

    class Program
    {
        public static void PrintTriangle(int width, char character)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine("");
            }
            for (int i = width - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(character);
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Podaj szerokość podstawy: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj znak do budowy trójkąta: ");
            char character = Convert.ToChar(Console.ReadLine());

            PrintTriangle(width, character);
        }
    }
}
