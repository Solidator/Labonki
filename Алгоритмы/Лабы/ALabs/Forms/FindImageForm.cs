using System;
using System.Windows.Forms;
using ALabs.Algorithms.FindImage;

namespace ALabs.Forms
{
    public partial class FindImageForm : Form
    {
        public FindImageForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            if (FindImageAlgorithms.searchImage(lineTextBox.Text, imageTextBox.Text, RegistrCheckBox.Checked) < 0)
                MessageBox.Show("Ошибка! Неверные вxодные данные!");
            else
                if(FindImageAlgorithms.searchImage(lineTextBox.Text, imageTextBox.Text, RegistrCheckBox.Checked) == 0)
                    MessageBox.Show("Образ не содержится в тексте");
                else
                    MessageBox.Show("Образ содержится в тексте начиная с "+ FindImageAlgorithms.searchImage(lineTextBox.Text, imageTextBox.Text, RegistrCheckBox.Checked)+ " символа");
        }
    }
}
