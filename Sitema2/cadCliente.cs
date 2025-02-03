using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sitema2
{

    public partial class cadCliente : Form
    {


        public cadCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNomeCompleto.Text = string.Empty;
            maskedTextBoxCPF.Text = string.Empty;
            maskedTextBoxCEP.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            maskedTextBoxNumero.Text = string.Empty;
            maskedTextBoxTelefone.Text = string.Empty;
            textBoxNomeCompleto.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBoxCPF.Text;
            if (ValidarCpf(cpf))
            {
                labelAlert.Text = "CPF válido";
                labelAlert.ForeColor = Color.Green;
            }
            else
            {
                labelAlert.Text = "CPF inválido";
                labelAlert.ForeColor = Color.Red;
                maskedTextBoxCPF.Text = "";
                maskedTextBoxCPF.Focus();
                return;
            }
            //conexão com o banco
            string conexaoString = "server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            //registro no banco
            string query = "INSERT INTO tb_Clientes (NomeCompleto, Cpf, Email, Cep, Numero, Telefone) VALUES (@NomeCompleto, @Cpf, @Email, @Cep, @Numero, @Telefone)";

            //conexão com o bd
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    using (MySqlCommand comando = new MySqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@NomeCompleto", textBoxNomeCompleto.Text);
                        comando.Parameters.AddWithValue("@Cpf", maskedTextBoxCPF.Text);
                        comando.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                        comando.Parameters.AddWithValue("@Cep", maskedTextBoxCEP.Text);
                        comando.Parameters.AddWithValue("@Numero", maskedTextBoxNumero.Text);
                        comando.Parameters.AddWithValue("@Telefone", maskedTextBoxTelefone.Text);

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


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private bool ValidarCpf(string cpf)
        {
            // Remove qualquer caractere não numérico
            cpf = Regex.Replace(cpf, @"[^\d]", "");

            // Verifica se tem 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se o CPF é uma sequência de números iguais (ex.: 111.111.111-11)
            if (new string(cpf[0], 11) == cpf)
                return false;

            // Calculando o primeiro dígito verificador
            int soma = 0;
            int peso = 10;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            int resto = soma % 11;
            int digito1 = resto < 2 ? 0 : 11 - resto;
            if (digito1 != int.Parse(cpf[9].ToString()))
                return false;

            // Calculando o segundo dígito verificador
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * peso--;
            }

            resto = soma % 11;
            int digito2 = resto < 2 ? 0 : 11 - resto;
            return digito2 == int.Parse(cpf[10].ToString());
        }

        private void cadCliente_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBoxTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
