namespace TrabalhoAula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            tarefaToolStripMenuItem = new ToolStripMenuItem();
            aDDToolStripMenuItem = new ToolStripMenuItem();
            altToolStripMenuItem = new ToolStripMenuItem();
            pesquisarToolStripMenuItem = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, tarefaToolStripMenuItem, funcionarioToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(448, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // tarefaToolStripMenuItem
            // 
            tarefaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDDToolStripMenuItem, altToolStripMenuItem, pesquisarToolStripMenuItem });
            tarefaToolStripMenuItem.Name = "tarefaToolStripMenuItem";
            tarefaToolStripMenuItem.Size = new Size(50, 20);
            tarefaToolStripMenuItem.Text = "Tarefa";
            // 
            // aDDToolStripMenuItem
            // 
            aDDToolStripMenuItem.Name = "aDDToolStripMenuItem";
            aDDToolStripMenuItem.Size = new Size(180, 22);
            aDDToolStripMenuItem.Text = "ADD";
            aDDToolStripMenuItem.Click += aDDToolStripMenuItem_Click;
            // 
            // altToolStripMenuItem
            // 
            altToolStripMenuItem.Name = "altToolStripMenuItem";
            altToolStripMenuItem.Size = new Size(180, 22);
            altToolStripMenuItem.Text = "Alt";
            altToolStripMenuItem.Click += altToolStripMenuItem_Click;
            // 
            // pesquisarToolStripMenuItem
            // 
            pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            pesquisarToolStripMenuItem.Size = new Size(180, 22);
            pesquisarToolStripMenuItem.Text = "Pesquisar";
            pesquisarToolStripMenuItem.Click += pesquisarToolStripMenuItem_Click;
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manutençãoToolStripMenuItem });
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.Size = new Size(82, 20);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(141, 22);
            manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem1 });
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sobreToolStripMenuItem1
            // 
            sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            sobreToolStripMenuItem1.Size = new Size(104, 22);
            sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 274);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem tarefaToolStripMenuItem;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem aDDToolStripMenuItem;
        private ToolStripMenuItem altToolStripMenuItem;
        private ToolStripMenuItem pesquisarToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem1;
    }
}
