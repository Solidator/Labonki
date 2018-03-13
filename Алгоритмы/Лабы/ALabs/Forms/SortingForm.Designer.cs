namespace ALabs.Forms
{
    partial class SortingForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inclusionSortButton = new System.Windows.Forms.Button();
            this.selectionSortButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный массив";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(353, 146);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Отсортированный массив";
            // 
            // inclusionSortButton
            // 
            this.inclusionSortButton.Location = new System.Drawing.Point(11, 342);
            this.inclusionSortButton.Name = "inclusionSortButton";
            this.inclusionSortButton.Size = new System.Drawing.Size(126, 41);
            this.inclusionSortButton.TabIndex = 4;
            this.inclusionSortButton.Text = "Сортировка прямого включения";
            this.inclusionSortButton.UseVisualStyleBackColor = true;
            this.inclusionSortButton.Click += new System.EventHandler(this.inclusionSortButton_Click_1);
            // 
            // selectionSortButton
            // 
            this.selectionSortButton.Location = new System.Drawing.Point(152, 342);
            this.selectionSortButton.Name = "selectionSortButton";
            this.selectionSortButton.Size = new System.Drawing.Size(128, 41);
            this.selectionSortButton.TabIndex = 5;
            this.selectionSortButton.Text = "Сортировка прямого выбора";
            this.selectionSortButton.UseVisualStyleBackColor = true;
            this.selectionSortButton.Click += new System.EventHandler(this.selectionSortButton_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(11, 190);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 146);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 390);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.selectionSortButton);
            this.Controls.Add(this.inclusionSortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form3";
            this.Text = "Сортировка массивов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button inclusionSortButton;
        private System.Windows.Forms.Button selectionSortButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}