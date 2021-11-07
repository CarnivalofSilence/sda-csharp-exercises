using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace sda_csharp_exercises
{
    class Program
    {

/*    E06
    Dla podanego ciągu znaków oznaczającego hasło, sprawdź, czy spełnia on następujące warunki
    złożoności hasła:
    • długość co najmniej 6 znaków
    • występują co najmniej jedna duża i jedna mała litera
    • występuje co najmniej jedna cyfra
    • występuje co najmniej jeden znak specjalny spośród następujących: &*$#*/
    
            public static bool passwordChecker(string password)
            {
                return Regex.IsMatch(password, "[a-z]") && Regex.IsMatch(password, "[A-Z]") && Regex.IsMatch(password, "[&*$#]") && password.Length >= 6;

            }
            static void Main(string[] args)
            {
                Console.WriteLine(passwordChecker("Lubie$"));
                Console.WriteLine(passwordChecker("a"));
                Console.WriteLine(passwordChecker("Lubie dolary"));
                Console.WriteLine(passwordChecker("lubie male litery"));
                Console.WriteLine(passwordChecker("JESTEM ZLY"));
            }
        }
    }

    

