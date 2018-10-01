using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MundoPlay
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //abrir tela do usuario
            //instanciar
            CadastroHome cadastroHome = new CadastroHome();
            cadastroHome.ShowDialog();
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            String admOK = MundoPlay.Program.admUsuario;

            if(admOK == "1")
            {
                admUserLogado.Text = MundoPlay.Program.privilegioADM;
            }
            else
            {
                admUserLogado.Text = "Commun";
                btnGerenciar.Enabled = false;
            }

            //URL da imagem
            String urlFoto = "C:/Users/thiago.silva5/Desktop/programa_c#/MundoPlay/imagens/usuarios/";

            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            fotoUserLogado.ImageLocation = urlFoto + MundoPlay.Program.fotoUsuario;

           

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            //abrir tela do usuario
            //instanciar
            GerenciarHome admHome = new GerenciarHome();
            admHome.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admUserLogado_Click(object sender, EventArgs e)
        {

        }

        private void nomeUserLogado_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
