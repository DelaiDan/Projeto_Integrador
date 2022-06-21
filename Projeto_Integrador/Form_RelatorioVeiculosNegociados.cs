using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador
{
    public partial class Form_RelatorioVeiculosNegociados : Form
    {
        public Form_RelatorioVeiculosNegociados()
        {
            InitializeComponent();
        }

        private void Form_RelatorioVeiculosNegociados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoDataSet.Rel_VeiculosNegociados' table. You can move, or remove it, as needed.
            this.rel_VeiculosNegociadosTableAdapter.Fill(this.projetoDataSet.Rel_VeiculosNegociados);

            this.reportViewer1.RefreshReport();
        }
    }
}
