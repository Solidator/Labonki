namespace ALabs.Forms
{
    partial class FindImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lineTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.RegistrCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Образ";
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(12, 48);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(304, 20);
            this.imageTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Строка";
            // 
            // lineTextBox
            // 
            this.lineTextBox.Location = new System.Drawing.Point(12, 87);
            this.lineTextBox.Multiline = true;
            this.lineTextBox.Name = "lineTextBox";
            this.lineTextBox.Size = new System.Drawing.Size(306, 180);
            this.lineTextBox.TabIndex = 3;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(218, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 33);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RegistrCheckBox
            // 
            this.RegistrCheckBox.AutoSize = true;
            this.RegistrCheckBox.Location = new System.Drawing.Point(12, 12);
            this.RegistrCheckBox.Name = "RegistrCheckBox";
            this.RegistrCheckBox.Size = new System.Drawing.Size(124, 17);
            this.RegistrCheckBox.TabIndex = 5;
            this.RegistrCheckBox.Text = "Учитывать регистр";
            this.RegistrCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 279);
            this.Controls.Add(this.RegistrCheckBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.lineTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Поиск образа строке";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lineTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.CheckBox RegistrCheckBox;
    }
}