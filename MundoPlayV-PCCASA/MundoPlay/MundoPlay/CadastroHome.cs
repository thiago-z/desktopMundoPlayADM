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

        //Variaveis de de uso geral para manipulação do BD
        string destacarNoticia;

        int midiaCinema = 1;
        int midiaSerie = 2;
        int midiaGame = 3;
        String tipoMidia;

        String idfilme;
        String idserie;
        String idgame;
        String idnoticia;

        String data;
        String hora;

        String dataFilmeId;

        String nomeFoto;
        String nomeFotoDestaque;



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
            String urlFoto = "C:/Users/storn/Documents/Github/desktopMundoPlayADM/MundoPlayV-PCCASA/MundoPlay/imagens/usuarios/";


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

                lstBoxDiretor.Items.Add(rdr["iddiretores"] + " - " + rdr["nomeDiretor"]+" "+ rdr["sobrenomeDiretor"]);

            }

            rdr.Close();

            dbConn.Close();



            //Puxa os paises em filmes
            string paises = @"SELECT * FROM paises";

            SqlCommand cmd1 = new SqlCommand(paises, dbConn);

            dbConn.Open();

            SqlDataReader rdr1 = cmd1.ExecuteReader();

            while (rdr1.Read())

            {

                lstBoxPais.Items.Add(rdr1["idpaises"] + " - " + rdr1["nomePais"]);

            }

            rdr.Close();

            dbConn.Close();

            //Puxa os paises em séries
            string paisesS = @"SELECT * FROM paises";

            SqlCommand cmd10 = new SqlCommand(paisesS, dbConn);

            dbConn.Open();

            SqlDataReader rdr10 = cmd10.ExecuteReader();

            while (rdr10.Read())

            {

                lstBoxPaisS.Items.Add(rdr10["idpaises"] + " - " + rdr10["nomePais"]);

            }

            rdr.Close();

            dbConn.Close();


            //Puxa os generos em filmes
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


            //Puxa os generos em series
            string generosS = @"SELECT * FROM generos";

            SqlCommand cmd20 = new SqlCommand(generosS, dbConn);

            dbConn.Open();

            SqlDataReader rdr20 = cmd20.ExecuteReader();

            while (rdr20.Read())

            {

                lstBoxGeneroS.Items.Add(rdr20["idgeneros"] + " - "+rdr20["nomegenero"]);
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

                lstBoxEmissora.Items.Add(rdr3["idemissoras"]+" - "+rdr3["nomeEmissora"]);

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

            lstBoxTags.Items.Add(rdr5["idtags"]+"- "+rdr5["tag"]);

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

        string idgenero;


        private void button3_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            String sql1;
            String sql2;
            String sql3;
            String sql4;
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



            //Puxa o id do filme adicionado e atribui a variavel

            sql1 = "SELECT idfilmes FROM filmes WHERE titulo = " + "'" + txtTituloFilme.Text + "'" + "";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = sql1;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;

            SqlDataReader carregador;
            //execução do comando
            carregador = cmd1.ExecuteReader();
            //verificando se o registro foi encontrado     

            if (carregador.Read())
            {
                idfilme = carregador["idfilmes"].ToString();

            }

            carregador.Close();

            //Insere o id do filme e o id da midia
            sql2 = "INSERT INTO filme_midia (filme,midia)";
            sql2 = sql2 + "VALUES (";
            sql2 = sql2 + idfilme + ",";
            sql2 = sql2 + midiaCinema;
            sql2 = sql2 + ")";

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = sql2;
            cmd3.CommandType = CommandType.Text;
            cmd3.Connection = conn;
            cmd3.ExecuteNonQuery();


            //Faz o loop pelos itens selecionados de generos em filmes
            //Insere os ids dos generos na tabela relacionada
            if (lstBoxGenero.SelectedItems.Count > 0)
            {

                //Faz o loop pelos itens selecionados
                foreach (object item in lstBoxGenero.SelectedItems)
                {
                    //convert item to string
                    string checkedItem = item.ToString();
                    string idGenero = checkedItem.Substring(0, 2);

                    sql1 = "Insert into filme_genero(filme,genero) Values (@filme,@genero)";
                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.CommandText = sql1;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Connection = conn;

                    cmd4.Parameters.AddWithValue("@filme", idfilme); //add item
                    cmd4.Parameters.AddWithValue("@genero", idGenero); //add item
                    cmd4.ExecuteNonQuery();

                }

                //close connection
                conn.Close();
                MessageBox.Show("Genêros foram adicionados!");
            }

            //Abrir conexão para o proximo insert relacionado
            conn.Open();

            //Faz o loop pelos itens selecionados de diretores em filmes
            //Insere os ids dos generos na tabela relacionada
            if (lstBoxDiretor.SelectedItems.Count > 0)
            {

                //Faz o loop pelos itens selecionados
                foreach (object item in lstBoxDiretor.SelectedItems)
                {
                    //convert item to string
                    string checkedItem = item.ToString();
                    string idDiretor = checkedItem.Substring(0, 2);

                    sql1 = "Insert into filme_diretor(filme,diretor) Values (@filme,@diretor)";
                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.CommandText = sql1;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Connection = conn;

                    cmd4.Parameters.AddWithValue("@filme", idfilme); //add item
                    cmd4.Parameters.AddWithValue("@diretor", idDiretor); //add item
                    cmd4.ExecuteNonQuery();

                }

                //close connection
                conn.Close();
                MessageBox.Show("Diretores foram adicionados!");
            }

            //Abrir conexão para o proximo insert relacionado
            conn.Open();

            //Faz o loop pelos itens selecionados de paises em filmes
            //Insere os ids dos generos na tabela relacionada
            if (lstBoxPais.SelectedItems.Count > 0)
            {

                //Faz o loop pelos itens selecionados
                foreach (object item in lstBoxPais.SelectedItems)
                {
                    //convert item to string
                    string checkedItem = item.ToString();
                    string idPais = checkedItem.Substring(0, 2);

                    sql1 = "Insert into filme_pais(filme,pais) Values (@filme,@pais)";
                    SqlCommand cmd4 = new SqlCommand();
                    cmd4.CommandText = sql1;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.Connection = conn;

                    cmd4.Parameters.AddWithValue("@filme", idfilme); //add item
                    cmd4.Parameters.AddWithValue("@pais", idPais); //add item
                    cmd4.ExecuteNonQuery();

                }

                //close connection
                conn.Close();
                MessageBox.Show("Paises foram adicionados!");
            }


            

            //Mostra mensagem se tudo correr como deveria
            MessageBox.Show("Filme inserido com sucesso!", "Informação",
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

            atualizaGridDiretor();
            txtAddDiretorNomeLista.Clear();
            txtAddDiretorSobrenomeLista.Clear();
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


            atualizaGridPaises();
            txtAddPaisLista.Clear();
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


            atualizaGridGeneros();
            txtAddGeneroLista.Clear();
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
                picBoxNoticiaDestaque.Image = null;
                nomeFotoDestaque = null;
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


       

        private void btnCadastrarNoticiaBD_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            String sql1;
            String sql2;
            string aspas = "'";

            if (ckbDestaqueNoticia.Checked)
            {
                destacarNoticia = "on";
            }
            else
            {
                destacarNoticia = "off";
            }

            //Abrir conexão para o proximo insert relacionado

            //convert item to string
            string checkedItemRelac = comboBox1.SelectedItem.ToString();
            string relac = checkedItemRelac.Substring(0, 2);


            //Criando a string de inserção da notícia
            sql = "INSERT INTO noticias (tituloNoticia,subtitulo,texto,dataPost,horaPost,img,destaque,imgDestaque,relacionado)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtTituloNoticia.Text + aspas + ",";
            sql = sql + aspas + txtSubtituloNoticia.Text + aspas + ",";
            sql = sql + aspas + richtxtTextoNoticia.Text + aspas + ",";
            sql = sql + aspas + data + aspas + ",";
            sql = sql + aspas + hora + aspas + ",";
            sql = sql + aspas + nomeFoto + aspas + ",";
            sql = sql + aspas + destacarNoticia + aspas + ",";
            sql = sql + aspas + nomeFotoDestaque + aspas + ",";
            sql = sql + aspas + relac;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();


            //Puxa o id da noticia adicionada e atribui a variavel

            sql1 = "SELECT idnoticias FROM noticias WHERE tituloNoticia = " + "'" + txtTituloNoticia.Text + "'" + "";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = sql1;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;

            SqlDataReader carregador;
            //execução do comando
            carregador = cmd1.ExecuteReader();
            //verificando se o registro foi encontrado     

            if (carregador.Read())
            {
                idnoticia = carregador["idnoticias"].ToString();

            }

            carregador.Close();



            //Insere o id da noticia e o id da midia
            sql2 = "INSERT INTO noticia_midia (noticia,midia)";
            sql2 = sql2 + "VALUES (";
            sql2 = sql2 + idnoticia + ",";
            sql2 = sql2 + tipoMidia;
            sql2 = sql2 + ")";

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = sql2;
            cmd3.CommandType = CommandType.Text;
            cmd3.Connection = conn;
            cmd3.ExecuteNonQuery();


            MessageBox.Show("Notícia inserida com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gBoxCadastrarFilme_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastrarSerieBD_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            String sql1;
            String sql2;
            string aspas = "'";


            //Criando a string de inserção da série
            sql = "INSERT INTO series (titulo,elenco,sinopse,temporadas,duracao,poster,trailer)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtTituloSerie.Text + aspas + ",";
            sql = sql + aspas + txtElencoSerie.Text + aspas + ",";
            sql = sql + aspas + txtSinopseSerie.Text + aspas + ",";
            sql = sql + aspas + msktxtTempSerie.Text + aspas + ",";
            sql = sql + aspas + msktxtDuracaoSerie.Text + aspas + ",";
            sql = sql + aspas + nomeFoto + aspas + ",";
            sql = sql + aspas + txtURLSerie.Text;
            sql = sql + aspas + ")";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();


            //Puxa o id do filme adicionado e atribui a variavel

            sql1 = "SELECT idseries FROM series WHERE titulo = " + "'" + txtTituloSerie.Text + "'" + "";
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = sql1;
            cmd1.CommandType = CommandType.Text;
            cmd1.Connection = conn;

            SqlDataReader carregador;
            //execução do comando
            carregador = cmd1.ExecuteReader();
            //verificando se o registro foi encontrado     

            if (carregador.Read())
            {
                idserie = carregador["idseries"].ToString();

            }

            carregador.Close();

            //Insere o id da série e o id da midia
            sql2 = "INSERT INTO serie_midia (serie,midia)";
            sql2 = sql2 + "VALUES (";
            sql2 = sql2 + idserie + ",";
            sql2 = sql2 + midiaSerie;
            sql2 = sql2 + ")";




            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = sql2;
            cmd3.CommandType = CommandType.Text;
            cmd3.Connection = conn;
            cmd3.ExecuteNonQuery();




            //Mostra mensagem se tudo correr como deveria
            MessageBox.Show("Série inserida com sucesso!", "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

        }

        private void btnUploadImgPosterS_Click(object sender, EventArgs e)
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
                picBoxAddSerie.Image = new Bitmap(open.FileName);
                // image file path  
                lblCaminhoFotoF.Text = open.FileName;
            }
        }

        private void msktxtDataFilme_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";

            //Inserindo novos diretores
            sql = "INSERT INTO tags (tag)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtAddTagLista.Text;
            sql = sql + aspas + ")";


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Nova tag inserida com sucesso!", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);

            atualizaGridTags();
            txtAddTagLista.Clear();
        }

        private void lstBoxTags_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Atualiza a lista de tags após nova inserção
        private void atualizaGridTags()
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            string sql;
            sql = @"SELECT * FROM tags";
            

            //execução do comando
            SqlCommand cmd5 = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader rdr5 = cmd5.ExecuteReader();

            lstBoxTags.Items.Clear();
            while (rdr5.Read())

            {

                lstBoxTags.Items.Add(rdr5["idtags"] + "- " + rdr5["tag"]);

            }

            conn.Close();
        }

        //Atualiza a lista de diretores após nova inserção
        private void atualizaGridDiretor()
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);


            string diretores = @"SELECT * FROM diretores";

            SqlCommand cmd = new SqlCommand(diretores, conn);

            conn.Open();

            SqlDataReader rdr = cmd.ExecuteReader();

            lstBoxDiretor.Items.Clear();
            while (rdr.Read())

            {

                lstBoxDiretor.Items.Add(rdr["iddiretores"] + " - " + rdr["nomeDiretor"] + " " + rdr["sobrenomeDiretor"]);

            }

            conn.Close();
        }


        //Atualiza a lista de paises após nova inserção
        private void atualizaGridPaises()
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);


            string paises = @"SELECT * FROM paises";

            SqlCommand cmd1 = new SqlCommand(paises, conn);

            conn.Open();

            SqlDataReader rdr1 = cmd1.ExecuteReader();

            lstBoxPais.Items.Clear();

            while (rdr1.Read())

            {

                lstBoxPais.Items.Add(rdr1["idpaises"] + " - " + rdr1["nomePais"]);

            }

            conn.Close();
        }


        //Atualiza a lista de generos após nova inserção
        private void atualizaGridGeneros()
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);


            string generos = @"SELECT * FROM generos";

            SqlCommand cmd2 = new SqlCommand(generos, conn);

            conn.Open();

            SqlDataReader rdr2 = cmd2.ExecuteReader();


            lstBoxGenero.Items.Clear();

            while (rdr2.Read())

            {

                lstBoxGenero.Items.Add(rdr2["idgeneros"] + " - " + rdr2["nomegenero"]);
            }

            conn.Close();
        }

        private void carregarFilmes(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {

                tipoMidia = "1";

                conectar();
                // conectando com o banco 
                SqlConnection conn = new SqlConnection(conexao);


                string relacionado = @"SELECT * FROM filmes";

                SqlCommand cmd2 = new SqlCommand(relacionado, conn);

                conn.Open();

                SqlDataReader rdr2 = cmd2.ExecuteReader();


                comboBox1.Items.Clear();

                while (rdr2.Read())

                {

                    comboBox1.Items.Add(rdr2["idfilmes"] + " - " + rdr2["titulo"]);
                }

                conn.Close();

            }
            else
            {
                
                comboBox1.Items.Clear();
            }
        }

        private void picBoxNoticiaDestaque_Click(object sender, EventArgs e)
        {

        }
    }
}
