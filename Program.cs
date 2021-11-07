using System;

namespace sda_csharp_exercises
{
    class Program
    {
        public static bool CheckDigit(int[] pesel)
        {
            int[] scales = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

            // Liczenie sumy iloczynów
            int sumOfProducts = 0;
            for (int i = 0; i < scales.Length; i++)
            {
                sumOfProducts += pesel[i] * scales[i];
            }

            // Obliczanie modulo
            int modulo = sumOfProducts % 10;

            // Jeżeli modulo jest 0 to cyfra kontrolna też wynosi 0
            int checkDigit;
            if (modulo == 0)
            {
                checkDigit = 0;
            }
            else
            {
                checkDigit = 10 - modulo;
            }

            // Sprawdzenie czy cyfra kontrolna jest równa ostatniej cyfrze peselu
            if (checkDigit == pesel[pesel.Length - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int[] pesel = { 5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3 };
            int[] pesel2 = { 5, 5, 0, 3, 0, 1, 0, 1, 2, 3, 0 };
            int[] pesel3 = { 5, 5, 0, 3, 0, 1, 0, 1, 2, 3, 1 };

            bool isPeselOk = CheckDigit(pesel);
            bool isPesel2Ok = CheckDigit(pesel2);
            bool isPesel3Ok = CheckDigit(pesel3);

            Console.WriteLine(isPeselOk);
            Console.WriteLine(isPesel2Ok);
            Console.WriteLine(isPesel3Ok);
        }
    }
}

