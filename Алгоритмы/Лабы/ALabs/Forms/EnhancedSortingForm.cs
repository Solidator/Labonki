using System;
using System.Windows.Forms;
using ALabs.Algorithms.Converting;
using ALabs.Algorithms.Sorting;
using System.Diagnostics;

namespace ALabs.Forms
{
    public partial class EnhancedSortingForm : Form
    {
        public EnhancedSortingForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) 
        {
            if (checkBox1.Checked)
                numericUpDown1.Enabled = true;
            else
                numericUpDown1.Enabled = false;
        }

        private void sortingButton_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            string text = string.Empty;
            Stopwatch timer = new Stopwatch();
            if (!checkBox1.Checked)
            {
                if (radioButton1.Checked)
                {
                    timer.Start();
                    textBox2.Text = SortingAlgorithms.ShakerSort(ConvertingAlgorithms.StringToIntArray(textBox1.Text));
                    timer.Stop();
                    ShakeTimeLabel.Text = "Шейкерная " + timer.ElapsedMilliseconds + " мс";
                }
                else
                {
                    timer.Start();
                    textBox2.Text = SortingAlgorithms.FastSort(ConvertingAlgorithms.StringToIntArray(textBox1.Text), 0, ConvertingAlgorithms.StringToIntArray(textBox1.Text).Length-1);
                    timer.Stop();
                    FastTimeLabel.Text = "Быстрая " + timer.ElapsedMilliseconds + " мс";
                }
            }
            else
            {
                Random random = new Random();
                textBox1.Text = string.Empty;
                for (int i = 0; i < numericUpDown1.Value; i++)
                    text += random.Next(1, 100) + " ";
                textBox1.Text = text;
                if (radioButton1.Checked)
                {
                    timer.Start();
                    textBox2.Text = SortingAlgorithms.ShakerSort(ConvertingAlgorithms.StringToIntArray(textBox1.Text));
                    timer.Stop();
                    ShakeTimeLabel.Text = "Шейкерная " + timer.ElapsedMilliseconds + " мс";
                }
                else
                {
                    timer.Start();
                    textBox2.Text = SortingAlgorithms.FastSort(ConvertingAlgorithms.StringToIntArray(textBox1.Text), 0, ConvertingAlgorithms.StringToIntArray(textBox1.Text).Length-1);
                    timer.Stop();
                    FastTimeLabel.Text = "Быстрая " + timer.ElapsedMilliseconds + " мс";
                }
            }
        }
    }
}
