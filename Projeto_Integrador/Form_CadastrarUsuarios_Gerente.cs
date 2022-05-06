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
    public partial class Form_CadastrarUsuarios_Gerente : Form
    {
        public Form_CadastrarUsuarios_Gerente()
        {
            InitializeComponent();
        }

        private void btCadastrarUsuario_Click_1(object sender, EventArgs e)
        {
            Form_CadastrarUsuarios f1 = new Form_CadastrarUsuarios();

            if (f1.SenhaConfirmada() && f1.ChecaVazio())
            {

                bool bOk = true;


                SqlConnection conn;
                SqlCommand comm;

                string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

                conn = new SqlConnection(connectionString);


                comm = new SqlCommand(
                    "INSERT INTO Usuarios (usuario, senha, nome, sobrenome, tipo) " +
                    "VALUES (@usuario, @senha, @nome, @sobrenome, @tipo)", conn);

                comm.Parameters.Add("@usuario", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@usuario"].Value = txUsuario.Text;

                comm.Parameters.Add("@senha", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@senha"].Value = txSenha.Text;

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@sobrenome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@sobrenome"].Value = txSobrenome.Text;

                comm.Parameters.Add("@tipo", System.Data.SqlDbType.Int);
                comm.Parameters["@tipo"].Value = f1.Tipo;

                try
                {
                    //Abrir a conexão com o Banco de Dados
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar abrir uma conexão com o banco de dados.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOk = false;
                    }

                    //Executa o comando SQL para inserir dados na base de dados
                    try
                    {
                        comm.ExecuteNonQuery();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message,
                            "Erro ao tentar executar o comando SQL.",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        bOk = false;
                    }

                }
                catch { }
                finally
                {
                    conn.Close();

                    if (bOk == true)
                    {
                        MessageBox.Show("Pessoa Cadastrada com SUCESSO!!",
                            "Cadastro de Usuários",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txUsuario.Clear();
            txNome.Clear();
            txSobrenome.Clear();
            txSenha.Clear();
            txConfirmaSenha.Clear();
        }
    }
}
