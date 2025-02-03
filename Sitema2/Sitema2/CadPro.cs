using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sitema2
{
    public partial class CadPro : Form
    {
        public CadPro()
        {
            InitializeComponent();
        }

        private void CadPro_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonCadastrarCar_Click(object sender, EventArgs e)
        {
            string conexaoString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            //registro no banco
            string query = "INSERT INTO tb_Carros (Proprietario, Cpf, Telefone, Placa, Ano, Chassi, Cor, Marca, Acessorios, Valor) VALUES (@Propietario, @Cpf, @Telefone, @Placa, @Ano, @Chassi, @Cor, @Marca, @Acessorios, @Valor)";

            //conexão com o bd
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Proprietario", textBoxProprietario.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCpf.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);
                        comando.Parameters.AddWithValue("@Placa", maskedTextBoxPlaca.Text);
                        comando.Parameters.AddWithValue("@Ano", maskedTextBoxAno.Text);
                        comando.Parameters.AddWithValue("@Chassi", maskedTextBoxChassi.Text);
                        comando.Parameters.AddWithValue("@Cor", textBoxCor.Text);
                        comando.Parameters.AddWithValue("@Marca", textBoxMarca.Text);
                        comando.Parameters.AddWithValue("@Acessorios", richTextBoxAcessorios.Text);
                        comando.Parameters.AddWithValue("@Valor", maskedTextBoxValor.Text);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void textBoxCor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}