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
    public partial class Form_CadastrarUsuarios_Gerente : Form
    {
        Form_CadastrarUsuarios validar = new Form_CadastrarUsuarios();
        public Form_CadastrarUsuarios_Gerente()
        {
            InitializeComponent();
        }

        private void btCadastrarUsuario_Click_1(object sender, EventArgs e)
        {
            validar.TipoDeUsuario();
            validar.CadastrarUsuario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            validar.LimpaCampos();
        }
    }
}
