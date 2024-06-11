namespace TrabalhoAula
{
    partial class SearchTarefa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxTermoPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.listViewResultados = new System.Windows.Forms.ListView();
            this.columnCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFuncionario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConcluido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxTermoPesquisa
            // 
            this.textBoxTermoPesquisa.Location = new System.Drawing.Point(12, 12);
            this.textBoxTermoPesquisa.Name = "textBoxTermoPesquisa";
            this.textBoxTermoPesquisa.Size = new System.Drawing.Size(200, 20);
            this.textBoxTermoPesquisa.TabIndex = 0;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(218, 10);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 1;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // listViewResultados
            // 
            this.listViewResultados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCodigo,
            this.columnFuncionario,
            this.columnData,
            this.columnHora,
            this.columnDescricao,
            this.columnConcluido});
            this.listViewResultados.FullRowSelect = true;
            this.listViewResultados.GridLines = true;
            this.listViewResultados.Location = new System.Drawing.Point(12, 38);
            this.listViewResultados.Name = "listViewResultados";
            this.listViewResultados.Size = new System.Drawing.Size(600, 300);
            this.listViewResultados.TabIndex = 2;
            this.listViewResultados.UseCompatibleStateImageBehavior = false;
            this.listViewResultados.View = System.Windows.Forms.View.Details;
            // 
            // columnCodigo
            // 
            this.columnCodigo.Text = "Código";
            // 
            // columnFuncionario
            // 
            this.columnFuncionario.Text = "Funcionário";
            // 
            // columnData
            // 
            this.columnData.Text = "Data";
            // 
            // columnHora
            // 
            this.columnHora.Text = "Hora";
            // 
            // columnDescricao
            // 
            this.columnDescricao.Text = "Descrição";
            // 
            // columnConcluido
            // 
            this.columnConcluido.Text = "Concluído";
            // 
            // SearchTarefa
            // 
            this.ClientSize = new System.Drawing.Size(624, 351);
            this.Controls.Add(this.listViewResultados);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxTermoPesquisa);
            this.Name = "SearchTarefa";
            this.Text = "Pesquisar Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxTermoPesquisa;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ListView listViewResultados;
        private System.Windows.Forms.ColumnHeader columnCodigo;
        private System.Windows.Forms.ColumnHeader columnFuncionario;
        private System.Windows.Forms.ColumnHeader columnData;
        private System.Windows.Forms.ColumnHeader columnHora;
        private System.Windows.Forms.ColumnHeader columnDescricao;
        private System.Windows.Forms.ColumnHeader columnConcluido;
    }
}
