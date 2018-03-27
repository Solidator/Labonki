using System;
using System.IO;
using System.Windows.Forms;
using ALabs.Algorithms.Sorting;
using ALabs.Algorithms.Database;

namespace ALabs.Forms
{
    public partial class SequenceProcessingForm : Form
    {
        /// <summary>
        /// Конструктор класса SequenceProcessingForm
        /// </summary>
        public SequenceProcessingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызов сортировки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Directory.GetFiles(Environment.CurrentDirectory, "*.dat").Length; i++) //удаляем все файлы с расширением dat
                File.Delete(Directory.GetFiles(Environment.CurrentDirectory, "*.dat")[i]);

            MergeSortQuery sortQuery = new MergeSortQuery();
            sortQuery.Count = Convert.ToInt32(numericUpDown1.Value);
            
            File.Create("file.dat").Close(); //Создаем файл
            Random rnd = new Random();
            using (BinaryWriter writer = new BinaryWriter(File.Open("file.dat", FileMode.OpenOrCreate)))
                for (int i = 0; i < numericUpDown1.Value; i++) //Заполняем файл рандомными числами и пишем это в бд
                {
                    int num = rnd.Next(0, 1000);
                    sortQuery.Mas += num + " ";
                    writer.Write(num);
                }
            FileInfo file = new FileInfo("file.dat");
            MergeSort.Merge_Sort(file); //Вызов функции сортировки

            textBox1.Clear();
            string result = string.Empty; 
            FileInfo resultFile = new FileInfo(Directory.GetFiles(Environment.CurrentDirectory, "*.dat")[0]);
            resultFile.MoveTo("file.dat");
            using (BinaryReader reader = new BinaryReader(File.Open(resultFile.FullName, FileMode.Open))) //Вывод результата на экран
                for (int i = 0; i < numericUpDown1.Value; i++)
                    result += reader.ReadInt32().ToString() + " ";
            textBox1.Text = result;
            
            DBWork.Add<MergeSortQuery>(sortQuery);
        }
    }
}
