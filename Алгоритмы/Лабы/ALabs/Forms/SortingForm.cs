using System;
using System.Windows.Forms;
using ALabs.Algorithms.Converting;
using ALabs.Algorithms.Sorting;
using ALabs.Algorithms.FindImage;

namespace ALabs.Forms
{
    public partial class SortingForm : Form
    {
        public SortingForm() //Точка вxода в программу
        {
            InitializeComponent();
        }
        
        private void inclusionSortButton_Click_1(object sender, EventArgs e)//Сортировка прямого включения
        {
            richTextBox1.Text = SortingAlgorithms.inclusionSort(ConvertingAlgorithms.StringToIntArray(textBox1.Text));

            richTextBox1.SelectionStart = FindImageAlgorithms.searchImage(richTextBox1.Text, "!", false) - 1;
            richTextBox1.SelectionLength = 2;
            richTextBox1.SelectionColor = System.Drawing.Color.Red;
            
        }

        private void selectionSortButton_Click_1(object sender, EventArgs e)//Сортировка прямого выбора
        {
            richTextBox1.Text = SortingAlgorithms.selectionSort(ConvertingAlgorithms.StringToIntArray(textBox1.Text));
        }
    }
}
