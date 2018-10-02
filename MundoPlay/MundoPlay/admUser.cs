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
    public partial class admUser : Form
    {
        public admUser()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admUser_Load(object sender, EventArgs e)
        {
            String admOK = Program.admUsuario;

            if (admOK == "1")
            {
                admUserLogado.Text = Program.privilegioADM;
            }
            else
            {
                admUserLogado.Text = "Commun";
                
            }

            //URL da imagem Senac
            //String urlFoto = "C:/Users/thiago.silva5/Desktop/programa_c#/MundoPlay/imagens/usuarios/";
            //URL da imagem Casa
            String urlFoto = "C:/Users/storn/Documents/C#/desktopMundoPlayADM/MundoPlay/imagens/usuarios/";

            nomeUserLogado.Text = Program.nomeUsuario;
            fotoUserLogado.ImageLocation = urlFoto + Program.fotoUsuario;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir tela de cadastro de usuário
            //instanciar
            admCadastrarUser admCadastrarUsuario = new admCadastrarUser();
            admCadastrarUsuario.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //abrir tela de consulta de usuário
            //instanciar
            admConsultarUser admConsultarUsuario = new admConsultarUser();
            admConsultarUsuario.ShowDialog();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
