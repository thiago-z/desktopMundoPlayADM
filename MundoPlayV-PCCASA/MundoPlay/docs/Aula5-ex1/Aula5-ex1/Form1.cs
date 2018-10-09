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


namespace Aula5_ex1
{
    public partial class Form1 : Form
    {
        //variáveis globais
        string novo = "sim"; 
        string consulta_lupa = "nao";
        String conexao;
        private void conectar()
        {           
            conexao = "Data Source=TIT0517600W10-1;Initial Catalog=Informacoes;Integrated Security=True";
        }
        public Form1()
        {
            InitializeComponent();
        }

          private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }


  

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

      

        private void btnNovo_Click(object sender, EventArgs e)
        {
            //limpando a tela
            limpar();
            //habilitando os controles
            btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = false;
            lblId.Enabled = true;
            pctFoto.Enabled = true;
            foreach (Control c in this.Controls)
            {   //  || = ou
                if (c is TextBox ||
                    c is MaskedTextBox ||
                    c is ComboBox)
                {
                    c.Enabled = true;
                }
                txtCpf.Focus();
            }

        }

       

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            consulta_lupa = "sim";
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;

            /*vamos verificar se o conteúdo da
             * caixa de texto é numero ou 
             * caracter */
            short numero;
            if (short.TryParse(txtId.Text, out numero))
            {
                sql = "SELECT * FROM clientes WHERE id =" + txtId.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                SqlDataReader carregador;
                //execução do comando
                carregador = cmd.ExecuteReader();
                limpar();
                //verificando se o registro foi encontrado
                if (carregador.Read())
                {
                    txtNome.Text = carregador["nome"].ToString();
                    txtEndereco.Text = carregador["endereco"].ToString();
                    txtBairro.Text = carregador["bairro"].ToString();
                    txtCep.Text = carregador["cep"].ToString();
                    txtCidade.Text = carregador["cidade"].ToString();
                    cmbUf.Text = carregador["uf"].ToString();
                    lblId.Text = carregador["id"].ToString();
                    txtTelefone.Text = carregador["telefone"].ToString();
                    txtCpf.Text = carregador["cpf"].ToString();
                    lblCaminho_Foto.Text = 
                        carregador["img"].ToString();
                    if (lblCaminho_Foto.Text == "")
                    {
                        lblCaminho_Foto.Text =
              "C:/Users/andre.osousa/Documents/Aula5-ex1/silhueta.png";
                    }
                    pctFoto.ImageLocation = lblCaminho_Foto.Text;
                    pctFoto.Load();

                    if (MessageBox.Show("Deseja fazer alteração?",
                   "Atenção", MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        novo = "nao";
                        //desabilitar / habilitar alguns botões
                        btnSalvar.Enabled = true;
                        btnExcluir.Enabled = false;
                        foreach (Control c in this.Controls)
                        {   //  || = ou
                            if (c is TextBox ||
                                c is MaskedTextBox ||
                                c is ComboBox)
                            {
                                c.Enabled = true;
                            }
                            txtCpf.Focus();
                        }

                    }
                    else
                    {
                        //desabilitar / habilitar alguns botões
                        btnSalvar.Enabled = false;
                        btnExcluir.Enabled = true;
                        btnLimpar.Enabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("Id não foi encontrado!!!",
                        "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            else
            {
                atualizaGrid();
            }
        }

        private void atualizaGrid()
        {
            String sql;
            sql = "SELECT * FROM clientes WHERE nome LIKE '%";
            sql = sql + txtId.Text + "%'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            SqlConnection conn = new SqlConnection(conexao);
            cmd.Connection = conn;
            SqlDataReader carregador;
            conn.Open();

            //execução do comando
            carregador = cmd.ExecuteReader();
            dgvDados.Rows.Clear();
            while (carregador.Read())
            {
                dgvDados.Rows.Add(carregador["id"].ToString(),
                    carregador["nome"].ToString(),
                    carregador["endereco"].ToString(),
                    carregador["cep"].ToString(),
                    carregador["bairro"].ToString(),
                    carregador["cidade"].ToString(),
                    carregador["uf"].ToString(),
                    carregador["telefone"].ToString(),
                    carregador["cpf"].ToString(),
                    carregador["img"].ToString());
            }
        }

        private void dgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.CurrentRow.Cells[0].Value != null)

            {
                lblId.Text =
                    dgvDados.CurrentRow.Cells[0].Value.ToString();
                txtNome.Text =
                    dgvDados.CurrentRow.Cells[1].Value.ToString();
                txtEndereco.Text =
                    dgvDados.CurrentRow.Cells[2].Value.ToString();
                txtCep.Text =
                    dgvDados.CurrentRow.Cells[3].Value.ToString();
                txtBairro.Text =
                    dgvDados.CurrentRow.Cells[4].Value.ToString();
                txtCidade.Text =
                    dgvDados.CurrentRow.Cells[5].Value.ToString();
                cmbUf.Text =
                    dgvDados.CurrentRow.Cells[6].Value.ToString();
                txtTelefone.Text =
                    dgvDados.CurrentRow.Cells[7].Value.ToString();
                txtCpf.Text =
                    dgvDados.CurrentRow.Cells[8].Value.ToString();
                lblCaminho_Foto.Text =
                    dgvDados.CurrentRow.Cells[9].Value.ToString();
                pctFoto.ImageLocation = lblCaminho_Foto.Text;
                
            }
        }
       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;
            string aspas = "'";
            if (novo == "sim")
            {
                sql = "INSERT INTO clientes (cpf,nome,endereco,";
                sql = sql + "cep,bairro,cidade,uf,telefone,img)";
                sql = sql + "VALUES (";
                sql = sql + aspas + txtCpf.Text + aspas + ",";
                sql = sql + aspas + txtNome.Text + aspas + ",";
                sql = sql + aspas + txtEndereco.Text + aspas + ",";
                sql = sql + aspas + txtCep.Text + aspas + ",";
                sql = sql + aspas + txtBairro.Text + aspas + ",";
                sql = sql + aspas + txtCidade.Text + aspas + ",";
                sql = sql + aspas + cmbUf.Text + aspas + ",";
                sql = sql + aspas + txtTelefone.Text + aspas + ",";
                sql = sql + aspas + lblCaminho_Foto.Text + aspas + ")";
            }
            else
            {
                sql = "UPDATE clientes SET ";
                sql = sql + "nome ="+ aspas + txtNome.Text + aspas + ",";
                sql = sql + "endereco="+aspas+ txtEndereco.Text + aspas + ",";
                sql = sql + "cep=" + aspas + txtCep.Text + aspas + ",";
                sql = sql + "bairro=" + aspas + txtBairro.Text + aspas + ",";
                sql = sql + "cidade=" + aspas + txtCidade.Text + aspas + ",";
                sql = sql + "uf=" + aspas + cmbUf.Text + aspas + ",";
                sql = sql + "telefone=" + aspas + txtTelefone.Text + aspas + ",";
                sql = sql + "img=" + aspas + 
                    lblCaminho_Foto.Text + aspas + ",";
                sql = sql + "cpf=" + aspas + txtCpf.Text + aspas ;
                sql = sql + " WHERE id=" + lblId.Text;
             }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registro atualizado com sucesso", "Informação",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
            limpar();
            atualizaGrid();
        }

        private void limpar()
        {
            foreach (Control luan in this.Controls)
            {
                //  || = ou
                if (luan is TextBox || luan is MaskedTextBox)
                {
                    luan.Text = "";
                }
            }
            cmbUf.SelectedIndex = -1;
            lblId.Text = "";
            consulta_lupa = "nao";
            lblCaminho_Foto.Text =
                "C:/Users/andre.osousa/Documents/Aula5-ex1/silhueta.png";
            pctFoto.ImageLocation = lblCaminho_Foto.Text;
            pctFoto.Load();
            txtCpf.Focus();
        }
      

            private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (consulta_lupa == "nao")
            {
                /*vamos pesquisar o cpf para ver se o 
                 * registro já foi cadastrado ou não*/

                conectar();
                // conectando com o banco 
                SqlConnection conn = new SqlConnection(conexao);

                // abrindo conexão
                conn.Open();
                String aspas = "'";
                String sql;
                sql = "SELECT * FROM clientes WHERE cpf =" + aspas + txtCpf.Text + aspas;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                SqlDataReader carregador;
                //execução do comando
                carregador = cmd.ExecuteReader();

                //verificando se o registro foi encontrado
                if (carregador.Read())
                {
                    txtNome.Text = carregador["nome"].ToString();
                    txtEndereco.Text = carregador["endereco"].ToString();
                    txtBairro.Text = carregador["bairro"].ToString();
                    txtCep.Text = carregador["cep"].ToString();
                    txtCidade.Text = carregador["cidade"].ToString();
                    cmbUf.Text = carregador["uf"].ToString();
                    lblId.Text = carregador["id"].ToString();
                    txtTelefone.Text = carregador["telefone"].ToString();
                    txtCpf.Text = carregador["cpf"].ToString();
                    lblCaminho_Foto.Text =
                        carregador["caminho_foto"].ToString();
                    if (lblCaminho_Foto.Text == "")
                    {
                        lblCaminho_Foto.Text =
              "C:/Users/silvia.scsfiacador/Desktop/Aula5-ex1/silhueta.png";
                    }
                    //carregando a foto
                    pctFoto.ImageLocation = lblCaminho_Foto.Text;
                    pctFoto.Load();

                    if (MessageBox.Show("Cliente já cadastrado!\nDeseja fazer alteração?",
                       "Atenção", MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question,
                       MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        novo = "nao";
                        //desabilitar / habilitar alguns botões
                        btnSalvar.Enabled = true;
                        btnExcluir.Enabled = false;
                    }
                    else
                    {
                        //desabilitar / habilitar alguns botões
                        btnSalvar.Enabled = false;
                        btnExcluir.Enabled = true;
                    }
                }
                consulta_lupa = "nao";
            }

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            //mensagem para confirmar a exclusão
            if (MessageBox.Show("Tem certeza que quer excluir?",
                "Atenção", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                String sql;
                sql = "DELETE FROM clientes WHERE id=" + lblId.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;

                //execução do comando
                cmd.ExecuteNonQuery();
                //limpando a tela
                limpar();
                //mostrando a mensagem que o registro foi apagado
                MessageBox.Show("Cliente excluído com sucesso!",
                    "Informação", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
        }

        private void pctFoto_Click(object sender, EventArgs e)
        {

            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                pctFoto.ImageLocation = ofdFoto.FileName;
                pctFoto.Load();
                lblCaminho_Foto.Text = ofdFoto.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

