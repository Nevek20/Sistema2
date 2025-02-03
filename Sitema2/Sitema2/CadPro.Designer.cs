namespace Sitema2
{
    partial class CadPro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAlert = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxAno = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.buttonFecharCar = new System.Windows.Forms.Button();
            this.buttonLimparCar = new System.Windows.Forms.Button();
            this.buttonCadastrarCar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProprietario = new System.Windows.Forms.TextBox();
            this.labelProp = new System.Windows.Forms.Label();
            this.labelTituloCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.richTextBoxAcessorios = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maskedTextBoxValor = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxChassi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelAlert
            // 
            this.labelAlert.AutoSize = true;
            this.labelAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlert.Location = new System.Drawing.Point(397, 98);
            this.labelAlert.Name = "labelAlert";
            this.labelAlert.Size = new System.Drawing.Size(0, 18);
            this.labelAlert.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 39;
            // 
            // maskedTextBoxAno
            // 
            this.maskedTextBoxAno.Location = new System.Drawing.Point(142, 205);
            this.maskedTextBoxAno.Mask = "0000";
            this.maskedTextBoxAno.Name = "maskedTextBoxAno";
            this.maskedTextBoxAno.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxAno.TabIndex = 38;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(142, 126);
            this.maskedTextBoxTelefone.Mask = "(00)0 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxTelefone.TabIndex = 37;
            // 
            // maskedTextBoxPlaca
            // 
            this.maskedTextBoxPlaca.Location = new System.Drawing.Point(142, 179);
            this.maskedTextBoxPlaca.Mask = "aaaaaaa";
            this.maskedTextBoxPlaca.Name = "maskedTextBoxPlaca";
            this.maskedTextBoxPlaca.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxPlaca.TabIndex = 36;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(142, 100);
            this.maskedTextBoxCpf.Mask = "000,000,000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxCpf.TabIndex = 35;
            this.maskedTextBoxCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxCPF_MaskInputRejected);
            // 
            // buttonFecharCar
            // 
            this.buttonFecharCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonFecharCar.Location = new System.Drawing.Point(632, 364);
            this.buttonFecharCar.Name = "buttonFecharCar";
            this.buttonFecharCar.Size = new System.Drawing.Size(156, 66);
            this.buttonFecharCar.TabIndex = 34;
            this.buttonFecharCar.Text = "Fechar";
            this.buttonFecharCar.UseVisualStyleBackColor = true;
            // 
            // buttonLimparCar
            // 
            this.buttonLimparCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonLimparCar.Location = new System.Drawing.Point(323, 364);
            this.buttonLimparCar.Name = "buttonLimparCar";
            this.buttonLimparCar.Size = new System.Drawing.Size(156, 66);
            this.buttonLimparCar.TabIndex = 33;
            this.buttonLimparCar.Text = "Limpar campos";
            this.buttonLimparCar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrarCar
            // 
            this.buttonCadastrarCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCadastrarCar.Location = new System.Drawing.Point(15, 364);
            this.buttonCadastrarCar.Name = "buttonCadastrarCar";
            this.buttonCadastrarCar.Size = new System.Drawing.Size(156, 66);
            this.buttonCadastrarCar.TabIndex = 32;
            this.buttonCadastrarCar.Text = "Cadastrar";
            this.buttonCadastrarCar.UseVisualStyleBackColor = true;
            this.buttonCadastrarCar.Click += new System.EventHandler(this.buttonCadastrarCar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Chassi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "CPF";
            // 
            // textBoxProprietario
            // 
            this.textBoxProprietario.Location = new System.Drawing.Point(142, 74);
            this.textBoxProprietario.Name = "textBoxProprietario";
            this.textBoxProprietario.Size = new System.Drawing.Size(249, 20);
            this.textBoxProprietario.TabIndex = 25;
            // 
            // labelProp
            // 
            this.labelProp.AutoSize = true;
            this.labelProp.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProp.Location = new System.Drawing.Point(12, 74);
            this.labelProp.Name = "labelProp";
            this.labelProp.Size = new System.Drawing.Size(115, 16);
            this.labelProp.TabIndex = 24;
            this.labelProp.Text = "Proprietário";
            // 
            // labelTituloCar
            // 
            this.labelTituloCar.AutoSize = true;
            this.labelTituloCar.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCar.Location = new System.Drawing.Point(233, 20);
            this.labelTituloCar.Name = "labelTituloCar";
            this.labelTituloCar.Size = new System.Drawing.Size(320, 32);
            this.labelTituloCar.TabIndex = 23;
            this.labelTituloCar.Text = "Cadastro de carros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cor";
            // 
            // textBoxCor
            // 
            this.textBoxCor.Location = new System.Drawing.Point(142, 260);
            this.textBoxCor.Name = "textBoxCor";
            this.textBoxCor.Size = new System.Drawing.Size(249, 20);
            this.textBoxCor.TabIndex = 42;
            this.textBoxCor.TextChanged += new System.EventHandler(this.textBoxCor_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Marca";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(142, 286);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(249, 20);
            this.textBoxMarca.TabIndex = 44;
            // 
            // richTextBoxAcessorios
            // 
            this.richTextBoxAcessorios.Location = new System.Drawing.Point(519, 78);
            this.richTextBoxAcessorios.Name = "richTextBoxAcessorios";
            this.richTextBoxAcessorios.Size = new System.Drawing.Size(249, 202);
            this.richTextBoxAcessorios.TabIndex = 45;
            this.richTextBoxAcessorios.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Acessórios";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Valor";
            // 
            // maskedTextBoxValor
            // 
            this.maskedTextBoxValor.Location = new System.Drawing.Point(519, 286);
            this.maskedTextBoxValor.Mask = "$000,000,000.00";
            this.maskedTextBoxValor.Name = "maskedTextBoxValor";
            this.maskedTextBoxValor.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxValor.TabIndex = 48;
            // 
            // maskedTextBoxChassi
            // 
            this.maskedTextBoxChassi.Location = new System.Drawing.Point(142, 231);
            this.maskedTextBoxChassi.Mask = "aaaaaaaaaaaaaaaaa";
            this.maskedTextBoxChassi.Name = "maskedTextBoxChassi";
            this.maskedTextBoxChassi.Size = new System.Drawing.Size(249, 20);
            this.maskedTextBoxChassi.TabIndex = 49;
            // 
            // CadPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxChassi);
            this.Controls.Add(this.maskedTextBoxValor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBoxAcessorios);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAlert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxAno);
            this.Controls.Add(this.maskedTextBoxTelefone);
            this.Controls.Add(this.maskedTextBoxPlaca);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.buttonFecharCar);
            this.Controls.Add(this.buttonLimparCar);
            this.Controls.Add(this.buttonCadastrarCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProprietario);
            this.Controls.Add(this.labelProp);
            this.Controls.Add(this.labelTituloCar);
            this.Name = "CadPro";
            this.Text = "CadPro";
            this.Load += new System.EventHandler(this.CadPro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAlert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaca;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Button buttonFecharCar;
        private System.Windows.Forms.Button buttonLimparCar;
        private System.Windows.Forms.Button buttonCadastrarCar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProprietario;
        private System.Windows.Forms.Label labelProp;
        private System.Windows.Forms.Label labelTituloCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.RichTextBox richTextBoxAcessorios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxValor;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxChassi;
    }
}