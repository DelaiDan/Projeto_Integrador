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
    public partial class Form_Consulta_TestDrive : Form
    {

        SqlConnection conn;
        SqlCommand comm;

        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";
        private string strSql = string.Empty;
        private string strSql2 = string.Empty;

        SqlDataReader reader;
        SqlDataAdapter adapt;
        DataTable dt;

        private int Codigo = 0;

        public Form_Consulta_TestDrive()
        {
            InitializeComponent();
            dt_escolherData1.CustomFormat = "dd/MM/yy";
            dt_escolherData2.CustomFormat = "dd/MM/yy";
        }

        private void Form_Consulta_TestDrive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.projetoDataSet.Usuarios);
            this.veiculosTableAdapter.Fill(this.projetoDataSet.Veiculos);
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT  TD.ID_TestDrive, " +
                                        "TD.Data, " +
                                        "U.nome, " +
                                        "U.usuario, " +
                                        "V.Marca, " +
                                        "V.Modelo, " +
                                        "V.Ano, " +
                                        "TD.ID_Veiculo, " +
                                        "TD.Cliente " +
                                "FROM Test_Drive TD " +
                                "LEFT JOIN Veiculos AS V ON V.Codigo = TD.ID_Veiculo " +
                                "LEFT JOIN Usuarios AS U ON U.id_usuario = TD.ID_Usr_Real ", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void cb_Usuario_Real_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT  TD.ID_TestDrive, " +
                                        "TD.Data, " +
                                        "U.nome, " +
                                        "U.usuario, " +
                                        "V.Marca, " +
                                        "V.Modelo, " +
                                        "V.Ano, " +
                                        "TD.ID_Veiculo, " +
                                        "TD.Cliente " +
                                "FROM Test_Drive TD " +
                                "LEFT JOIN Veiculos AS V ON V.Codigo = TD.ID_Veiculo " +
                                "LEFT JOIN Usuarios AS U ON U.id_usuario = TD.ID_Usr_Real " +
                                "WHERE TD.ID_Usr_Real LIKE '" + cb_Usuario_Real.SelectedValue + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void cb_Veiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT  TD.ID_TestDrive, " +
                                        "TD.Data, " +
                                        "U.nome, " +
                                        "U.usuario, " +
                                        "V.Marca, " +
                                        "V.Modelo, " +
                                        "V.Ano, " +
                                        "TD.ID_Veiculo, " +
                                        "TD.Cliente " +
                                "FROM Test_Drive TD " +
                                "LEFT JOIN Veiculos AS V ON V.Codigo = TD.ID_Veiculo " +
                                "LEFT JOIN Usuarios AS U ON U.id_usuario = TD.ID_Usr_Real " +
                                "WHERE V.Modelo LIKE '" + cb_Veiculo.SelectedValue + "%'", conn);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dt_escolherData1_ValueChanged(object sender, EventArgs e)
        {
            Datas_Between();
        }

        private void dt_escolherData2_ValueChanged(object sender, EventArgs e)
        {
            Datas_Between();
        }

        private void Datas_Between()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT  TD.ID_TestDrive, " +
                                        "TD.Data, " +
                                        "U.nome, " +
                                        "U.usuario, " +
                                        "V.Marca, " +
                                        "V.Modelo, " +
                                        "V.Ano, " +
                                        "TD.ID_Veiculo, " +
                                        "TD.Cliente " +
                                "FROM Test_Drive TD " +
                                "LEFT JOIN Veiculos AS V ON V.Codigo = TD.ID_Veiculo " +
                                "LEFT JOIN Usuarios AS U ON U.id_usuario = TD.ID_Usr_Real " +
                                "WHERE TD.Data BETWEEN '" + dt_escolherData1.Value.ToString("yyyyMMdd HH:mm:ss") + "' AND '" + dt_escolherData2.Value.ToString("yyyyMMdd HH:mm:ss") + "'", conn);

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void tx_Cliente_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT  TD.ID_TestDrive, " +
                                        "TD.Data, " +
                                        "U.nome, " +
                                        "U.usuario, " +
                                        "V.Marca, " +
                                        "V.Modelo, " +
                                        "V.Ano, " +
                                        "TD.ID_Veiculo, " +
                                        "TD.Cliente " +
                                "FROM Test_Drive TD " +
                                "LEFT JOIN Veiculos AS V ON V.Codigo = TD.ID_Veiculo " +
                                "LEFT JOIN Usuarios AS U ON U.id_usuario = TD.ID_Usr_Real " +
                                "WHERE TD.Cliente LIKE '" + tx_Cliente.Text + "%'", conn);

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string CodigoStr = row.Cells["ID_TestDrive"].Value.ToString();
            Codigo = Convert.ToInt32(CodigoStr);
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja EXCLUIR este registro?",
            "CONFIRMAR!",
            MessageBoxButtons.YesNo, MessageBoxIcon.Error);

            if (res == DialogResult.Yes)
            {
                if (Codigo != 0)
                {
                    bool bOk = true;

                    SqlConnection conn;
                    SqlCommand comm;

                    string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

                    conn = new SqlConnection(connectionString);

                    comm = new SqlCommand("DELETE FROM Test_Drive WHERE ID_TestDrive = @Codigo", conn);

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
                            MessageBox.Show("Test-Drive Deletado com SUCESSO!!",
                                "DELETE",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Dispose();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um ID válido.",
                        "ERRO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
