using System;

    /*Napisz funkcję, która „zakoduje” podany napis w „l33t speak”, tzn. zamieni odpowiednio litery
    (zarówno małe jak i wielkie):
    A = 4
    E = 3
    I = 1
    O = 0(zero)
    S = $
    Przykładowo: dla napisu „Asia” otrzymamy „4$14”.
    Napisz również funkcję, która „odkoduje” napis (czyli z „4$14” otrzymamy „asia”).
    Czy potrafisz w swoim rozwiązaniu wykorzystać dwie poniższe tablice?
    char[] leetLetters = { '4', '3', '1', '0', '$'};
    char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };*/

namespace sda_csharp_exercises
{

    class Program
    {
		public static void Encryption(string text)
		{
			char[] leetLetters = { '4', '3', '1', '0', '$' };
			char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

			string newText = text;
			for (int i = 0; i < leetLetters.Length; i++)
			{
				newText = newText.Replace(naturalLetters[i], leetLetters[i]);
			}
			Console.WriteLine(newText);
		}

		public static void Decryption(string text)
		{
			char[] leetLetters = { '4', '3', '1', '0', '$' };
			char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

			string newText = text;
			for (int i = 0; i < leetLetters.Length; i++)
			{
				newText = newText.Replace(leetLetters[i], naturalLetters[i]);
			}
			Console.WriteLine(newText);
		}


		static void Main(string[] args)
		{
			char[] leetLetters = { '4', '3', '1', '0', '$' };
			char[] naturalLetters = { 'a', 'e', 'i', 'o', 's' };

			Encryption("Asia");
			Decryption("4$14");
		}
	}
}


