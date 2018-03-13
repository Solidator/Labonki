using System;

namespace KLab_1
{
    static class Func
    {
        public static char[] delRepeat(char[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
                for (int j = i + 1; j < mas.Length; j++)
                    if (mas[i] == mas[j])
                    {
                        for (int n = j; n < mas.Length - 1; n++)
                            mas[n] = mas[n + 1];
                        Array.Resize(ref mas, mas.Length - 1);
                        j--;
                    }
            return mas;
        }

        public static char[] delNotRus(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
                if ((mas[i] < 1072 || mas[i] > 1105) && mas[i] != 32 && mas[i] != 44 && mas[i] != 46)
                {
                    for (int j = i; j < mas.Length - 1; j++)
                        mas[j] = mas[j + 1];
                    Array.Resize(ref mas, mas.Length - 1);
                    i--;
                }
            return mas;
        }

        public static char[][] keyToMatrix(char[] key, char[][] mtrx)
        {
            bool est = true; int index = key.Length;
            for (int i = 0; i < key.Length; i++)
                mtrx[i / 6][i % 6] = key[i];
            for (int i = 1072; i < 1105; i++)
            {
                est = true;
                for (int j = 0; j < 36; j++)
                    if (mtrx[j / 6][j % 6] == (char)i)
                        est = false;
                if (est)
                {
                    mtrx[index / 6][index % 6] = (char)i;
                    index++;
                }
            }

            est = true;
            for (int j = 0; j < 36; j++)
                if (mtrx[j / 6][j % 6] == (char)32)
                    est = false;
            if (est)
            {
                mtrx[index / 6][index % 6] = (char)32;
                index++;
            }

            est = true;
            for (int j = 0; j < 36; j++)
                if (mtrx[j / 6][j % 6] == (char)44)
                    est = false;
            if (est)
            {
                mtrx[index / 6][index % 6] = (char)44;
                index++;
            }

            est = true;
            for (int j = 0; j < 36; j++)
                if (mtrx[j / 6][j % 6] == (char)46)
                    est = false;
            if (est)
            {
                mtrx[index / 6][index % 6] = (char)46;
                index++;
            }

            return mtrx;
        }
        

    }
}
