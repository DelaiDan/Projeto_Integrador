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
    public partial class Form_RelatórioUsuarios : Form
    {
        public Form_RelatórioUsuarios()
        {
            InitializeComponent();
        }

        private void Form_RelatórioUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProjetoDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.UsuariosTableAdapter.Fill(this.ProjetoDataSet.Usuarios);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
