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

            //URL da imagem
            String urlFoto = "C:/Users/thiago.silva5/Desktop/programa_c#/MundoPlay/imagens/usuarios/";

            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            fotoUserLogado.ImageLocation = urlFoto + MundoPlay.Program.fotoUsuario;


        }

        private void btnAdmTitulos_Click(object sender, EventArgs e)
        {

        }
    }
}
