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
    public partial class Form_CadastrarUsuarios : Form
    {
        public string Tipo;
        public Form_CadastrarUsuarios()
        {
            InitializeComponent();
        }

        public bool ChecaVazio()
        {
            if (String.IsNullOrEmpty(txNome.Text)
            || String.IsNullOrEmpty(txSobrenome.Text)
            || String.IsNullOrEmpty(txUsuario.Text)
            || String.IsNullOrEmpty(txSenha.Text)
            || String.IsNullOrEmpty(txConfirmaSenha.Text)
            || Tipo == "")
            {

                MessageBox.Show("Algum campo não está preenchido!",
                            "ERRO!",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool SenhaConfirmada()
        {
            string senha, confirmada;

            senha = txSenha.Text;
            confirmada = txConfirmaSenha.Text;

            if (senha == confirmada)
            {
                return true;
            }
            else
            {

                MessageBox.Show("As Senhas não são iguais!");
                txConfirmaSenha.Clear();
                txSenha.Clear();
                return false;
            }
        }

        public void TipoDeUsuario()
        {
            if (rbAdministrador.Checked)
            {
                Tipo = "Administrador";
            }

            else if (rbGerente.Checked)
            {
                Tipo = "Gerente";
            }
            else if (rbVendedor.Checked)
            {
                Tipo = "Vendedor";
            }
        }

        public void LimpaCampos()
        {
            txUsuario.Clear();
            txNome.Clear();
            txSobrenome.Clear();
            txSenha.Clear();
            txConfirmaSenha.Clear();
        }

        public void CadastrarUsuario()
        {
            if (SenhaConfirmada() && ChecaVazio())
            {

                bool bOk = true;
                Criptografia sigilo = new Criptografia();
                String senha = sigilo.GerarHashMd5(txSenha.Text);

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
                comm.Parameters["@senha"].Value = senha;

                comm.Parameters.Add("@nome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nome"].Value = txNome.Text;

                comm.Parameters.Add("@sobrenome", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@sobrenome"].Value = txSobrenome.Text;

                comm.Parameters.Add("@tipo", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@tipo"].Value = Tipo;

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

                        LimpaCampos();
                    }
                }
            }
        }

        private void btCadastrarUsuario_Click(object sender, EventArgs e)
        {
            TipoDeUsuario();
            CadastrarUsuario();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
    }
}
