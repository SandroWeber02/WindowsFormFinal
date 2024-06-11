using System.Windows.Forms;

namespace TrabalhoAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
            "Tem certeza que deseja sair da aplicação?",
            "Controle de Tarefas",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question
         );

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTarefa frm = new AddTarefa();
            frm.ShowDialog();
        }

        private void altToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTarefa frm = new EditTarefa();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTarefa frm = new SearchTarefa();
            frm.ShowDialog();
        }
    }
}
