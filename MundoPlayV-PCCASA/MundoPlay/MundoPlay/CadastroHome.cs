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
            
        }

        string data;
        string hora;

        private void CadastroHome_Load(object sender, EventArgs e)
        {
            //Mostra data e hora no form
            //Capturar hora
            hora = DateTime.Now.ToShortTimeString();
            //Capturar data
            data = DateTime.Now.ToShortDateString();
            //Exibindo modo console
            Console.WriteLine("Data: " + data + " Hora: " + hora);
            //Exibindo Windows Form
            lblDataHoraAtual.Text = ("Data: " + data + " Hora: " + hora);


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
            String urlFoto = "C:/Users/storn/Documents/C#/desktopMundoPlayADM/MundoPlay/imagens/usuarios/";


            nomeUserLogado.Text = MundoPlay.Program.nomeUsuario;
            fotoUserLogado.ImageLocation = urlFoto + MundoPlay.Program.fotoUsuario;

            //Puxa os diretores
            string connStr = @"Data Source=DESKTOP-73BU5RN\SQLEXPRESS;Initial Catalog=mundoPlay;Integrated Security=True";

            SqlConnection dbConn = new SqlConnection(connStr);

            string diretores = @"SELECT * FROM diretores";

            SqlCommand cmd = new SqlCommand(diretores, dbConn);

            dbConn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())

            {

                lstBoxDiretor.Items.Add(rdr["nomeDiretor"]+" "+ rdr["sobrenomeDiretor"]);

            }

            rdr.Close();

            dbConn.Close();



            //Puxa os paises
            string paises = @"SELECT * FROM paises";

            SqlCommand cmd1 = new SqlCommand(paises, dbConn);

            dbConn.Open();

            SqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())

            {

                lstBoxPais.Items.Add(rdr1["nomePais"]);

            }

            rdr.Close();

            dbConn.Close();




            //Puxa os paises
            string generos = @"SELECT * FROM generos";

            SqlCommand cmd2 = new SqlCommand(generos, dbConn);

            dbConn.Open();

            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())

            {

                lstBoxGenero.Items.Add(rdr2["idgeneros"]+" - "+rdr2["nomegenero"]);
            }

            rdr1.Close();

            dbConn.Close();



            //Puxa as emissoras
            string emissoras = @"SELECT * FROM emissoras";

            SqlCommand cmd3 = new SqlCommand(emissoras, dbConn);

            dbConn.Open();

            SqlDataReader rdr3 = cmd3.ExecuteReader();

            while (rdr3.Read())

            {

                lstBoxEmissora.Items.Add(rdr3["nomeEmissora"]);

            }

            rdr2.Close();

            dbConn.Close();



            //Puxa as tags
            string tags = @"SELECT * FROM tags";

            SqlCommand cmd5 = new SqlCommand(tags, dbConn);

            dbConn.Open();

            SqlDataReader rdr5 = cmd5.ExecuteReader();

            while (rdr5.Read())

            {

            lstBoxTags.Items.Add(rdr5["tag"]);

            }

            rdr3.Close();

            dbConn.Close();


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
            gBoxCadastrarNoticia.Visible = false;
        }

        private void btnCadastroSerie_Click(object sender, EventArgs e)
        {
            gBoxCadastrarFilme.Visible = false;
            gBoxCadastrarGame.Visible = false;
            gBoxCadastrarSerie.Visible = true;
            gBoxCadastrarNoticia.Visible = false;
        }

        private void btnCadastroGame_Click(object sender, EventArgs e)
        {
            gBoxCadastrarFilme.Visible = false;
            gBoxCadastrarGame.Visible = true;
            gBoxCadastrarSerie.Visible = false;
            gBoxCadastrarNoticia.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        //Variaveis das imagens
        String nomeFoto;
        String nomeFotoDestaque;

        private void btnUploadImgPosterF_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // pega somente o nome do arquivo
                nomeFoto = System.IO.Path.GetFileName(open.FileName);
                // display image in picture box  
                picBoxAddFilme.Image = new Bitmap(open.FileName);
                // image file path  
                lblCaminhoFotoF.Text = open.FileName;
            }
        }

        String idfilme;
        

        private void button3_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            String sql10;
            string aspas = "'";


            //Criando a string de inserção do filme
            sql = "INSERT INTO filmes (titulo,titulo_original,elenco,sinopse,duracao,poster,trailer)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtTituloFilme.Text + aspas + ",";
            sql = sql + aspas + txtSubtituloFilme.Text + aspas + ",";
            sql = sql + aspas + txtElencoFilme.Text + aspas + ",";
            sql = sql + aspas + txtSinopseFilme.Text + aspas + ",";
            sql = sql + aspas + msktxtDuracaoFilme.Text + aspas + ",";
            sql = sql + aspas + nomeFoto + aspas + ",";
            sql = sql + aspas + txtURLFilme.Text;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();


            MessageBox.Show("Filme inserido com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);


            idfilme = "SELECT SCOPE_IDENTITY()";

            //Criando a string de inserção da midia do filme
            sql10 = "INSERT INTO filme_midia(filme,midia)";
            sql10 = sql10 + "VALUES (";
            sql10 = sql10 + aspas + idfilme + aspas + ",";
            sql10 = sql10 + aspas + midiaCinema + aspas;
            sql10 = sql10 + ")";

            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = sql10;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;
            cmd1.ExecuteNonQuery();


            MessageBox.Show("Midia Filme inserido com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);


        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtURLFilme_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAddDiretorLista_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";

            //Inserindo novos diretores
            sql = "INSERT INTO diretores (nomeDiretor,sobrenomeDiretor)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtAddDiretorNomeLista.Text + aspas + ",";
            sql = sql + aspas + txtAddDiretorSobrenomeLista.Text;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Novo diretor inserido com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);

            lstBoxDiretor.Refresh();

        }

        private void btnAddPaisLista_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";

            //Inserindo novos diretores
            sql = "INSERT INTO paises (nomePais)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtAddPaisLista.Text;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Novo país inserido com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);


            lstBoxPais.Update();
        }

        private void btnAddGeneroLista_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";

            //Inserindo novos diretores
            sql = "INSERT INTO generos (nomegenero)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtAddGeneroLista.Text;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Novo genêro inserido com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);


            lstBoxGenero.Update();
        }

        private void btnCadastroNoticia_Click(object sender, EventArgs e)
        {
            gBoxCadastrarFilme.Visible = false;
            gBoxCadastrarGame.Visible = false;
            gBoxCadastrarSerie.Visible = false;
            gBoxCadastrarNoticia.Visible = true;
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void habilitarDestaque(object sender, EventArgs e)
        {
            if (ckbDestaqueNoticia.Checked)
            {
                btnImgNoticiaDestaque.Enabled = true;
            }
            else
            {
                btnImgNoticiaDestaque.Enabled = false;
            }
        }

        private void btmUploadImgNoticia_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // pega somente o nome do arquivo
                nomeFoto = System.IO.Path.GetFileName(open.FileName);
                // display image in picture box  
                picBoxNoticia.Image = new Bitmap(open.FileName);
                // image file path  
                lblCaminhoNoticia.Text = open.FileName;
            }
        }

        private void btnImgNoticiaDestaque_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // pega somente o nome do arquivo
                nomeFotoDestaque = System.IO.Path.GetFileName(open.FileName);
                // display image in picture box  
                picBoxNoticiaDestaque.Image = new Bitmap(open.FileName);
                // image file path  
                lblCaminhoNoticiaDestaque.Text = open.FileName;
            }
        }

        private void gBoxCadastrarNoticia_Enter(object sender, EventArgs e)
        {

        }

      

        private void carregaTituloRelacF(object sender, EventArgs e)
        {

            if (ckbCinema.Checked)
            {
                ckbCinema.Enabled = true;
                ckbSerie.Enabled = false;
                ckbGame.Enabled = false;

                cmbTituloRelac.Items.Clear();

                string connStr = @"Data Source=DESKTOP-73BU5RN\SQLEXPRESS;Initial Catalog=mundoPlay;Integrated Security=True";

                SqlConnection dbConn = new SqlConnection(connStr);

                string filmes = @"SELECT * FROM filmes";

                SqlCommand cmd4 = new SqlCommand(filmes, dbConn);

                dbConn.Open();

                SqlDataReader rdr4 = cmd4.ExecuteReader();

                while (rdr4.Read())

                {

                    cmbTituloRelac.Items.Add(rdr4["titulo"]);

                }

               

                dbConn.Close();


            }
            else
            {
                ckbCinema.Enabled = true;
                ckbSerie.Enabled = true;
                ckbGame.Enabled = true;

                cmbTituloRelac.Items.Clear();
            }
            
            
        }

        private void carregaTituloRelacS(object sender, EventArgs e)
        {
            if (ckbSerie.Checked)
            {
                ckbCinema.Enabled = false;
                ckbSerie.Enabled = true;
                ckbGame.Enabled = false;

                cmbTituloRelac.Items.Clear();

                string connStr = @"Data Source=DESKTOP-73BU5RN\SQLEXPRESS;Initial Catalog=mundoPlay;Integrated Security=True";

                SqlConnection dbConn = new SqlConnection(connStr);

                string series = @"SELECT * FROM series";

                SqlCommand cmd4 = new SqlCommand(series, dbConn);

                dbConn.Open();

                SqlDataReader rdr4 = cmd4.ExecuteReader();

                while (rdr4.Read())

                {

                    cmbTituloRelac.Items.Add(rdr4["titulo"]);

                }



                dbConn.Close();

            }
            else
            {
                ckbCinema.Enabled = true;
                ckbSerie.Enabled = true;
                ckbGame.Enabled = true;

                cmbTituloRelac.Items.Clear();
            }
        }

        private void carregaTituloRelacG(object sender, EventArgs e)
        {
            if (ckbGame.Checked)
            {
                ckbCinema.Enabled = false;
                ckbSerie.Enabled = false;
                ckbGame.Enabled = true;

                cmbTituloRelac.Items.Clear();

                string connStr = @"Data Source=DESKTOP-73BU5RN\SQLEXPRESS;Initial Catalog=mundoPlay;Integrated Security=True";

                SqlConnection dbConn = new SqlConnection(connStr);

                string games = @"SELECT * FROM games";

                SqlCommand cmd4 = new SqlCommand(games, dbConn);

                dbConn.Open();

                SqlDataReader rdr4 = cmd4.ExecuteReader();

                while (rdr4.Read())

                {

                    cmbTituloRelac.Items.Add(rdr4["titulo"]);

                }



                dbConn.Close();

            }
            else
            {
                ckbCinema.Enabled = true;
                ckbSerie.Enabled = true;
                ckbGame.Enabled = true;

                cmbTituloRelac.Items.Clear();
            }
        }


        string destacarNoticia;
        int midiaCinema;
        int midiaSerie;
        int midiaGame;

        private void btnCadastrarNoticiaBD_Click(object sender, EventArgs e)
        {


            if (ckbDestaqueNoticia.Checked)
            {
                destacarNoticia = "on";
            }

            if (ckbCinema.Checked)
            {
                midiaCinema = 1;
            }
            if (ckbSerie.Checked)
            {
                midiaSerie = 2;
            }
            if (ckbGame.Checked)
            {
                midiaGame = 3;
            }

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";


            //Criando a string de inserção da notícia
            sql = "INSERT INTO noticias (tituloNoticia,subtitulo,texto,dataPost,horaPost,img,destaque,imgDestaque)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtTituloNoticia.Text + aspas + ",";
            sql = sql + aspas + txtSubtituloNoticia.Text + aspas + ",";
            sql = sql + aspas + richtxtTextoNoticia.Text + aspas + ",";
            sql = sql + aspas + data + aspas + ",";
            sql = sql + aspas + hora + aspas + ",";
            sql = sql + aspas + nomeFoto + aspas + ",";
            sql = sql + aspas + destacarNoticia + aspas + ",";
            sql = sql + aspas + nomeFotoDestaque;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Notícia inserida com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
