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
    public partial class admFilme : Form
    {
        String urlPoster = "C:/Users/storn/Documents/GitHub/desktopMundoPlayADM/MundoPlayV-PCCASA/MundoPlay/imagens/posters/";
                           
        //variáveis globais
        String conexao;
        private void conectar()
        {
            //Habilitar e dasabilitar conexoes
            //Cenexão Casa
            conexao = @"Data Source=DESKTOP-73BU5RN\SQLEXPRESS;Initial Catalog=mundoPlay;Integrated Security=True";
            //Cenexão Senac
            //conexao = "Data Source=TIT0517587W10-1;Initial Catalog=mundoPlay;Integrated Security=True";
        }

        public admFilme()
        {
            InitializeComponent();
        }

        private void admFilme_Load(object sender, EventArgs e)
        {
           

            //Carrega no gridview os filmes cadastrados

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void carregarFilmeAdm(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgvConsultaFilmes.CurrentRow.Cells[0].Value != null)

            {
                lblIdFilme.Text =
                dgvConsultaFilmes.CurrentRow.Cells[0].Value.ToString();
                txtTituloFilme.Text =
                   dgvConsultaFilmes.CurrentRow.Cells[1].Value.ToString();
                txtSubtituloFilme.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[2].Value.ToString();
                txtElencoFilme.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[3].Value.ToString();
                txtSinopseFilme.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[4].Value.ToString();
                msktxtDuracaoFilme.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[5].Value.ToString();


                lblNomeFoto.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[6].Value.ToString();
                picBoxFilmeSelec.ImageLocation = urlPoster + lblNomeFoto.Text;


                txtURLFilme.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[7].Value.ToString();
                lblValidar.Text =
                    dgvConsultaFilmes.CurrentRow.Cells[8].Value.ToString();

                if(lblValidar.Text == "off")
                {
                    btnDesvalidarFilme.Visible = false;
                    btnValidarFilme.Visible = true;
                }
                else if(lblValidar.Text == "on")
                {
                    btnDesvalidarFilme.Visible = true;
                    btnValidarFilme.Visible = false;
                }


                conectar();
                // conectando com o banco 
                SqlConnection conn = new SqlConnection(conexao);
                // abrindo conexão
                conn.Open();

                String idfilme = lblIdFilme.Text;

                //Puxa os generos em filmes
                string generos = @"SELECT * FROM filmes
                                INNER JOIN filme_genero
                                ON
                                filmes.idfilmes = filme_genero.filme 
                                INNER JOIN generos
                                ON
                                filme_genero.genero = generos.idgeneros
                                where filme = "+ idfilme;

                SqlCommand cmd2 = new SqlCommand(generos, conn);

                SqlDataReader rdr2 = cmd2.ExecuteReader();

                while (rdr2.Read())

                {

                    lblGenerosFilme.Text = (rdr2["nomegenero"].ToString());
                }

                

                conn.Close();
                rdr2.Close();





            }
        }

        private void btnDesvalidarFilme_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            //mensagem para confirmar a exclusão
            if (MessageBox.Show("Tem certeza que quer desvalidar este título?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                String sql;
                sql = "UPDATE filmes SET validar= 'off' WHERE idfilmes=" + lblIdFilme.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                //execução do comando
                cmd.ExecuteNonQuery();

                //mostrando a mensagem que o registro foi apagado
                MessageBox.Show("Título não mais disponível no site!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                atualizaGrid();

            }
        }

        private void atualizaGrid()
        {
            String sql;
            sql = "SELECT * FROM filmes";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            SqlConnection conn = new SqlConnection(conexao);
            cmd.Connection = conn;
            SqlDataReader carregador;
            conn.Open();

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

        private void btnValidarFilme_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            //mensagem para confirmar a exclusão
            if (MessageBox.Show("Tem certeza que quer validar este título?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                String sql;
                sql = "UPDATE filmes SET validar = 'on' WHERE idfilmes=" + lblIdFilme.Text;

                SqlCommand cmd = new SqlCommand(conexao);
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                //execução do comando
                cmd.ExecuteNonQuery();

                //mostrando a mensagem que o registro foi apagado
                MessageBox.Show("Título agora disponível no site!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                atualizaGrid();

            }
        }

     
    }
    
}
