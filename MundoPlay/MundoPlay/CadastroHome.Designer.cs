namespace MundoPlay
{
    partial class CadastroHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admUserLogado = new System.Windows.Forms.Label();
            this.nomeUserLogado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fotoUserLogado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCadastroFilme = new System.Windows.Forms.Button();
            this.btnCadastrarGame = new System.Windows.Forms.Button();
            this.btnConsultarSerie = new System.Windows.Forms.Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.admUserLogado);
            this.panel2.Controls.Add(this.nomeUserLogado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fotoUserLogado);
            this.panel2.Location = new System.Drawing.Point(806, 5);
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
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(1059, 665);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 43);
            this.btnVoltar.TabIndex = 4;
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
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 55);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cadastro de títulos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCadastroFilme);
            this.panel3.Controls.Add(this.btnCadastrarGame);
            this.panel3.Controls.Add(this.btnConsultarSerie);
            this.panel3.Location = new System.Drawing.Point(162, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 128);
            this.panel3.TabIndex = 8;
            // 
            // btnCadastroFilme
            // 
            this.btnCadastroFilme.BackColor = System.Drawing.Color.DarkBlue;
            this.btnCadastroFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroFilme.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastroFilme.Location = new System.Drawing.Point(16, 28);
            this.btnCadastroFilme.Name = "btnCadastroFilme";
            this.btnCadastroFilme.Size = new System.Drawing.Size(224, 75);
            this.btnCadastroFilme.TabIndex = 3;
            this.btnCadastroFilme.Text = "Filmes";
            this.btnCadastroFilme.UseVisualStyleBackColor = false;
            this.btnCadastroFilme.Click += new System.EventHandler(this.btnCadastroFilme_Click);
            // 
            // btnCadastrarGame
            // 
            this.btnCadastrarGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarGame.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarGame.Location = new System.Drawing.Point(652, 28);
            this.btnCadastrarGame.Name = "btnCadastrarGame";
            this.btnCadastrarGame.Size = new System.Drawing.Size(224, 75);
            this.btnCadastrarGame.TabIndex = 5;
            this.btnCadastrarGame.Text = "Games";
            this.btnCadastrarGame.UseVisualStyleBackColor = false;
            // 
            // btnConsultarSerie
            // 
            this.btnConsultarSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultarSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarSerie.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSerie.Location = new System.Drawing.Point(334, 28);
            this.btnConsultarSerie.Name = "btnConsultarSerie";
            this.btnConsultarSerie.Size = new System.Drawing.Size(224, 75);
            this.btnConsultarSerie.TabIndex = 4;
            this.btnConsultarSerie.Text = "Séries";
            this.btnConsultarSerie.UseVisualStyleBackColor = false;
            // 
            // CadastroHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastroHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroHome";
            this.Load += new System.EventHandler(this.CadastroHome_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCadastroFilme;
        private System.Windows.Forms.Button btnCadastrarGame;
        private System.Windows.Forms.Button btnConsultarSerie;
    }
}