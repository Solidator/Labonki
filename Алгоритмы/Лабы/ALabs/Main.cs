using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ALabs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadButtons();
        }

        private void LoadButtons()
        {
            DirectoryInfo info = new DirectoryInfo("C:/Users/vladi/source/repos/ALabs/ALabs/Forms");
            FileInfo[] forms = info.GetFiles("*Form.cs");

            int Y = 20;
            for (int i = 0; i < forms.Length; i++)
            {
                string name = forms[i].Name;
                name = name.Substring(0, name.Length - 3);
                Button btn = new Button();
                btn.Location = new Point(25, Y);
                btn.Name = "ALabs.Forms." + name;
                btn.Text = name.Substring(0, name.Length - 4);
                btn.Size = new Size(140, 40);
                btn.Click += (object sender, EventArgs e) =>
                {
                    string TypeName = (sender as Button).Name;
                    Type type = Type.GetType(TypeName);
                    Form form = (Form)Activator.CreateInstance(type);
                    form.ShowDialog();
                };
                Controls.Add(btn);
                Size = new Size(Size.Width, Size.Height + 50);
                Y += 50;
            }
        }
    }
}
