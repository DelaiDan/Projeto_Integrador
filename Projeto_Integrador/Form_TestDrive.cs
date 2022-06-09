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
    public partial class Form_TestDrive : Form
    {
        int Codigo_Veiculo = 0;
        string Veiculo;
        string Usuario_Criador = Login.nome_usuario;
        string Usuario_Realizador;
        string Cliente;

        string Data;
        string Hora;

        SqlConnection conn;
        SqlCommand comm;

        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";
        private string strSql = string.Empty;
        private string strSql2 = string.Empty;

        SqlDataReader reader;
        SqlDataAdapter adapt;
        DataTable dt;

        public Form_TestDrive()
        {
            InitializeComponent();
            dt_escolherData.CustomFormat = "dd/MM/yy -- HH:mm";
            lb_Criador.Text = Usuario_Criador + " (" + Login.tipo + ")";
            TestDrive_Preview();
        }

        private void TestDrive_Preview()
        {
            lb_Preview.Text = "Veiculo : " + Veiculo + "\nUsuário: " + Usuario_Realizador + "\nData: " + Data + " às " + Hora + "\nCliente: " + Cliente;
        }

        private bool ChecarVazio()
        {
            int checa_data = DateTime.Compare(dt_escolherData.Value, DateTime.Now);
            if (Codigo_Veiculo <= 0 || 
                String.IsNullOrEmpty(Veiculo) ||
                String.IsNullOrEmpty(Usuario_Criador) ||
                String.IsNullOrEmpty(Usuario_Realizador) ||
                String.IsNullOrEmpty(Data) ||
                String.IsNullOrEmpty(Hora) ||
                String.IsNullOrEmpty(Cliente) ||
                checa_data <= 0
                )
            {
                MessageBox.Show("Algum campo não está preenchido,\nou está preenchido incorretamente!",
                                 "ERRO!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Grid View
        private void Form_TestDrive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.projetoDataSet.Usuarios);
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT Codigo, Marca, Modelo, Ano, Condicao, Cambio, Potencia, Consumo, Combustivel, Preço " +
                                        "FROM Veiculos", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txModelo_TextChanged_1(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Veiculos WHERE Modelo LIKE '" + txModelo.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txMarca_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Veiculos WHERE Marca LIKE '" + txMarca.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txAno_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Veiculos WHERE Ano LIKE '" + txAno.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txCondicao_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Veiculos WHERE Condicao LIKE '" + txCondicao.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void txPreço_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Veiculos WHERE Preço LIKE '" + txPreço.Text + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string CodigoStr = row.Cells["Codigo"].Value.ToString();
            Codigo_Veiculo = Convert.ToInt32(CodigoStr);
            Veiculo = row.Cells["Modelo"].Value.ToString();

            TestDrive_Preview();
        }


        //Data
        private void dt_escolherData_ValueChanged(object sender, EventArgs e)
        {
            Data = dt_escolherData.Value.ToShortDateString();
            Hora = dt_escolherData.Value.ToShortTimeString();

            lb_dataEscolhida.Text = dt_escolherData.Value.ToShortDateString();
            lb_horaEscolhida.Text = dt_escolherData.Value.ToShortTimeString();

            TestDrive_Preview();
        }

        private void cb_Realizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario_Realizador = this.cb_Realizador.GetItemText(this.cb_Realizador.SelectedItem);
            TestDrive_Preview();
        }

        private void tx_Cliente_TextChanged(object sender, EventArgs e)
        {
            Cliente = tx_Cliente.Text;
            TestDrive_Preview();
        }

        //INSERT
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            if (ChecarVazio())
            {
                bool bOk = true;


                SqlConnection conn;
                SqlCommand comm;

                string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

                conn = new SqlConnection(connectionString);


                comm = new SqlCommand(
                    "INSERT INTO Test_Drive (Data, ID_Veiculo, ID_Usr_Criador, ID_Usr_Real, Cliente) " +
                    "VALUES (@Data, @ID_Veiculo, @ID_Usr_Criador, @ID_Usr_Real, @Cliente)", conn);

                comm.Parameters.Add("@Data", System.Data.SqlDbType.DateTime);
                comm.Parameters["@Data"].Value = dt_escolherData.Value;

                comm.Parameters.Add("@ID_Veiculo", System.Data.SqlDbType.Int);
                comm.Parameters["@ID_Veiculo"].Value = Codigo_Veiculo;

                comm.Parameters.Add("@ID_Usr_Criador", System.Data.SqlDbType.Int);
                comm.Parameters["@ID_Usr_Criador"].Value = Login.codigo_usuario;

                comm.Parameters.Add("@ID_Usr_Real", System.Data.SqlDbType.Int);
                comm.Parameters["@ID_Usr_Real"].Value = cb_Realizador.SelectedValue;

                comm.Parameters.Add("@Cliente", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@Cliente"].Value = tx_Cliente.Text;

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
                        MessageBox.Show("Test-Drive agendado com SUCESSO!!",
                            "Agendamento de Test-Drive!",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }
    }
}
