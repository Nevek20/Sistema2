namespace Sitema2
{
    partial class Menu
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
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonCadCli = new System.Windows.Forms.Button();
            this.buttonExCli = new System.Windows.Forms.Button();
            this.buttonConCli = new System.Windows.Forms.Button();
            this.buttonAltCli = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonCadPro = new System.Windows.Forms.Button();
            this.buttonExPro = new System.Windows.Forms.Button();
            this.buttonConPro = new System.Windows.Forms.Button();
            this.buttonAltPro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("MingLiU-ExtB", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(286, 40);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(237, 29);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Menu Principal";
            // 
            // buttonCadCli
            // 
            this.buttonCadCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadCli.Location = new System.Drawing.Point(12, 99);
            this.buttonCadCli.Name = "buttonCadCli";
            this.buttonCadCli.Size = new System.Drawing.Size(246, 68);
            this.buttonCadCli.TabIndex = 1;
            this.buttonCadCli.Text = "Cadastrar cliente";
            this.buttonCadCli.UseVisualStyleBackColor = true;
            this.buttonCadCli.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExCli
            // 
            this.buttonExCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonExCli.Location = new System.Drawing.Point(12, 173);
            this.buttonExCli.Name = "buttonExCli";
            this.buttonExCli.Size = new System.Drawing.Size(246, 68);
            this.buttonExCli.TabIndex = 2;
            this.buttonExCli.Text = "Excluir cliente";
            this.buttonExCli.UseVisualStyleBackColor = true;
            // 
            // buttonConCli
            // 
            this.buttonConCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonConCli.Location = new System.Drawing.Point(12, 247);
            this.buttonConCli.Name = "buttonConCli";
            this.buttonConCli.Size = new System.Drawing.Size(246, 68);
            this.buttonConCli.TabIndex = 2;
            this.buttonConCli.Text = "Consultar cliente";
            this.buttonConCli.UseVisualStyleBackColor = true;
            this.buttonConCli.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonAltCli
            // 
            this.buttonAltCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonAltCli.Location = new System.Drawing.Point(12, 321);
            this.buttonAltCli.Name = "buttonAltCli";
            this.buttonAltCli.Size = new System.Drawing.Size(246, 68);
            this.buttonAltCli.TabIndex = 3;
            this.buttonAltCli.Text = "Alterar dados do cliente";
            this.buttonAltCli.UseVisualStyleBackColor = true;
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonQuit.Location = new System.Drawing.Point(277, 370);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(246, 68);
            this.buttonQuit.TabIndex = 4;
            this.buttonQuit.Text = "Sair";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonCadPro
            // 
            this.buttonCadPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadPro.Location = new System.Drawing.Point(542, 99);
            this.buttonCadPro.Name = "buttonCadPro";
            this.buttonCadPro.Size = new System.Drawing.Size(246, 68);
            this.buttonCadPro.TabIndex = 5;
            this.buttonCadPro.Text = "Cadastrar produtos";
            this.buttonCadPro.UseVisualStyleBackColor = true;
            this.buttonCadPro.Click += new System.EventHandler(this.buttonCadPro_Click);
            // 
            // buttonExPro
            // 
            this.buttonExPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExPro.Location = new System.Drawing.Point(542, 173);
            this.buttonExPro.Name = "buttonExPro";
            this.buttonExPro.Size = new System.Drawing.Size(246, 68);
            this.buttonExPro.TabIndex = 6;
            this.buttonExPro.Text = "Excluir produtos";
            this.buttonExPro.UseVisualStyleBackColor = true;
            // 
            // buttonConPro
            // 
            this.buttonConPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConPro.Location = new System.Drawing.Point(542, 247);
            this.buttonConPro.Name = "buttonConPro";
            this.buttonConPro.Size = new System.Drawing.Size(246, 68);
            this.buttonConPro.TabIndex = 7;
            this.buttonConPro.Text = "Consultar produtos";
            this.buttonConPro.UseVisualStyleBackColor = true;
            // 
            // buttonAltPro
            // 
            this.buttonAltPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAltPro.Location = new System.Drawing.Point(542, 321);
            this.buttonAltPro.Name = "buttonAltPro";
            this.buttonAltPro.Size = new System.Drawing.Size(246, 68);
            this.buttonAltPro.TabIndex = 8;
            this.buttonAltPro.Text = "Alterar produtos";
            this.buttonAltPro.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAltPro);
            this.Controls.Add(this.buttonConPro);
            this.Controls.Add(this.buttonExPro);
            this.Controls.Add(this.buttonCadPro);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonAltCli);
            this.Controls.Add(this.buttonConCli);
            this.Controls.Add(this.buttonExCli);
            this.Controls.Add(this.buttonCadCli);
            this.Controls.Add(this.labelMenu);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonCadCli;
        private System.Windows.Forms.Button buttonExCli;
        private System.Windows.Forms.Button buttonConCli;
        private System.Windows.Forms.Button buttonAltCli;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonCadPro;
        private System.Windows.Forms.Button buttonExPro;
        private System.Windows.Forms.Button buttonConPro;
        private System.Windows.Forms.Button buttonAltPro;
    }
}