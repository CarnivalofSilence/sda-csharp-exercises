using System;

namespace sda_csharp_exercises
{
    /* Napisz funkcję do obliczania potęgi o zadanych podstawie i wykładniku.
   *   zabezpiecz swój program tak, aby dla ujemnego wykładnika wyświetlał odpowiedni komunikat.*/


    class Program
    {


        static void Main(string[] args)
        {
            Potegowanie();
        }

        static void Potegowanie()
        {
            Console.WriteLine("Podaj podstawę liczby");
            int podstawa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj wykładnik:");
            int wykladnik = Convert.ToInt32(Console.ReadLine());


            if (wykladnik < 0)
            {
                Console.WriteLine("Wykładnik nie może być ujemny");
                return;
            }

            int result = 1;

            for (int i = 0; i < wykladnik; i++)
            {
                result *= podstawa;
            }

            Console.WriteLine(result);
        }

       


    }
    
}
