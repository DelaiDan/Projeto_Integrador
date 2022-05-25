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

    public partial class Form_Veiculo : Form
    {
        int Codigo = PesquisarVeiculos.Codigo;
        string Caminho1;
        string Caminho2;
        string Caminho3;
        string Caminho4;

        public Form_Veiculo()
        {
            InitializeComponent();
        }

        private void Form_Veiculo_Load_1(object sender, EventArgs e)
        {
            bool bOk = true;

            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

            conn = new SqlConnection(connectionString);


            comm = new SqlCommand("SELECT Marca, Modelo, Ano, Condicao, Cambio, Potencia, Consumo, Combustivel, Preço, Caminho1, Caminho2, Caminho3, Caminho4 " +
                                   "FROM Veiculos WHERE Codigo = @Codigo", conn); ;

            comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
            comm.Parameters["@Codigo"].Value = Codigo;

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

                try
                {
                    //Executa SELECT
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        txMarca.Text = reader["Marca"].ToString();
                        txModelo.Text = reader["Modelo"].ToString();
                        txAno.Text = reader["Ano"].ToString();
                        txCondicao.Text = reader["Condicao"].ToString();
                        txPreço.Text = reader["Preço"].ToString();
                        txCambio.Text = reader["Cambio"].ToString();
                        txPotencia.Text = reader["Potencia"].ToString();
                        txConsumo.Text = reader["Consumo"].ToString();
                        txCombustivel.Text = reader["Combustivel"].ToString();
                        Caminho1 = reader["Caminho1"].ToString();
                        Caminho2 = reader["Caminho2"].ToString();
                        Caminho3 = reader["Caminho3"].ToString();
                        Caminho4 = reader["Caminho4"].ToString();
                    }

                    reader.Close(); //Encerra o leitor de dados

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro ao executar o comando SELECT!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }

            Imagem1.Image = Image.FromFile(Caminho1);
            Imagem2.Image = Image.FromFile(Caminho2);
            Imagem3.Image = Image.FromFile(Caminho3);
            Imagem4.Image = Image.FromFile(Caminho4);
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (Login.tipo < 3)
            {
                Form_StatusExclusao frmStatusExclusao = new Form_StatusExclusao();

                frmStatusExclusao.ShowDialog(this);

                Dispose();
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar este recurso.");
            }
        }
    }
}
