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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            lb_usuario.Text = "Bem Vindo! " + Login.nome_usuario + " (" + Login.tipo + ")";

        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Login.tipo == "Administrador" || Login.tipo == "Gerente")
            {
                Form_CadastrarVeiculos frmCadastrarVeiculos = new Form_CadastrarVeiculos();

                frmCadastrarVeiculos.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar este recurso.");
            }
        }


        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Login.tipo == "Administrador")
            {
                Form_CadastrarUsuarios frmCadastrarUsuarios = new Form_CadastrarUsuarios();

                frmCadastrarUsuarios.ShowDialog(this);
            }
            else if (Login.tipo == "Gerente")
            {
                    Form_CadastrarUsuarios_Gerente frmCadastrarUsuariosGerente = new Form_CadastrarUsuarios_Gerente();

                    frmCadastrarUsuariosGerente.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar este recurso.");
            }

        }

        private void stripPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarVeiculos frmVeiculos = new PesquisarVeiculos();

            frmVeiculos.ShowDialog(this);
        }
        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TestDrive testDrive = new Form_TestDrive();

            testDrive.ShowDialog(this);
        }

        private void buscaDeVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_RelatorioVeiculos frmRelatorioVeiculos = new Form_RelatorioVeiculos();

            frmRelatorioVeiculos.ShowDialog(this);
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(Login.tipo == "Administrador")
            {
                Form_RelatórioUsuarios frmRelatorioUsuarios = new Form_RelatórioUsuarios();

                frmRelatorioUsuarios.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Você não possui permissão para acessar este recurso.");
            }

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Restart();

        }

    }
}
