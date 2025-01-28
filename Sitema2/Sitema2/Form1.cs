﻿using System;
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
    public partial class Form1 : Form
    {
        bool VerSenhaTxt = false;
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "123456";

        public Form1()
        {
            InitializeComponent();

            // Adiciona o evento KeyDown ao TextBox de usuário e senha
            textBoxUsuario.KeyDown += new KeyEventHandler(textBox_KeyDown);
            textBoxSenha.KeyDown += new KeyEventHandler(textBox_KeyDown);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi "Enter"
            if (e.KeyCode == Keys.Enter)
            {
                // Simula o clique do botão Entrar
                buttonEntrar.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                textBoxSenha.PasswordChar = '\0';
                VerSenhaTxt = true;
                buttonMostrarSenha.Text = "Ocultar Senha";
            }
            else
            {
                textBoxSenha.PasswordChar = '*';
                VerSenhaTxt = false;
                buttonMostrarSenha.Text = "Mostrar Senha";
            }
        }

        private void buttonLimparCampos_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "";
            textBoxSenha.Text = "";
            textBoxUsuario.Focus();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (usuario == usuarioCorreto && senha == senhaCorreta)
            {
                labelMensagem.Text = "Login bem sucedido";
                labelMensagem.ForeColor = Color.Green;
                Menu form = new Menu();
                form.ShowDialog();
            }
            else
            {
                labelMensagem.Text = "Usuário ou senha inválida";
                labelMensagem.ForeColor = Color.Red;
                textBoxUsuario.Text = "";
                textBoxSenha.Text = "";
                textBoxUsuario.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
