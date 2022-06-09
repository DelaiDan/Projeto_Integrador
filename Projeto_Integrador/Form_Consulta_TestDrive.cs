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

        public Form_Consulta_TestDrive()
        {
            InitializeComponent();
            dt_escolherData1.CustomFormat = "dd/MM/yy -- HH:mm";
            dt_escolherData2.CustomFormat = "dd/MM/yy -- HH:mm";
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
    }
}
