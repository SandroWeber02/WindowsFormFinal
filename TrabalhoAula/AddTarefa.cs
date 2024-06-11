using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoAula
{
    public partial class AddTarefa : Form
    {
        private string connectionString = "Server=localhost;Database=projeto;Uid=adm;Pwd=;";

        public AddTarefa()
        {
            InitializeComponent();
            LoadFuncionarios();
        }

        private void LoadFuncionarios()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Nome FROM Funcionarios";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString("Nome"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um funcionário.");
                return;
            }

            string funcionario = comboBox1.SelectedItem.ToString();
            string data = dateTimePicker1.Value.ToString("yyyyMMdd");
            string hora = numericUpDown1.Value.ToString();
            string descricao = textBox1.Text;
            bool concluido = checkBox1.Checked;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Atividades (Funcionario, Data, Hora, Descricao, Concluido) " +
                                   "VALUES (@Funcionario, @Data, @Hora, @Descricao, @Concluido)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Funcionario", funcionario);
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@Hora", hora);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Concluido", concluido);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Atividade adicionada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar atividade: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do textBox1, se necessário
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do comboBox1, se necessário
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do dateTimePicker1, se necessário
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do numericUpDown1, se necessário
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
        }
    }
}


