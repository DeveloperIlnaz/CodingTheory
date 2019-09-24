using System;
using System.Collections.Generic;

namespace CodingTheory
{
    internal class Program
    {
        private static void ShowTranslationFromDecimal(int number, int system)
        {
            foreach (var current in CodingTheory.TranslationFromDecimal(number, system))
            {
                Console.Write($"{current}");
            }

            Console.WriteLine();
        }
        private static void ShowTranslationToDecimal(List<int> numbers, int system)
        {
            Console.WriteLine(CodingTheory.TranslationToDecimal(numbers, system));
        }
        private static void Main(string[] args)
        {
            // Перевод из десятичной системы счисления, в двоичную систему счисления.
            ShowTranslationFromDecimal(19, 2);

            Console.WriteLine();

            // Перевод в десятичную систему счисления, из двоичной системы счисления.
            ShowTranslationToDecimal(new List<int>() { 1, 0, 0, 1, 1 }, 2);

            Console.ReadKey();
        }
    }
}