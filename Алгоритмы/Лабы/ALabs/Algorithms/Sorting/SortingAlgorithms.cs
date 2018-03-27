using System;

namespace ALabs.Algorithms.Sorting
{
    public class SortingAlgorithms
    {
        /// <summary>
        /// Сортировка прямого включения
        /// </summary>
        /// <param name="mas">Вxодной массив</param>
        /// <returns>Отсортированный массив</returns>
        public static string inclusionSort(int[] mas)
        {
            string text = string.Empty;
            for (int i = 1; i < mas.Length; i++)
            {
                int value = mas[i]; // запоминаем значение текущего элемента
                int index = i;     // и его индекс
                while ((index > 0) && (mas[index - 1] > value))
                {   // смещаем другие элементы к концу массива пока они меньше index
                    mas[index] = mas[index - 1];
                    index--;    // смещаем индекс к началу массива
                }
                mas[index] = value; // рассматриваемый элемент помещаем на освободившееся место
                for (int j = 0; j < mas.Length; j++)
                    if (j != index && j != i + 1)
                        text += mas[j].ToString() + " ";
                    else
                        if (j == index)
                        text += mas[j].ToString() + "! ";
                    else
                        text += mas[j].ToString() + "? ";
                text += Environment.NewLine;

            }
            return text;
        }

        /// <summary>
        /// Сортировка прямого выбора
        /// </summary>
        /// <param name="mas">Вxодной массив</param>
        /// <returns>Отсортированный массив</returns>
        public static string selectionSort(int[] mas)
        {
            string text = string.Empty;
            int min, temp; // для поиска минимального элемента и для обмена
            for (int i = 0; i < mas.Length - 1; i++)
            {
                min = i; // запоминаем индекс текущего элемента
                         // ищем минимальный элемент чтобы поместить на место i-ого
                for (int j = i + 1; j < mas.Length; j++)  // для остальных элементов после i-ого
                {
                    if (mas[j] < mas[min]) // если элемент меньше минимального,
                        min = j;       // запоминаем его индекс в min
                }
                temp = mas[i];      // меняем местами i-ый и минимальный элементы
                mas[i] = mas[min];
                mas[min] = temp;
                for (int j = 0; j < mas.Length; j++)
                    if (j != min && j != i)
                        text += mas[j].ToString() + " ";
                    else
                        text += mas[j].ToString() + "! ";
                text += Environment.NewLine;
            }
            return text;
        }

        /// <summary>
        /// Шейкерная сортировка
        /// </summary>
        /// <param name="mas">Вxодной массив</param>
        /// <returns>Отсортированный массив</returns>
        public static string ShakerSort(int[] mas)
        {
            string text = string.Empty; int u = 1;
            int leftMark = 0; //Левая граница
            int rightMark = mas.Length - 1;//Правая граница
            while (leftMark <= rightMark)
            {
                for (int i = 0; i < leftMark; i++)
                    text += mas[i] + " ";
                text += "-< л.г. ";
                text += "п.г.->  ";
                for (int i = rightMark + 1; i < mas.Length; i++)
                    text += mas[i] + " ";
                text += Environment.NewLine;

                for (int i = rightMark; i > leftMark; i--)//Проходим массив справа налево
                    if (mas[i - 1] > mas[i]) //Если предыдущий элемент больше текущего, меняем иx местами
                    {
                        int buff;
                        buff = mas[i];
                        mas[i] = mas[i - 1];
                        mas[i - 1] = buff;
                        for (int j = leftMark; j <= rightMark; j++)
                            if (j == i || j == i - 1)
                                text += mas[j] + "(" + u + ") ";
                            else
                                text += mas[j] + " ";
                        text += Environment.NewLine;
                        u++;
                    }
                leftMark++; //Сдвигаем левую границу вправо

                text += Environment.NewLine;
                for (int i = 0; i < leftMark; i++)
                    text += mas[i] + " ";
                text += "-<л.г. ";
                text += "п.г.->  ";
                for (int i = rightMark + 1; i < mas.Length; i++)
                    text += mas[i] + " ";
                text += Environment.NewLine;

                for (int i = leftMark+1; i <= rightMark; i++)//Проходим массив слева направо
                    if (mas[i - 1] > mas[i]) //Если предыдущий элемент больше текущего, меняем иx местами
                    {
                        int buff;
                        buff = mas[i];
                        mas[i] = mas[i - 1];
                        mas[i - 1] = buff;
                        for (int j = leftMark; j <= rightMark; j++)
                            if (j == i || j == i - 1)
                                text += mas[j] + "(" + u + ") ";
                            else
                                text += mas[j] + " ";
                        text += Environment.NewLine;
                        u++;
                    }
               
                rightMark--;//Сдвигаем правую границу влево
                text += Environment.NewLine;
                
                u = 1;
            }
            for (int i = 0; i < mas.Length; i++)
                text += mas[i] + " ";
            return text;
        }

        /// <summary>
        /// Быстрая сортировка
        /// </summary>
        /// <param name="mas">Вxодной массив</param>
        /// <returns>Отсортированный массив</returns>
        public static string FastSort(int[] mas, int left, int right)
        {
            string text = string.Empty;
            int pivot; // разрешающий элемент
            int l_hold = left; //левая граница
            int r_hold = right; // правая граница
            pivot = mas[left];
            
            while (left < right) // пока границы не сомкнутся
            {
                while ((mas[right] >= pivot) && (left < right))
                    right--; // сдвигаем правую границу пока элемент [right] больше [pivot]

                for (int i = l_hold; i < r_hold + 1; i++)
                    if (i != right)
                        text += mas[i] + " ";
                    else
                        text += mas[i] + " п.г.-> ";
                text += Environment.NewLine;

                if (left != right) // если границы не сомкнулись
                {
                    mas[left] = mas[right]; // перемещаем элемент [right] на место разрешающего
                    for (int i = l_hold; i < r_hold + 1; i++)
                        if (i != left && i != right)
                            text += mas[i] + " ";
                        else
                            text += mas[i] + "! ";
                    text += Environment.NewLine;
                    left++; // сдвигаем левую границу вправо 
                }

                while ((mas[left] <= pivot) && (left < right))
                    left++; // сдвигаем левую границу пока элемент [left] меньше [pivot]
                for (int i = l_hold; i < r_hold + 1; i++)
                    if (i != left)
                        text += mas[i] + " ";
                    else
                        text += "<-л.г. " + mas[i] + " ";
                text += Environment.NewLine;

                if (left != right) // если границы не сомкнулись
                {
                    mas[right] = mas[left]; // перемещаем элемент [left] на место [right]
                    for (int i = l_hold; i < r_hold + 1; i++)
                        if (i != left && i != right)
                            text += mas[i] + " ";
                        else
                            text += mas[i] + "! ";
                    text += Environment.NewLine;
                    right--; // сдвигаем правую границу вправо 
                }
            }
            

            mas[left] = pivot; // ставим разрешающий элемент на место
            for (int i = l_hold; i < r_hold + 1; i++)
                if (i != left)
                    text += mas[i] + " ";
                else
                    text += mas[i] + "! ";
            text += Environment.NewLine + "---------------------------" + Environment.NewLine;
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot) // Рекурсивно вызываем сортировку для левой и правой части массива
                text += FastSort(mas, left, pivot - 1);
            if (right > pivot)
                text += FastSort(mas, pivot + 1, right);
            
            return text;
        }
        

    }
}
