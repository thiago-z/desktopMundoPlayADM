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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 100);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.admUserLogado);
            this.panel2.Controls.Add(this.nomeUserLogado);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fotoUserLogado);
            this.panel2.Location = new System.Drawing.Point(789, 5);
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
            this.nomeUserLogado.Size = new System.Drawing.Size(230, 37);
            this.nomeUserLogado.TabIndex = 2;
            this.nomeUserLogado.Text = "Nome usuário";
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
            this.fotoUserLogado.Size = new System.Drawing.Size(76, 77);
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
            this.btnVoltar.Location = new System.Drawing.Point(1062, 665);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 43);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSair
            // 
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(9, 665);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(129, 43);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAdmTitulos
            // 
            this.btnAdmTitulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmTitulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmTitulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmTitulos.ForeColor = System.Drawing.Color.White;
            this.btnAdmTitulos.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmTitulos.Image")));
            this.btnAdmTitulos.Location = new System.Drawing.Point(18, 49);
            this.btnAdmTitulos.Name = "btnAdmTitulos";
            this.btnAdmTitulos.Size = new System.Drawing.Size(224, 110);
            this.btnAdmTitulos.TabIndex = 3;
            this.btnAdmTitulos.Text = "Gerenciar  Títulos";
            this.btnAdmTitulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmTitulos.UseVisualStyleBackColor = false;
            this.btnAdmTitulos.Click += new System.EventHandler(this.btnAdmTitulos_Click);
            // 
            // btnAdmUsuarios
            // 
            this.btnAdmUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnAdmUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmUsuarios.Image")));
            this.btnAdmUsuarios.Location = new System.Drawing.Point(648, 49);
            this.btnAdmUsuarios.Name = "btnAdmUsuarios";
            this.btnAdmUsuarios.Size = new System.Drawing.Size(224, 110);
            this.btnAdmUsuarios.TabIndex = 5;
            this.btnAdmUsuarios.Text = "Gerenciar Usuários";
            this.btnAdmUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmUsuarios.UseVisualStyleBackColor = false;
            this.btnAdmUsuarios.Click += new System.EventHandler(this.btnAdmUsuarios_Click);
            // 
            // btnAdmNoticias
            // 
            this.btnAdmNoticias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdmNoticias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmNoticias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmNoticias.ForeColor = System.Drawing.Color.White;
            this.btnAdmNoticias.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmNoticias.Image")));
            this.btnAdmNoticias.Location = new System.Drawing.Point(333, 49);
            this.btnAdmNoticias.Name = "btnAdmNoticias";
            this.btnAdmNoticias.Size = new System.Drawing.Size(224, 110);
            this.btnAdmNoticias.TabIndex = 4;
            this.btnAdmNoticias.Text = "Gerenciar Notícias";
            this.btnAdmNoticias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmNoticias.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnAdmTitulos);
            this.panel3.Controls.Add(this.btnAdmUsuarios);
            this.panel3.Controls.Add(this.btnAdmNoticias);
            this.panel3.Location = new System.Drawing.Point(184, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 231);
            this.panel3.TabIndex = 11;
            // 
            // GerenciarHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Panel panel3;
    }
}