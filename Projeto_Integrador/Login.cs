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

namespace Projeto_Integrador
{
    public partial class Login : Form
    {
        //Abrindo conexão e setando string e booleanas para facilitação futura
        SqlConnection sqlConn = null;
        SqlDataReader reader;
        private string strCoon = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";
        private string strSql = string.Empty;
        private string strSql2 = string.Empty;
        public bool logado = false;


        public Login()
        {
            InitializeComponent();
        }


        public static int tipo;

        public void logar()
        {
            sqlConn = new SqlConnection(strCoon);

            Criptografia sigilo = new Criptografia();

            string usuario, senha;

                usuario = txUsuario.Text;
            //senha = txSenha.Text;    
            senha = sigilo.GerarHashMd5(txSenha.Text);

            //Pega informações e compara com a DataBase
            strSql = "SELECT tipo FROM Usuarios WHERE usuario = @usuario AND senha = @senha";

                SqlCommand cmd = new SqlCommand(strSql, sqlConn);

                cmd.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                cmd.Parameters.Add("@senha", SqlDbType.NVarChar).Value = senha;


            strSql2 = "SELECT COUNT(id_usuario) FROM Usuarios WHERE usuario = @usuario AND senha = @senha";

                SqlCommand cmd2 = new SqlCommand(strSql2, sqlConn);

                cmd2.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
                cmd2.Parameters.Add("@senha", SqlDbType.NVarChar).Value = senha;

            try
            {
                try
                {
                    sqlConn.Open();

                    int T = (int)cmd2.ExecuteScalar(); // Retorna o número de Linhas encontradas com semelhança

                    if (T > 0)
                    {
                        logado = true;
                        Dispose();
                    }

                    else
                    {
                        MessageBox.Show("Usuário e/ou Senha Errados");
                        logado = false;
                        Application.Restart();

                    }
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao abrir a conexão com a base de dados!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tipo = Convert.ToInt32(reader["tipo"]);
                    }

                    reader.Close(); //Encerra o leitor de dados
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error + " no Banco.");
                }
            }
            catch { }
            finally
            {
                sqlConn.Close();
            }
        }
        private void btLogar_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
}
