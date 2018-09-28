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
            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            admUserLogado.Text = MundoPlay.Program.admUsuario;
        }
    }
}
