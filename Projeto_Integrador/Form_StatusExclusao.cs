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
    public partial class Form_StatusExclusao : Form
    {
        int Codigo = PesquisarVeiculos.Codigo;
        public Form_StatusExclusao()
        {
            InitializeComponent();
        }

        private void CadastrarStatus(string status)
        {
            bool bOk = true;


            SqlConnection conn;
            SqlCommand comm;

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

            conn = new SqlConnection(connectionString);


            comm = new SqlCommand("UPDATE Veiculos SET Status = @Status WHERE Codigo = @Codigo", conn);

            comm.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@Status"].Value = status;

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
                    MessageBox.Show("Veículo Excluído com SUCESSO!!",
                        "DELETE",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dispose();
                }
            }
        }

        private void btn_Troca_Click(object sender, EventArgs e)
        {
            CadastrarStatus("Troca");
        }

        private void btn_Repasse_Click(object sender, EventArgs e)
        {
            CadastrarStatus("Repasse");
        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            CadastrarStatus("Venda");
        }

        private void btn_Consignado_Click(object sender, EventArgs e)
        {
            CadastrarStatus("Consignado");
        }

        private void btn_Outro_Click(object sender, EventArgs e)
        {
            bool bOk = true;

            SqlConnection conn;
            SqlCommand comm;

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Projeto;Integrated Security=True";

            conn = new SqlConnection(connectionString);

            comm = new SqlCommand("DELETE FROM Veiculos WHERE Codigo = @Codigo", conn);

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
                    MessageBox.Show("Veículo Deletado com SUCESSO!!",
                        "DELETE",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dispose();

                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
