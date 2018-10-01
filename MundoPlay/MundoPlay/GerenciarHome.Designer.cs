namespace MundoPlay
{
    partial class GerenciarHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerenciarHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admUserLogado = new System.Windows.Forms.Label();
            this.nomeUserLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoUserLogado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAdmTitulos = new System.Windows.Forms.Button();
            this.btnAdmUsuarios = new System.Windows.Forms.Button();
            this.btnAdmNoticias = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUserLogado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 65);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.admUserLogado);
            this.panel2.Controls.Add(this.nomeUserLogado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fotoUserLogado);
            this.panel2.Location = new System.Drawing.Point(534, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 57);
            this.panel2.TabIndex = 1;
            // 
            // admUserLogado
            // 
            this.admUserLogado.AutoSize = true;
            this.admUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admUserLogado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admUserLogado.Location = new System.Drawing.Point(59, 39);
            this.admUserLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admUserLogado.Name = "admUserLogado";
            this.admUserLogado.Size = new System.Drawing.Size(0, 17);
            this.admUserLogado.TabIndex = 3;
            // 
            // nomeUserLogado
            // 
            this.nomeUserLogado.AutoSize = true;
            this.nomeUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUserLogado.ForeColor = System.Drawing.Color.White;
            this.nomeUserLogado.Location = new System.Drawing.Point(56, 18);
            this.nomeUserLogado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeUserLogado.Name = "nomeUserLogado";
            this.nomeUserLogado.Size = new System.Drawing.Size(160, 26);
            this.nomeUserLogado.TabIndex = 2;
            this.nomeUserLogado.Text = "Nome usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário logado:";
            // 
            // fotoUserLogado
            // 
            this.fotoUserLogado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoUserLogado.Image = ((System.Drawing.Image)(resources.GetObject("fotoUserLogado.Image")));
            this.fotoUserLogado.Location = new System.Drawing.Point(5, 3);
            this.fotoUserLogado.Margin = new System.Windows.Forms.Padding(2);
            this.fotoUserLogado.Name = "fotoUserLogado";
            this.fotoUserLogado.Size = new System.Drawing.Size(51, 51);
            this.fotoUserLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoUserLogado.TabIndex = 0;
            this.fotoUserLogado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(714, 432);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 28);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(6, 432);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 28);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdmTitulos
            // 
            this.btnAdmTitulos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmTitulos.ForeColor = System.Drawing.Color.White;
            this.btnAdmTitulos.Location = new System.Drawing.Point(15, 32);
            this.btnAdmTitulos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmTitulos.Name = "btnAdmTitulos";
            this.btnAdmTitulos.Size = new System.Drawing.Size(149, 94);
            this.btnAdmTitulos.TabIndex = 3;
            this.btnAdmTitulos.Text = "Gerenciar Títulos";
            this.btnAdmTitulos.UseVisualStyleBackColor = false;
            this.btnAdmTitulos.Click += new System.EventHandler(this.btnAdmTitulos_Click);
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnAdmUsuarios.Location = new System.Drawing.Point(435, 32);
            this.btnAdmUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Size = new System.Drawing.Size(149, 94);
            this.btnAdmUsuarios.TabIndex = 5;
            this.btnAdmUsuarios.Text = "Gerenciar Usuários";
            this.btnAdmUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnAdmNoticias
            // 
            this.btnAdmNoticias.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdmNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmNoticias.ForeColor = System.Drawing.Color.White;
            this.btnAdmNoticias.Location = new System.Drawing.Point(223, 32);
            this.btnAdmNoticias.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdmNoticias.Name = "btnAdmNoticias";
            this.btnAdmNoticias.Size = new System.Drawing.Size(149, 94);
            this.btnAdmNoticias.TabIndex = 4;
            this.btnAdmNoticias.Text = "Gerenciar Notícias";
            this.btnAdmNoticias.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Painel administrativo";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdmTitulos);
            this.panel3.Controls.Add(this.btnAdmUsuarios);
            this.panel3.Controls.Add(this.btnAdmNoticias);
            this.panel3.Location = new System.Drawing.Point(123, 236);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 150);
            this.panel3.TabIndex = 11;
            // 
            // GerenciarHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(811, 464);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GerenciarHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerenciarHome";
            this.Load += new System.EventHandler(this.GerenciarHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUserLogado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label admUserLogado;
        private System.Windows.Forms.Label nomeUserLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotoUserLogado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAdmTitulos;
        private System.Windows.Forms.Button btnAdmUsuarios;
        private System.Windows.Forms.Button btnAdmNoticias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
    }
}