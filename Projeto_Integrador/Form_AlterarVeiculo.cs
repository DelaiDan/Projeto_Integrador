using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class Form_AlterarVeiculo : Form
    {
        int Codigo_Veiculo = PesquisarVeiculos.Codigo;
        string Caminho1;
        string Caminho2;
        string Caminho3;
        string Caminho4;

        //Consulta posterior
        public static string marca = "";
        public static string modelo = "";
        public static int ano;
        public static string condicao = "";
        public static float preco;

        public int Codigo_Usuario = Login.codigo_usuario;
        public Form_AlterarVeiculo()
        {
            InitializeComponent();

        }

        private void Form_AlterarVeiculo_Load(object sender, EventArgs e)
        {
            var frmVeiculo = (Form_Veiculo)Owner;
            frmVeiculo.RemoveOwnedForm(this);
            frmVeiculo.Close();

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
            comm.Parameters["@Codigo"].Value = Codigo_Veiculo;

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
                        cbMarca.Text = marca;

                        modelo = reader["Modelo"].ToString();
                        txModelo.Text = modelo;

                        txAno.Text = reader["Ano"].ToString();
                        ano = Convert.ToInt32(reader["Ano"]);

                        condicao = reader["Condicao"].ToString();
                        cbCondicao.Text = condicao;

                        preco = Convert.ToSingle(reader["Preço"]);
                        txPreço.Text = reader["Preço"].ToString();

                        cbCambio.Text = reader["Cambio"].ToString();
                        txPotencia.Text = reader["Potencia"].ToString();
                        txConsumo.Text = reader["Consumo"].ToString();
                        cbCombustivel.Text = reader["Combustivel"].ToString();
                        Caminho1 = reader["Caminho1"].ToString();
                        Caminho2 = reader["Caminho2"].ToString();
                        Caminho3 = reader["Caminho3"].ToString();
                        Caminho4 = reader["Caminho4"].ToString();
                        txCaminho1.Text = reader["Caminho1"].ToString();
                        txCaminho2.Text = reader["Caminho2"].ToString();
                        txCaminho3.Text = reader["Caminho3"].ToString();
                        txCaminho4.Text = reader["Caminho4"].ToString();
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

        private void Imagem1_Click(object sender, EventArgs e)
        {
            //Abre caixa de diálogo 
            OpenFileDialog open = new OpenFileDialog();
            //Extensões Utilizáveis
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Mostra Imagem 
                Imagem1.Image = new Bitmap(open.FileName);
                //Caminho da Imagem  
                txCaminho1.Text = open.FileName;

            }
        }

        private void Imagem2_Click(object sender, EventArgs e)
        {
            //Abre caixa de diálogo   
            OpenFileDialog open = new OpenFileDialog();
            //Extensões Utilizáveis
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Mostra Imagem 
                Imagem2.Image = new Bitmap(open.FileName);
                //Caminho da Imagem   
                txCaminho2.Text = open.FileName;

            }
        }

        private void Imagem3_Click(object sender, EventArgs e)
        {
            //Abre caixa de diálogo   
            OpenFileDialog open = new OpenFileDialog();
            //Extensões Utilizáveis
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Mostra Imagem  
                Imagem3.Image = new Bitmap(open.FileName);
                //Caminho da Imagem 
                txCaminho3.Text = open.FileName;

            }
        }

        private void Imagem4_Click(object sender, EventArgs e)
        {
            //Abre caixa de diálogo
            OpenFileDialog open = new OpenFileDialog();
            //Extensões Utilizáveis
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Mostra Imagem 
                Imagem4.Image = new Bitmap(open.FileName);
                //Caminho da Imagem 
                txCaminho4.Text = open.FileName;

            }
        }

        public bool ChecarVazio()
        {
            if (String.IsNullOrEmpty(cbMarca.Text)
            || String.IsNullOrEmpty(txModelo.Text)
            || String.IsNullOrEmpty(txAno.Text)
            || String.IsNullOrEmpty(cbCondicao.Text)
            || String.IsNullOrEmpty(txPreço.Text)
            || String.IsNullOrEmpty(cbCambio.Text)
            || String.IsNullOrEmpty(txPotencia.Text)
            || String.IsNullOrEmpty(txConsumo.Text)
            || String.IsNullOrEmpty(cbCombustivel.Text)
            || String.IsNullOrEmpty(txCaminho1.Text)
            || String.IsNullOrEmpty(txCaminho2.Text)
            || String.IsNullOrEmpty(txCaminho3.Text)
            || String.IsNullOrEmpty(txCaminho4.Text))

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

        private void btAlterarVeiculo_Click(object sender, EventArgs e)
        {
            if (ChecarVazio())
            {
                bool bOk = true;


                SqlConnection conn;
                SqlCommand comm;

                string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

                conn = new SqlConnection(connectionString);


                comm = new SqlCommand(
                    "UPDATE Veiculos SET Marca = @Marca, Modelo = @Modelo, Ano = @Ano, Condicao = @Condicao, Cambio = @Cambio, Potencia = @Potencia, Consumo = @Consumo, " +
                    "Combustivel = @Combustivel, Caminho1 = @Caminho1, Caminho2 = @Caminho2, Caminho3 = @Caminho3, Caminho4 = @Caminho4, Preço = @Preço " +
                    "WHERE Codigo = @Codigo ", conn);

                comm.Parameters.Add("@Marca", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Marca"].Value = cbMarca.Text;

                comm.Parameters.Add("@Modelo", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Modelo"].Value = txModelo.Text;

                comm.Parameters.Add("@Ano", System.Data.SqlDbType.Int);
                comm.Parameters["@Ano"].Value = Convert.ToInt32(txAno.Text);

                comm.Parameters.Add("@Condicao", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Condicao"].Value = cbCondicao.Text;

                comm.Parameters.Add("@Cambio", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Cambio"].Value = cbCambio.Text;

                comm.Parameters.Add("@Potencia", System.Data.SqlDbType.Int);
                comm.Parameters["@Potencia"].Value = Convert.ToInt32(txPotencia.Text);

                comm.Parameters.Add("@Consumo", System.Data.SqlDbType.Float);
                comm.Parameters["@Consumo"].Value = Convert.ToSingle(txConsumo.Text);

                comm.Parameters.Add("@Combustivel", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Combustivel"].Value = cbCombustivel.Text;

                comm.Parameters.Add("@Caminho1", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Caminho1"].Value = txCaminho1.Text;

                comm.Parameters.Add("@Caminho2", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Caminho2"].Value = txCaminho2.Text;

                comm.Parameters.Add("@Caminho3", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Caminho3"].Value = txCaminho3.Text;

                comm.Parameters.Add("@Caminho4", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Caminho4"].Value = txCaminho4.Text;

                comm.Parameters.Add("@Preço", System.Data.SqlDbType.Float);
                comm.Parameters["@Preço"].Value = Convert.ToSingle(txPreço.Text);

                comm.Parameters.Add("@Codigo", System.Data.SqlDbType.Int);
                comm.Parameters["@Codigo"].Value = Convert.ToInt32(Codigo_Veiculo);

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
                        MessageBox.Show("Veículo Alterado com SUCESSO!!",
                            "Cadastro de Veículos!",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VOCÊ DEVE PREENCHER TODOS OS CAMPOS E IMAGENS", "ATENÇÃO!!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btLimparVeiculo_Click(object sender, EventArgs e)
        {
            cbMarca.Text = "";
            txModelo.Clear();
            txAno.Clear();
            cbCondicao.Text = "";
            txPreço.Clear();
            cbCambio.Text = "";
            txPotencia.Clear();
            txConsumo.Clear();
            cbCombustivel.Text = "";
            txCaminho1.Clear();
            txCaminho2.Clear();
            txCaminho3.Clear();
            txCaminho4.Clear();
            Imagem1.Image = new Bitmap(@"C:\Users\arthu\Pictures\add-camera-icon-icon-add-11553485583calilemiyg.png", true);
            Imagem2.Image = new Bitmap(@"C:\Users\arthu\Pictures\add-camera-icon-icon-add-11553485583calilemiyg.png", true);
            Imagem3.Image = new Bitmap(@"C:\Users\arthu\Pictures\add-camera-icon-icon-add-11553485583calilemiyg.png", true);
            Imagem4.Image = new Bitmap(@"C:\Users\arthu\Pictures\add-camera-icon-icon-add-11553485583calilemiyg.png", true);

        }

        private void bt_Cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
