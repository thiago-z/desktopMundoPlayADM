using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MundoPlay
{


    public partial class admUser : Form
    {
        //variáveis globais
        String conexao;
        private void conectar()
        {
            //Habilitar e dasabilitar conexoes
            //Cenexão Casa
            conexao = "Data Source=DESKTOP-NBJI51Q;Initial Catalog=mundoPlay;Integrated Security=True";
            //Cenexão Senac
            //conexao = "Data Source=TIT0517587W10-1;Initial Catalog=mundoPlay;Integrated Security=True";
        }

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
            //exibe o painel de cadastro de usuário na frente
            gBoxCadastroUser.Visible = true;
            gBoxConsultaUser.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //exibe o painel de consulta de usuários na frente
            gBoxCadastroUser.Visible = false;
            gBoxConsultaUser.Visible = true;

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;


            sql = "SELECT * FROM login";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            SqlDataReader carregador;


            //execução do comando
            carregador = cmd.ExecuteReader();
            dgvConsultaUser.Rows.Clear();
            while (carregador.Read())
            {
                dgvConsultaUser.Rows.Add(carregador["idlogin"].ToString(),
                    carregador["nome"].ToString(),
                    carregador["email"].ToString(),
                    carregador["usuario"].ToString(),
                    carregador["imgAutor"].ToString(),
                    carregador["webmaster"].ToString());
            }



        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painelConsultaUser_Paint(object sender, PaintEventArgs e)
        {

        }

        String nomeFoto;

        private void btnUploadImgUser_Click(object sender, EventArgs e)
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
                pBoxFotoUser.Image = new Bitmap(open.FileName);
                // image file path  
                lblCaminho_Foto.Text = open.FileName;
            }


        }

        private void btnCadastrarUserBD_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";


            sql = "INSERT INTO login (nome,email,usuario,senha,imgAutor)";
            sql = sql + "VALUES (";
            sql = sql + aspas + txtNomeUser.Text + aspas + ",";
            sql = sql + aspas + txtEmailUser.Text + aspas + ",";
            sql = sql + aspas + txtUser.Text + aspas + ",";
            sql = sql + aspas + txtSenhaUser.Text + aspas + ",";
            sql = sql + aspas + nomeFoto;
            sql = sql + aspas + ")";

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro atualizado com sucesso", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);

        }

        private void checarSenhas(object sender, EventArgs e)
        {
            String senha1 = txtSenhaUser.Text;
            String senha2 = txtSenhaUserConf.Text;

            if (senha1 != senha2)
            {
                MessageBox.Show("Senhas NÃO conferem!\nVerifique as senhas digitadas.");
                txtSenhaUserConf.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // captura o id do usuário para alteração
        String IdUsuarioSelecionado;

        private void dgvConsultaUser_click(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvConsultaUser.CurrentRow.Cells[0].Value != null)

            {

                IdUsuarioSelecionado = dgvConsultaUser.CurrentRow.Cells[0].Value.ToString();

                dgvConsultaUser.CurrentRow.Cells[1].Value.ToString();

                dgvConsultaUser.CurrentRow.Cells[2].Value.ToString();

                dgvConsultaUser.CurrentRow.Cells[3].Value.ToString();

                dgvConsultaUser.CurrentRow.Cells[4].Value.ToString();

                dgvConsultaUser.CurrentRow.Cells[5].Value.ToString();



            }
        }

        private void dgvConsultaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluirUser.Enabled = true;
            btnRemoverADM.Enabled = true;
            btnAdicionarADM.Enabled = true;
        }

        private void btnRemoverADM_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            //mensagem para confirmar a exclusão
            if (MessageBox.Show("Tem certeza que quer remover ADM?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                String sql;
                sql = "UPDATE login SET webmaster=0 WHERE idlogin=" + IdUsuarioSelecionado;
                ;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                //execução do comando
                cmd.ExecuteNonQuery();

                //mostrando a mensagem que o registro foi apagado
                MessageBox.Show("Usuário removido de ADM com sucesso!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }


        }

        private void btnAdicionarADM_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            //mensagem para confirmar a exclusão
            if (MessageBox.Show("Tem certeza que quer tornar ADM?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                String sql;
                sql = "UPDATE login SET webmaster=1 WHERE idlogin=" + IdUsuarioSelecionado;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                //execução do comando
                cmd.ExecuteNonQuery();

                //mostrando a mensagem que o registro foi apagado
                MessageBox.Show("Usuário promovido a ADM com sucesso!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnExcluirUser_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            //mensagem para confirmar a exclusão
            if (MessageBox.Show("Tem certeza que quer excluir usuário?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                String sql;
                sql = "DELETE FROM login WHERE idlogin=" + IdUsuarioSelecionado;
                ;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                //execução do comando
                cmd.ExecuteNonQuery();

                //mostrando a mensagem que o registro foi apagado
                MessageBox.Show("Usuário removido com sucesso!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
