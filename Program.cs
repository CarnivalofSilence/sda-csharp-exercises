using System;

namespace sda_csharp_exercises
{

    /*Napisz metodę, która będzie wyświetlała prosty cennik danego produktu.
    W zależności od ceny produktu oraz liczby linii, którą ktoś sobie życzy widzieć wydrukuj cennik w
    postaci:
    Liczba sztuk: 1 łączna cena: 5zł
    Liczba sztuk: 2 łączna cena: 10zł
    Liczba sztuk: 3 łączna cena: 15zł*/
   
    class Program
    {
        static void Main(string[] args)
        {
            ViewPrice();
        }

        static void ViewPrice()
        {
            Console.Write("Podaj cenę produktu: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę linii: ");
            int linesToPrint = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= linesToPrint; i++)
            {
                Console.WriteLine($"Ilość podanych sztuk: {i} Łącznie: {price * i}zł");
            }







        }
    }
}
