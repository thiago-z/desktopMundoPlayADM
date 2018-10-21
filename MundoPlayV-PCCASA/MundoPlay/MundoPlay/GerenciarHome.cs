using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MundoPlay
{
    public partial class GerenciarHome : Form
    {
        public GerenciarHome()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GerenciarHome_Load(object sender, EventArgs e)
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

        private void btnAdmTitulos_Click(object sender, EventArgs e)
        {
            if(btnAdmFilme.Visible == false || btnAdmSerie.Visible == false || btnAdmGame.Visible == false)
            {
                lblAdmTitulos.Visible = true;

                btnAdmFilme.Visible = true;
                btnAdmSerie.Visible = true;
                btnAdmGame.Visible = true;

                btnAdmNoticias.Visible = false;
                btnAdmUsuarios.Visible = false;
            }
            else if (btnAdmFilme.Visible == true || btnAdmSerie.Visible == true || btnAdmGame.Visible == true)
            {
                lblAdmTitulos.Visible = false;

                btnAdmFilme.Visible = false;
                btnAdmSerie.Visible = false;
                btnAdmGame.Visible = false;

                btnAdmNoticias.Visible = true;
                btnAdmUsuarios.Visible = true;
            }
            
            
            
        }

        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            //Ao clicar aqui será direcionado ao form de adm de usuarios:
            //Adicionar, remover ou alterar users

            admUser admUsuario = new admUser();
            admUsuario.ShowDialog();

        }

        private void btnAdmNoticias_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmFilme_Click(object sender, EventArgs e)
        {
            //abrir tela de consulta de filmes
            //instanciar
            admFilme admFilme = new admFilme();
            admFilme.ShowDialog();
        }
    }
}
