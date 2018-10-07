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
    public partial class CadastroHome : Form
    {
        public CadastroHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroFilme_Click(object sender, EventArgs e)
        {
            //abrir tela de cadastro de filme
            //instanciar
            CadastroFilme cadastroFilme = new CadastroFilme();
            cadastroFilme.ShowDialog();
        }

        private void CadastroHome_Load(object sender, EventArgs e)
        {

            String admOK = MundoPlay.Program.admUsuario;

            if (admOK == "1")
            {
                admUserLogado.Text = MundoPlay.Program.privilegioADM;
            }
            else
            {
                admUserLogado.Text = "Commun";
            }

            //URL da imagem Senac
            //String urlFoto = "C:/Users/thiago.silva5/Desktop/programa_c#/MundoPlay/imagens/usuarios/";
            //URL da imagem Casa
            String urlFoto = "C:/Users/storn/Documents/C#/desktopMundoPlayADM/MundoPlay/imagens/usuarios/";


            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            fotoUserLogado.ImageLocation = urlFoto + MundoPlay.Program.fotoUsuario;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            gBoxCadastrarSerie.Visible = false;
        }

        private void btnCadastroFilme_Click_1(object sender, EventArgs e)
        {
            gBoxCadastrarFilme.Visible = true;
            gBoxCadastrarGame.Visible = false;
            gBoxCadastrarSerie.Visible = false;
        }

        private void btnCadastroSerie_Click(object sender, EventArgs e)
        {
            gBoxCadastrarFilme.Visible = false;
            gBoxCadastrarGame.Visible = false;
            gBoxCadastrarSerie.Visible = true;
        }

        private void btnCadastroGame_Click(object sender, EventArgs e)
        {
            gBoxCadastrarFilme.Visible = false;
            gBoxCadastrarGame.Visible = true;
            gBoxCadastrarSerie.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
