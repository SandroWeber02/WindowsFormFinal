using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoAula
{
    public partial class SearchTarefa : Form
    {
        private string connectionString = "Server=localhost;Database=projeto;Uid=adm;Pwd=;";

        public SearchTarefa()
        {
            InitializeComponent();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = textBoxTermoPesquisa.Text;
            if (string.IsNullOrEmpty(termoPesquisa))
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Atividades WHERE Descricao LIKE @TermoPesquisa OR Funcionario LIKE @TermoPesquisa";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TermoPesquisa", "%" + termoPesquisa + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    listViewResultados.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Codigo"].ToString());
                        item.SubItems.Add(reader["Funcionario"].ToString());
                        item.SubItems.Add(reader["Data"].ToString());
                        item.SubItems.Add(reader["Hora"].ToString());
                        item.SubItems.Add(reader["Descricao"].ToString());
                        item.SubItems.Add(reader["Concluido"].ToString());
                        listViewResultados.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar tarefas: " + ex.Message);
            }
        }
    }
}

