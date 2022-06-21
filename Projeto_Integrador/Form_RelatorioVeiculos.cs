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
    public partial class Form_RelatorioVeiculos : Form
    {
        public Form_RelatorioVeiculos()
        {
            InitializeComponent();
        }

        private void Form_RelatorioVeiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProjetoDataSet.Test_Drive' table. You can move, or remove it, as needed.
            this.test_DriveTableAdapter.Fill(this.ProjetoDataSet.Test_Drive);
            // TODO: This line of code loads data into the 'ProjetoDataSet1.Veiculos' table. You can move, or remove it, as needed.
            this.VeiculosTableAdapter.Fill(this.ProjetoDataSet.Veiculos);

            this.reportViewer1.RefreshReport();
        }
    }
}
