using System;
using System.Windows.Forms;

namespace KLab_1
{
    public partial class Form1 : Form
    {
        
        char[] text, key;
        char[] cipher = new char[0];
        char[] bi = new char[2];
        int[] index1 = new int[2], index2 = new int[2];

        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[][] mtrx = new char[6][];
            for (int i = 0; i < 6; i++)
                mtrx[i] = new char[6];

            key = Func.delNotRus(Func.delRepeat((textBox5.Text).ToLower().ToCharArray()));
            mtrx = Func.keyToMatrix(key, mtrx);
            
            textBox1.Text = textBox1.Text.ToLower();
            text = Func.delNotRus(textBox1.Text.ToCharArray());
            textBox2.Clear();

            
            for (int i = 0; i < text.Length; i++)
            {
                bi[0] = text[i];
                if (i == text.Length - 1 || text[i] == text[i + 1])
                    bi[1] = 'ъ';
                else
                {
                    bi[1] = text[i + 1];
                    i++;
                }

                for (int n = 0; n < 6; n++)
                    for (int m = 0; m < 6; m++)
                    {
                        if (mtrx[n][m] == bi[0])
                        {
                            index1[0] = n;
                            index1[1] = m;
                        }
                        if (mtrx[n][m] == bi[1])
                        {
                            index2[0] = n;
                            index2[1] = m;
                        }
                    }

                Array.Resize(ref cipher, cipher.Length + 2);

                if (index1[0] == index2[0])
                {
                    if (index1[1] < 5)
                        cipher[cipher.Length - 2] = mtrx[index1[0]][index1[1] + 1];
                    else
                        cipher[cipher.Length - 2] = mtrx[index1[0]][0];
                    if (index2[1] < 5)
                        cipher[cipher.Length - 1] = mtrx[index2[0]][index2[1] + 1];
                    else
                        cipher[cipher.Length - 1] = mtrx[index2[0]][0];
                }
                else
                    if (index1[1] == index2[1])
                {
                    if (index1[0] < 5)
                        cipher[cipher.Length - 2] = mtrx[index1[0] + 1][index1[1]];
                    else
                        cipher[cipher.Length - 2] = mtrx[0][index1[1]];
                    if (index2[0] < 5)
                        cipher[cipher.Length - 1] = mtrx[index2[0] + 1][index2[1]];
                    else
                        cipher[cipher.Length - 1] = mtrx[0][index2[1]];
                }
                else
                {
                    cipher[cipher.Length - 2] = mtrx[index1[0]][index2[1]];
                    cipher[cipher.Length - 1] = mtrx[index2[0]][index1[1]];
                }
            }
            for (int i = 0; i < cipher.Length; i++)
                textBox2.Text += cipher[i];
            Array.Resize(ref text, 0);
            Array.Resize(ref cipher, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[][] mtrx = new char[6][];
            for (int i = 0; i < 6; i++)
                mtrx[i] = new char[6];
            key = Func.delNotRus(Func.delRepeat((textBox6.Text).ToLower().ToCharArray()));
            mtrx = Func.keyToMatrix(key, mtrx);

            textBox3.Text.ToLower();
            textBox4.Clear();
            if (textBox3.Text.Length % 2 == 1)
                MessageBox.Show("Неверные данные!");
            else
            {
                text = Func.delNotRus(textBox3.Text.ToCharArray());
                
                for (int i = 0; i < text.Length; i += 2)
                {
                    bi[0] = text[i];
                    bi[1] = text[i + 1];

                    for (int n = 0; n < 6; n++)
                        for (int m = 0; m < 6; m++)
                        {
                            if (mtrx[n][m] == bi[0])
                            {
                                index1[0] = n;
                                index1[1] = m;
                            }
                            if (mtrx[n][m] == bi[1])
                            {
                                index2[0] = n;
                                index2[1] = m;
                            }
                        }

                    Array.Resize(ref cipher, cipher.Length + 2);

                    if (index1[0] == index2[0])
                    {
                        if (index1[1] > 0)
                            cipher[cipher.Length - 2] = mtrx[index1[0]][index1[1] - 1];
                        else
                            cipher[cipher.Length - 2] = mtrx[index1[0]][5];
                        if (index2[1] > 0)
                            cipher[cipher.Length - 1] = mtrx[index2[0]][index2[1] - 1];
                        else
                            cipher[cipher.Length - 1] = mtrx[index2[0]][5];
                    }
                    else
                        if (index1[1] == index2[1])
                    {
                        if (index1[0] > 0)
                            cipher[cipher.Length - 2] = mtrx[index1[0] - 1][index1[1]];
                        else
                            cipher[cipher.Length - 2] = mtrx[5][index1[1]];
                        if (index2[0] > 0)
                            cipher[cipher.Length - 1] = mtrx[index2[0] - 1][index2[1]];
                        else
                            cipher[cipher.Length - 1] = mtrx[5][index2[1]];
                    }
                    else
                    {
                        cipher[cipher.Length - 2] = mtrx[index1[0]][index2[1]];
                        cipher[cipher.Length - 1] = mtrx[index2[0]][index1[1]];
                    }
                }
                for (int i = 0; i < cipher.Length; i++)
                    textBox4.Text += cipher[i];
                Array.Resize(ref text, 0);
                Array.Resize(ref cipher, 0);
            }
        }
    }

}
