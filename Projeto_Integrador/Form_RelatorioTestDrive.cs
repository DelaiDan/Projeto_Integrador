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
    public partial class Form_RelatorioTestDrive : Form
    {
        public Form_RelatorioTestDrive()
        {
            InitializeComponent();
        }

        private void Form_RelatorioTestDrive_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetoDataSet.Test_Drive' table. You can move, or remove it, as needed.
            this.test_DriveTableAdapter.Fill(this.projetoDataSet.Test_Drive);

            this.reportViewer1.RefreshReport();

        }
    }
}
