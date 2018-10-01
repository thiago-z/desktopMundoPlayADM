namespace MundoPlay
{
    partial class usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admUserLogado = new System.Windows.Forms.Label();
            this.nomeUserLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoUserLogado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.admUserLogado.Click += new System.EventHandler(this.admUserLogado_Click);
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
            this.nomeUserLogado.Click += new System.EventHandler(this.nomeUserLogado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário logado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.fotoUserLogado.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(8, 428);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 28);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(716, 428);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 28);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(11, 18);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(149, 49);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(223, 18);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(149, 49);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.ForeColor = System.Drawing.Color.White;
            this.btnGerenciar.Location = new System.Drawing.Point(435, 18);
            this.btnGerenciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(149, 49);
            this.btnGerenciar.TabIndex = 5;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCadastro);
            this.panel3.Controls.Add(this.btnGerenciar);
            this.panel3.Controls.Add(this.btnConsultar);
            this.panel3.Location = new System.Drawing.Point(108, 263);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 83);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(277, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Painel de controle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(810, 464);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.usuario_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox fotoUserLogado;
        private System.Windows.Forms.Label admUserLogado;
        private System.Windows.Forms.Label nomeUserLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}