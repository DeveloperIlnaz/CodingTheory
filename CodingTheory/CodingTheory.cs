using System;
using System.Collections.Generic;

namespace CodingTheory
{
    /// <summary>
    /// Наука о кодирования.
    /// </summary>
    public static class CodingTheory
    {
        /// <summary>
        /// Перевод из десятичной системы.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="system"></param>
        /// <returns></returns>
        public static List<int> TranslationFromDecimal(int number, int system)
        {
            var numbers = new List<int>();

            for (var current = number; current > 0; current /= system)
            {
                numbers.Add(current % system);
            }

            numbers.Reverse();

            return numbers;
        }
        /// <summary>
        /// Перевод в десятичную систему.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="system"></param>
        /// <returns></returns>
        public static int TranslationToDecimal(List<int> numbers, int system)
        {
            var result = 0;

            for (var index = 0; index < numbers.Count; index++)
            {
                var current = numbers[(numbers.Count - 1) - index];

                result += (int)(current * Math.Pow(system, index));
            }

            return result;
        }
    }
}