namespace TrabalhoAula
{
    partial class AddTarefa
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 66);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(115, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Adcionar Tarefas";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(161, 221);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Adcionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(316, 221);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(429, 63);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 132);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(435, 23);
            textBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 193);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // AddTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 306);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "AddTarefa";
            Text = "AddTarefa";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}