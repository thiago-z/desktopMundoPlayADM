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
    public partial class ConsultarHome : Form
    {
        //URL da imagem Senac
        //String urlFoto = "C:/Users/thiago.silva5/Desktop/programa_c#/MundoPlay/imagens/usuarios/";
        //URL da imagem Casa
        String urlFoto = "C:/Users/storn/Documents/GitHub/desktopMundoPlayADM/MundoPlayV-PCCASA/MundoPlay/imagens/usuarios/";

        //Caminhos da imagens de titulos
        String caminhoPoster = @"C:/Users/storn/Documents/GitHub/desktopMundoPlayADM/MundoPlayV-PCCASA/MundoPlay/imagens/posters/";


        //variáveis globais de conexão com BD
        String conexao;
        private void conectar()
        {
            //Habilitar e dasabilitar conexoes
            //Cenexão Casa
            conexao = @"Data Source=DESKTOP-73BU5RN\SQLEXPRESS;Initial Catalog=mundoPlay;Integrated Security=True";
            //Cenexão Senac
            //conexao = "Data Source=TIT0517587W10-1;Initial Catalog=mundoPlay;Integrated Security=True";
        }


        public ConsultarHome()
        {
            InitializeComponent();
        }

        private void btnConsultaFilmes_Click(object sender, EventArgs e)
        {
            gBoxConsultaFilme.Visible = true;

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;


            sql = "SELECT * FROM filmes";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            SqlDataReader carregador;


            //execução do comando
            carregador = cmd.ExecuteReader();
            dgvConsultaFilmes.Rows.Clear();
            while (carregador.Read())
            {
                dgvConsultaFilmes.Rows.Add(carregador["idfilmes"].ToString(),
                    carregador["titulo"].ToString(),
                    carregador["titulo_original"].ToString(),
                    carregador["elenco"].ToString(),
                    carregador["sinopse"].ToString(),
                    carregador["duracao"].ToString(),
                    carregador["poster"].ToString(),
                    carregador["trailer"].ToString(),
                    carregador["validar"].ToString());
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarHome_Load(object sender, EventArgs e)
        {

            //Verifica se user é administrador
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
            String urlFoto = "C:/Users/storn/Documents/Github/desktopMundoPlayADM/MundoPlayV-PCCASA/MundoPlay/imagens/usuarios/";


            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            fotoUserLogado.ImageLocation = urlFoto + MundoPlay.Program.fotoUsuario;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dadosFilmeSelec1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvConsultaFilmes.CurrentRow.Cells[0].Value != null)

            {
                lblIdFilme.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[0].Value.ToString();
                lblTituloFilmeSelec.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[1].Value.ToString();
                lblSubtituloFilmeSelec.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[2].Value.ToString();


                lblNomeFoto.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[6].Value.ToString();
                picBoxFilmeSelec.ImageLocation = caminhoPoster + lblNomeFoto.Text;

            }
        }
    }
}
