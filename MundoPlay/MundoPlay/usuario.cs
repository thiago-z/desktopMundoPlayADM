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
            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            admUserLogado.Text = MundoPlay.Program.admUsuario;
        }
    }
}
