﻿using System;
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
    public partial class login : Form
    {

        //variáveis globais
        String conexao;
        private void conectar()
        {
            conexao = "Data Source=DESKTOP-NBJI51Q;Initial Catalog=cinema_v7;Integrated Security=True";
        }


        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conectar();
            // conectando com o banco 
            SqlConnection conn = new SqlConnection(conexao);

            // abrindo conexão
            conn.Open();
            String sql;

            /*vamos verificar login e senha e privilegios */

            sql = "SELECT * FROM login WHERE usuario = " + txtUsuario + " AND senha = " + txtSenha + "";
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
                string nomeUsuario = carregador["nome"].ToString();
                string webmaster = carregador["webmaster"].ToString();
            }

            //abrir tela do usuario
            //instanciar
            CadastroHome cadastroHome = new CadastroHome();
            cadastroHome.ShowDialog();


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
