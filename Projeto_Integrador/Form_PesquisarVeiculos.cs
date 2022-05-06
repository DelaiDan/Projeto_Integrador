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
    public partial class PesquisarVeiculos : Form
    {
 
        public static int Codigo;

        SqlConnection conn;
        SqlCommand comm;

        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";
        private string strSql = string.Empty;
        private string strSql2 = string.Empty;

        SqlDataReader reader;
        SqlDataAdapter adapt;
        DataTable dt;


        public PesquisarVeiculos()
        {
            InitializeComponent();
        }

        private void PesquisarVeiculos_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT Marca, Modelo, Ano, Estado, Cambio, Potencia, Consumo, Combustivel, Preço, Codigo " +
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

        private void txEstado_TextChanged(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            adapt = new SqlDataAdapter("SELECT * FROM Veiculos WHERE Estado LIKE '" + txEstado.Text + "%'", conn);
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
            Codigo = Convert.ToInt32(CodigoStr);

            Form_Veiculo frmVeiculo = new Form_Veiculo();

            frmVeiculo.ShowDialog(this);
        }
    }
}
