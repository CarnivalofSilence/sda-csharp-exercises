using System;

namespace sda_csharp_exercises
{


    class Program
    {
        static void Main(string[] args)
        // E03
        //Napisz funkcję tworzącą ciąg arytmetyczny o podanych: długości, pierwszym elemencie, różnicy ciągu.
        {
            CiagArytmetyczny();
      
        }

        public static void CiagArytmetyczny() 
        {

            Console.WriteLine("Wpis długość ciągu arytmetycznego");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz pierwszy element ciągu");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wpisz różnicę ciągu");
            int element = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ciąg arytmetyczny =>");
            Console.Write($" {first}");
            for (int i = 1; i < lenght; i++)
            {
                Console.Write($" {first + (i * element)}");
            }
        }
    
    
    }

}
