namespace TrabalhoAula
{
    partial class EditTarefa
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxAtividades;
        private System.Windows.Forms.ComboBox comboBoxFuncionario;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.NumericUpDown numericUpDownHora;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.CheckBox checkBoxConcluido;
        private System.Windows.Forms.Button buttonAlterar;

        private void InitializeComponent()
        {
            this.comboBoxAtividades = new System.Windows.Forms.ComboBox();
            this.comboBoxFuncionario = new System.Windows.Forms.ComboBox();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownHora = new System.Windows.Forms.NumericUpDown();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.checkBoxConcluido = new System.Windows.Forms.CheckBox();
            this.buttonAlterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAtividades
            // 
            this.comboBoxAtividades.FormattingEnabled = true;
            this.comboBoxAtividades.Location = new System.Drawing.Point(12, 12);
            this.comboBoxAtividades.Name = "comboBoxAtividades";
            this.comboBoxAtividades.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAtividades.TabIndex = 0;
            this.comboBoxAtividades.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtividades_SelectedIndexChanged);
            // 
            // comboBoxFuncionario
            // 
            this.comboBoxFuncionario.FormattingEnabled = true;
            this.comboBoxFuncionario.Location = new System.Drawing.Point(12, 39);
            this.comboBoxFuncionario.Name = "comboBoxFuncionario";
            this.comboBoxFuncionario.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFuncionario.TabIndex = 1;
            this.comboBoxFuncionario.SelectedIndexChanged += new System.EventHandler(this.comboBoxFuncionario_SelectedIndexChanged);
            // 
            // dateTimePickerData
            // 
            this.dateTimePickerData.Location = new System.Drawing.Point(12, 66);
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerData.TabIndex = 2;
            this.dateTimePickerData.ValueChanged += new System.EventHandler(this.dateTimePickerData_ValueChanged);
            // 
            // numericUpDownHora
            // 
            this.numericUpDownHora.Location = new System.Drawing.Point(12, 92);
            this.numericUpDownHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHora.Name = "numericUpDownHora";
            this.numericUpDownHora.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownHora.TabIndex = 3;
            this.numericUpDownHora.ValueChanged += new System.EventHandler(this.numericUpDownHora_ValueChanged);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(12, 118);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(200, 60);
            this.textBoxDescricao.TabIndex = 4;
            this.textBoxDescricao.TextChanged += new System.EventHandler(this.textBoxDescricao_TextChanged);
            // 
            // checkBoxConcluido
            // 
            this.checkBoxConcluido.AutoSize = true;
            this.checkBoxConcluido.Location = new System.Drawing.Point(12, 184);
            this.checkBoxConcluido.Name = "checkBoxConcluido";
            this.checkBoxConcluido.Size = new System.Drawing.Size(74, 17);
            this.checkBoxConcluido.TabIndex = 5;
            this.checkBoxConcluido.Text = "Concluído";
            this.checkBoxConcluido.UseVisualStyleBackColor = true;
            this.checkBoxConcluido.CheckedChanged += new System.EventHandler(this.checkBoxConcluido_CheckedChanged);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Location = new System.Drawing.Point(12, 207);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(200, 23);
            this.buttonAlterar.TabIndex = 6;
            this.buttonAlterar.Text = "Alterar Atividade";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // EditTarefa
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.checkBoxConcluido);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.numericUpDownHora);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.comboBoxFuncionario);
            this.Controls.Add(this.comboBoxAtividades);
            this.Name = "EditTarefa";
            this.Text = "Editar Tarefa";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
