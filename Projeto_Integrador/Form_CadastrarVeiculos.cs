using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projeto_Integrador
{
    public partial class Form_CadastrarVeiculos : Form
    {

        public Form_CadastrarVeiculos()
        {
            InitializeComponent();
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
            if(String.IsNullOrEmpty(cbMarca.Text)
            || String.IsNullOrEmpty(txModelo.Text)
            || String.IsNullOrEmpty(txAno.Text)
            || String.IsNullOrEmpty(cbEstado.Text)
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

        private void btAdicionarVeiculo_Click(object sender, EventArgs e)
        {
            if (ChecarVazio())
            {
                bool bOk = true;


                SqlConnection conn;
                SqlCommand comm;

                string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

                conn = new SqlConnection(connectionString);


                comm = new SqlCommand(
                    "INSERT INTO Veiculos (Marca, Modelo, Ano, Estado, Cambio, Potencia, Consumo, Combustivel, Caminho1, Caminho2, Caminho3, Caminho4, Preço) " +
                    "VALUES (@Marca, @Modelo, @Ano, @Estado, @Cambio, @Potencia, @Consumo, @Combustivel, @Caminho1, @Caminho2, @Caminho3, @Caminho4, @Preço)", conn);

                comm.Parameters.Add("@Marca", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Marca"].Value = cbMarca.Text;

                comm.Parameters.Add("@Modelo", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Modelo"].Value = txModelo.Text;

                comm.Parameters.Add("@Ano", System.Data.SqlDbType.Int);
                comm.Parameters["@Ano"].Value = Convert.ToInt32(txAno.Text);

                comm.Parameters.Add("@Estado", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Estado"].Value = cbEstado.Text;

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
                        MessageBox.Show("Veículo Cadastrado com SUCESSO!!",
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

        private void Form_CadastrarVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void btLimparVeiculo_Click(object sender, EventArgs e)
        {
            cbMarca.Text = "";
            txModelo.Clear();
            txAno.Clear();
            cbEstado.Text = "";
            txPreço.Clear();
            cbCambio.Text = "";
            txPotencia.Clear();
            txConsumo.Clear();
            cbCombustivel.Text = "";
            txCaminho1.Clear();
            txCaminho2.Clear();
            txCaminho3.Clear();
            txCaminho4.Clear();
            Imagem1.Image = null;
            Imagem2.Image = null;
            Imagem3.Image = null;
            Imagem4.Image = null;

        }
    }
}