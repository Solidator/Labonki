using System.IO;
using ALabs.Algorithms.Database;
using System;

namespace ALabs.Algorithms.Sorting
{
    class MergeSort
    {
        /// <summary>
        /// Разбиение файла на два и вызов слияния
        /// </summary>
        /// <param name="file">Бинарный файл</param>
        /// <returns></returns>
       public static FileInfo Merge_Sort(FileInfo file)
        {
            if (file.Exists)
            {
                MergeSortIteration sortIteration1 = new MergeSortIteration();
                MergeSortIteration sortIteration2 = new MergeSortIteration();
                sortIteration1.SortNum = DBWork.GetSortCount() + 1; //Записываем номер текущей сортировки
                sortIteration2.SortNum = DBWork.GetSortCount() + 1;
                
                if (file.Length / sizeof(int) == 1) //Если в файле одно число, возвращаем его
                    return file;
                File.Create(file.Name.Substring(0, file.Name.Length - 4) + "1.dat").Close(); //Создаем два файла для разбиения
                File.Create(file.Name.Substring(0, file.Name.Length - 4) + "2.dat").Close();
                FileInfo file1 = new FileInfo(file.Name.Substring(0, file.Name.Length - 4) + "1.dat");
                FileInfo file2 = new FileInfo(file.Name.Substring(0, file.Name.Length - 4) + "2.dat");
                sortIteration1.FileName = file1.Name;
                sortIteration2.FileName = file2.Name;
                sortIteration1.SerialLength = Convert.ToInt32(file.Length / (sizeof(int) * 2));
                sortIteration2.SerialLength = Convert.ToInt32((file.Length - (file.Length / 2)) / sizeof(int));

                using (BinaryReader reader = new BinaryReader(File.Open(file.FullName, FileMode.Open)))
                {
                    using (BinaryWriter writer = new BinaryWriter(File.Open(file1.Name, FileMode.Open)))
                        for (int i = 0; i < file.Length / (sizeof(int) * 2); i++) //Проходим от начала файла до половины и записываем это в первый файл
                        {
                            int num = reader.ReadInt32();
                            writer.Write(num);
                            sortIteration1.File += num + " ";
                        }

                    using (BinaryWriter writer = new BinaryWriter(File.Open(file2.Name, FileMode.Open)))
                        for (long i = file.Length / 8; i < file.Length / sizeof(int); i ++) //Проходим от половины файла до его конца и записываем это во второй файл
                        {
                            int num = reader.ReadInt32();
                            writer.Write(num);
                            sortIteration2.File += num + " ";
                        }
                }
                file.Delete();
                DBWork.Add<MergeSortIteration>(sortIteration1);
                DBWork.Add<MergeSortIteration>(sortIteration2);
                return Merge(Merge_Sort(file1), Merge_Sort(file2)); //Вызываем слияние для этих файлов
            }
            else
                return null;
        }

        /// <summary>
        /// Слияние двух файлов
        /// </summary>
        /// <param name="file1">Первый файл</param>
        /// <param name="file2">Второй файл</param>
        /// <returns>Файл с результатом</returns>
        static FileInfo Merge(FileInfo file1, FileInfo file2)
        {
            MergeSortIteration sortIteration = new MergeSortIteration();
            sortIteration.SortNum = DBWork.GetSortCount() + 1;//Запись номера текущей сортирвоки в бд

            int a = 0, b = 0, num1, num2; //a - счетчик для первого файла, b - для второго
            File.Create(file1.Name.Substring(0, file1.Name.Length - 4) + "3.dat").Close();//Создаем файл для записи в него слияния
            FileInfo file3 = new FileInfo(file1.Name.Substring(0, file1.Name.Length - 4) + "3.dat");
            sortIteration.FileName = file3.Name;
            sortIteration.SerialLength = Convert.ToInt32((file1.Length + file2.Length) / sizeof(int));

            using (BinaryReader reader1 = new BinaryReader(File.Open(file1.FullName, FileMode.Open)))
                using (BinaryReader reader2 = new BinaryReader(File.Open(file2.FullName, FileMode.Open)))
                    using (BinaryWriter writer = new BinaryWriter(File.Open(file3.Name, FileMode.OpenOrCreate)))
                    {
                        for (int i = 0; i < (file1.Length + file2.Length) / sizeof(int); i++) //Проходим оба файла 
                        {
                            if (b < file2.Length / sizeof(int) && a < file1.Length / sizeof(int)) //Если оба файла ещё не закончились (a и b - счетчики текущего положения)
                             {
                                num1 = reader1.ReadInt32();
                                num2 = reader2.ReadInt32();
                                if (num1 > num2) //Если число первого файла большего числа второго, записываем второе и сдвигаем указатель первого файла назад
                              {
                                    writer.Write(num2);
                                    b++;
                                    sortIteration.File += num2 + " ";
                                    reader1.BaseStream.Position -= sizeof(int);
                                }
                                else //Если число второго файла большего числа первого, записываем первое и сдвигаем указатель второго файланазад
                                {
                                    writer.Write(num1);
                                    a++;
                                    sortIteration.File += num1 + " ";
                                    reader2.BaseStream.Position -= sizeof(int);
                                }
                            }
                            else //Если какой-то файл закончился
                                if (b < file2.Length / sizeof(int)) //Если первый закончился, то проxодим второй до конца 
                    {
                                    num2 = reader2.ReadInt32();
                                    writer.Write(num2);
                                    sortIteration.File += num2 + " ";
                                    b++;
                                }
                                else  //Если второй закончился, то проxодим первый до конца
                                {
                                    num1 = reader1.ReadInt32();
                                    writer.Write(num1);
                                    sortIteration.File += num1 + " ";
                                    a++;
                                }
                        }
                        DBWork.Add<MergeSortIteration>(sortIteration);
                    }
            file1.Delete();
            file2.Delete();
            return file3;
        }
    }
}
