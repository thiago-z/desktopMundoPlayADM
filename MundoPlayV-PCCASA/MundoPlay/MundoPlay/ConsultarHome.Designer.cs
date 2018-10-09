namespace MundoPlay
{
    partial class ConsultarHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admUserLogado = new System.Windows.Forms.Label();
            this.nomeUserLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoUserLogado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultaSeries = new System.Windows.Forms.Button();
            this.btnConsultaFilmes = new System.Windows.Forms.Button();
            this.btnConsultaGames = new System.Windows.Forms.Button();
            this.gBoxConsultaFilme = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuscaUser = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvConsultaFilmes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUserLogado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.gBoxConsultaFilme.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.admUserLogado);
            this.panel2.Controls.Add(this.nomeUserLogado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fotoUserLogado);
            this.panel2.Location = new System.Drawing.Point(790, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 88);
            this.panel2.TabIndex = 1;
            // 
            // admUserLogado
            // 
            this.admUserLogado.AutoSize = true;
            this.admUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admUserLogado.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.admUserLogado.Location = new System.Drawing.Point(88, 60);
            this.admUserLogado.Name = "admUserLogado";
            this.admUserLogado.Size = new System.Drawing.Size(0, 25);
            this.admUserLogado.TabIndex = 3;
            // 
            // nomeUserLogado
            // 
            this.nomeUserLogado.AutoSize = true;
            this.nomeUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUserLogado.ForeColor = System.Drawing.Color.White;
            this.nomeUserLogado.Location = new System.Drawing.Point(84, 28);
            this.nomeUserLogado.Name = "nomeUserLogado";
            this.nomeUserLogado.Size = new System.Drawing.Size(278, 37);
            this.nomeUserLogado.TabIndex = 2;
            this.nomeUserLogado.Text = "Nome do usuário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário logado:";
            // 
            // fotoUserLogado
            // 
            this.fotoUserLogado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotoUserLogado.Image = ((System.Drawing.Image)(resources.GetObject("fotoUserLogado.Image")));
            this.fotoUserLogado.Location = new System.Drawing.Point(8, 5);
            this.fotoUserLogado.Name = "fotoUserLogado";
            this.fotoUserLogado.Size = new System.Drawing.Size(76, 78);
            this.fotoUserLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoUserLogado.TabIndex = 0;
            this.fotoUserLogado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnConsultaGames);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnConsultaSeries);
            this.panel4.Controls.Add(this.btnConsultaFilmes);
            this.panel4.Location = new System.Drawing.Point(12, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 510);
            this.panel4.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(35, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Consultar títulos";
            // 
            // btnConsultaSeries
            // 
            this.btnConsultaSeries.BackColor = System.Drawing.Color.Orange;
            this.btnConsultaSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaSeries.ForeColor = System.Drawing.Color.White;
            this.btnConsultaSeries.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaSeries.Image")));
            this.btnConsultaSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaSeries.Location = new System.Drawing.Point(25, 185);
            this.btnConsultaSeries.Name = "btnConsultaSeries";
            this.btnConsultaSeries.Size = new System.Drawing.Size(250, 50);
            this.btnConsultaSeries.TabIndex = 14;
            this.btnConsultaSeries.Text = "Consultar séries";
            this.btnConsultaSeries.UseVisualStyleBackColor = false;
            // 
            // btnConsultaFilmes
            // 
            this.btnConsultaFilmes.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultaFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaFilmes.ForeColor = System.Drawing.Color.White;
            this.btnConsultaFilmes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFilmes.Image")));
            this.btnConsultaFilmes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaFilmes.Location = new System.Drawing.Point(25, 128);
            this.btnConsultaFilmes.Name = "btnConsultaFilmes";
            this.btnConsultaFilmes.Size = new System.Drawing.Size(250, 50);
            this.btnConsultaFilmes.TabIndex = 13;
            this.btnConsultaFilmes.Text = "Consultar filmes";
            this.btnConsultaFilmes.UseVisualStyleBackColor = false;
            this.btnConsultaFilmes.Click += new System.EventHandler(this.btnConsultaFilmes_Click);
            // 
            // btnConsultaGames
            // 
            this.btnConsultaGames.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultaGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaGames.ForeColor = System.Drawing.Color.White;
            this.btnConsultaGames.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaGames.Image")));
            this.btnConsultaGames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaGames.Location = new System.Drawing.Point(25, 241);
            this.btnConsultaGames.Name = "btnConsultaGames";
            this.btnConsultaGames.Size = new System.Drawing.Size(250, 50);
            this.btnConsultaGames.TabIndex = 18;
            this.btnConsultaGames.Text = "Consultar games";
            this.btnConsultaGames.UseVisualStyleBackColor = false;
            // 
            // gBoxConsultaFilme
            // 
            this.gBoxConsultaFilme.BackColor = System.Drawing.Color.Transparent;
            this.gBoxConsultaFilme.Controls.Add(this.panel5);
            this.gBoxConsultaFilme.Controls.Add(this.pictureBox2);
            this.gBoxConsultaFilme.Controls.Add(this.label8);
            this.gBoxConsultaFilme.Controls.Add(this.dgvConsultaFilmes);
            this.gBoxConsultaFilme.Location = new System.Drawing.Point(338, 114);
            this.gBoxConsultaFilme.Name = "gBoxConsultaFilme";
            this.gBoxConsultaFilme.Size = new System.Drawing.Size(850, 520);
            this.gBoxConsultaFilme.TabIndex = 21;
            this.gBoxConsultaFilme.TabStop = false;
            this.gBoxConsultaFilme.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.btnBuscaUser);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Location = new System.Drawing.Point(576, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(260, 108);
            this.panel5.TabIndex = 20;
            // 
            // btnBuscaUser
            // 
            this.btnBuscaUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscaUser.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscaUser.Image")));
            this.btnBuscaUser.Location = new System.Drawing.Point(196, 46);
            this.btnBuscaUser.Name = "btnBuscaUser";
            this.btnBuscaUser.Size = new System.Drawing.Size(50, 40);
            this.btnBuscaUser.TabIndex = 26;
            this.btnBuscaUser.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 46);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 39);
            this.textBox2.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(616, 175);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 339);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Filmes cadastrados";
            // 
            // dgvConsultaFilmes
            // 
            this.dgvConsultaFilmes.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgvConsultaFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFilmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvConsultaFilmes.Location = new System.Drawing.Point(10, 175);
            this.dgvConsultaFilmes.Name = "dgvConsultaFilmes";
            this.dgvConsultaFilmes.RowTemplate.Height = 28;
            this.dgvConsultaFilmes.Size = new System.Drawing.Size(600, 339);
            this.dgvConsultaFilmes.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Título nacional";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Título original";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(7, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 29);
            this.label12.TabIndex = 27;
            this.label12.Text = "Buscar";
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(1059, 665);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 43);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(12, 665);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 43);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ConsultarHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gBoxConsultaFilme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarHome";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarHome";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUserLogado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gBoxConsultaFilme.ResumeLayout(false);
            this.gBoxConsultaFilme.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFilmes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label admUserLogado;
        private System.Windows.Forms.Label nomeUserLogado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox fotoUserLogado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConsultaGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultaSeries;
        private System.Windows.Forms.Button btnConsultaFilmes;
        private System.Windows.Forms.GroupBox gBoxConsultaFilme;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBuscaUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvConsultaFilmes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSair;
    }
}