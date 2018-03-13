using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ALabs.Algorithms.Converting
{
    public static class ConvertingAlgorithms
    {
        /// <summary>
        /// Преобразование строки в целочисленный массив
        /// </summary>
        /// <param name="value">Строка</param>
        /// <returns>Целочисленный массив</returns>
        public static int[] StringToIntArray(string value)
        {
            string text = string.Empty;
            text = Regex.Replace(value.Trim(' '), @"\s+", " ");
            List<int> list = new List<int>();
            foreach (string i in text.Split(' '))
                if (int.TryParse(i, out int Number)) list.Add(Number);
            return list.ToArray();
        }

        /// <summary>
        /// Перевод целочисленного массива в строку
        /// </summary>
        /// <param name="value">Целочисленный массив</param>
        /// <returns>Строка</returns>
        public static string IntArrayToString(int[] value)
        {
            string text = string.Empty;
            for (int index = 0; index < value.Length; index++)
                text += value[index] + " ";
            return text;
        }
    }
}
