using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoAula
{
    public partial class EditTarefa : Form
    {
        private string connectionString = "Server=localhost;Database=projeto;Uid=adm;Pwd=;";

        public EditTarefa()
        {
            InitializeComponent();
            LoadAtividades();
            LoadFuncionarios();
        }

        private void LoadAtividades()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Codigo, Descricao FROM Atividades";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBoxAtividades.Items.Add(new ComboBoxItem(reader.GetInt32("Codigo"), reader.GetString("Descricao")));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar atividades: " + ex.Message);
            }
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
                        comboBoxFuncionario.Items.Add(reader.GetString("Nome"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionários: " + ex.Message);
            }
        }

        private void comboBoxAtividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAtividades.SelectedItem == null)
                return;

            var selectedItem = comboBoxAtividades.SelectedItem as ComboBoxItem;
            if (selectedItem == null)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Atividades WHERE Codigo = @Codigo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", selectedItem.Id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        comboBoxFuncionario.SelectedItem = reader.GetString("Funcionario");
                        dateTimePickerData.Value = DateTime.ParseExact(reader.GetString("Data"), "yyyyMMdd", null);
                        numericUpDownHora.Value = int.Parse(reader.GetString("Hora"));
                        textBoxDescricao.Text = reader.GetString("Descricao");
                        checkBoxConcluido.Checked = reader.GetBoolean("Concluido");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes da atividade: " + ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            if (comboBoxAtividades.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma atividade.");
                return;
            }

            var selectedItem = comboBoxAtividades.SelectedItem as ComboBoxItem;
            if (selectedItem == null)
                return;

            string funcionario = comboBoxFuncionario.SelectedItem?.ToString();
            string data = dateTimePickerData.Value.ToString("yyyyMMdd");
            string hora = numericUpDownHora.Value.ToString();
            string descricao = textBoxDescricao.Text;
            bool concluido = checkBoxConcluido.Checked;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Atividades SET Funcionario = @Funcionario, Data = @Data, Hora = @Hora, " +
                                   "Descricao = @Descricao, Concluido = @Concluido WHERE Codigo = @Codigo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Funcionario", funcionario);
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@Hora", hora);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Concluido", concluido);
                    cmd.Parameters.AddWithValue("@Codigo", selectedItem.Id);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Atividade alterada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar atividade: " + ex.Message);
            }
        }

        private void textBoxDescricao_TextChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do textBoxDescricao, se necessário
        }

        private void comboBoxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do comboBoxFuncionario, se necessário
        }

        private void dateTimePickerData_ValueChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do dateTimePickerData, se necessário
        }

        private void numericUpDownHora_ValueChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do numericUpDownHora, se necessário
        }

        private void checkBoxConcluido_CheckedChanged(object sender, EventArgs e)
        {
            // Lógica para eventos do checkBoxConcluido, se necessário
        }
    }

    // Classe auxiliar para armazenar ID e descrição da atividade no ComboBox
    public class ComboBoxItem
    {
        public int Id { get; private set; }
        public string Descricao { get; private set; }

        public ComboBoxItem(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao;
        }
    }
}


