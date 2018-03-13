using System;

namespace ALabs.Algorithms.FindImage
{
    public class FindImageAlgorithms
    {
        /// <summary>
        /// Алгоритм поиска образа в строке
        /// </summary>
        /// <param name="linetext">Строка, в который осуществляется поиск</param>
        /// <param name="imagetext">Обра3</param>
        /// <param name="Registr">Учитывать ли регистр</param>
        /// <returns></returns>
        public static int searchImage(string linetext, string imagetext, bool Registr)
        {
            if (imagetext.Length > linetext.Length || string.IsNullOrWhiteSpace(imagetext) || string.IsNullOrWhiteSpace(linetext))//Проверка входных данных на корректность
                return -1;
            else
            {
                char[] image = new char[1]; char[] line = new char[1];
                int[] d = new int[1103];
                //Записываем в image образ, в line - строку
                Array.Resize(ref image, imagetext.Length);
                Array.Resize(ref line, linetext.Length);
                if (Registr)
                {
                    image = imagetext.ToCharArray();
                    line = linetext.ToCharArray();
                }
                else
                {
                    image = imagetext.ToLower().ToCharArray();
                    line = linetext.ToLower().ToCharArray();
                }
                //Заполняем таблицу длинной образа
                for (int i = 0; i < d.Length; i++)
                    d[i] = image.Length;
                //Проходим образ справа налево и записываем в таблицу удаленность символов от конца строки.
                for (int i = image.Length - 1; i > -1; i--)
                    if (d[image[i]] == image.Length)//Проверяем, не изменено ли значение
                        d[image[i]] = image.Length - i - 1;
                //Алгоритм поиска. m - индекс массива строки, j - образа
                int m = image.Length - 1;
                int lace = 0;
                do
                {
                    for (int j = image.Length - 1; j > -1; j--)//Проходим образ справа налево
                        if (line[m] != image[j])//Если символы не совпали, сдвигаем m на код символа line[m]
                        {
                            m += d[line[m]];
                            break;
                        }
                        else
                            if (j != 0)//Если совпали, проверяем предыдущие символы
                        {
                            m--;
                        }
                        else //Если образ закончился, запоминаем текущий символ и прекращаем поиск
                        {
                            lace = m + 1;
                            m = line.Length;
                        }
                } while (m < line.Length);
                return lace;
            }
        }
    }
}
