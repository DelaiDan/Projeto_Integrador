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
        string Usuario_Cadastro;

        //Consulta posterior
        public static string marca = "";
        public static string modelo = "";
        public static int ano;
        public static string condicao = "";
        public static float preco;


        public Form_Veiculo()
        {
            InitializeComponent();
        }

        private void Form_Veiculo_Load_1(object sender, EventArgs e)
        {
            bool bOk = true;

            SqlConnection conn;
            SqlCommand comm, comm2;
            SqlDataReader reader;

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

            conn = new SqlConnection(connectionString);


            comm = new SqlCommand("SELECT V.Marca, V.Modelo, V.Ano, V.Condicao, V.Cambio, V.Potencia, V.Consumo, V.Combustivel, V.Preço, V.Caminho1, V.Caminho2, V.Caminho3, V.Caminho4, U.usuario " +
                                    "FROM Veiculos AS V " +
                                    "INNER JOIN Usuarios AS U ON U.id_usuario = V.ID_Usuario " +
                                    "WHERE Codigo = @Codigo", conn);

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
                        marca = reader["Marca"].ToString();
                        txMarca.Text = marca;

                        modelo = reader["Modelo"].ToString();
                        txModelo.Text = modelo;

                        txAno.Text = reader["Ano"].ToString();
                        ano = Convert.ToInt32(reader["Ano"]);

                        condicao = reader["Condicao"].ToString();
                        txCondicao.Text = condicao;

                        preco = Convert.ToSingle(reader["Preço"]);
                        txPreço.Text = reader["Preço"].ToString();

                        txCambio.Text = reader["Cambio"].ToString();
                        txPotencia.Text = reader["Potencia"].ToString();
                        txConsumo.Text = reader["Consumo"].ToString();
                        txCombustivel.Text = reader["Combustivel"].ToString();
                        Caminho1 = reader["Caminho1"].ToString();
                        Caminho2 = reader["Caminho2"].ToString();
                        Caminho3 = reader["Caminho3"].ToString();
                        Caminho4 = reader["Caminho4"].ToString();

                        Usuario_Cadastro = reader["usuario"].ToString();
                        lbUsuario_Cadastro.Text = "Criado por: " + Usuario_Cadastro;
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
            if (Login.tipo == "Vendedor" || Login.tipo == "Administrador")
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

        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            AlterarVeiculo frmAlterarVeiculo = new AlterarVeiculo();

            frmAlterarVeiculo.ShowDialog(this);
        }
    }
}
