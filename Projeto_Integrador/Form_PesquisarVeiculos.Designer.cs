
namespace Projeto_Integrador
{
    partial class PesquisarVeiculos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarVeiculos));
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txEstado = new System.Windows.Forms.TextBox();
            this.txAno = new System.Windows.Forms.TextBox();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.txPreço = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.lbEstadoVeiculo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.projetoDataSet1 = new Projeto_Integrador.ProjetoDataSet1();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veiculosTableAdapter = new Projeto_Integrador.ProjetoDataSet1TableAdapters.VeiculosTableAdapter();
            this.veiculosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veiculosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.veiculosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.txEstado);
            this.gbFiltros.Controls.Add(this.txAno);
            this.gbFiltros.Controls.Add(this.txMarca);
            this.gbFiltros.Controls.Add(this.txPreço);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.txModelo);
            this.gbFiltros.Controls.Add(this.lbEstadoVeiculo);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label2);
            this.gbFiltros.Controls.Add(this.label1);
            resources.ApplyResources(this.gbFiltros, "gbFiltros");
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.TabStop = false;
            // 
            // txEstado
            // 
            resources.ApplyResources(this.txEstado, "txEstado");
            this.txEstado.Name = "txEstado";
            this.txEstado.TextChanged += new System.EventHandler(this.txEstado_TextChanged);
            // 
            // txAno
            // 
            resources.ApplyResources(this.txAno, "txAno");
            this.txAno.Name = "txAno";
            this.txAno.TextChanged += new System.EventHandler(this.txAno_TextChanged);
            // 
            // txMarca
            // 
            resources.ApplyResources(this.txMarca, "txMarca");
            this.txMarca.Name = "txMarca";
            this.txMarca.TextChanged += new System.EventHandler(this.txMarca_TextChanged);
            // 
            // txPreço
            // 
            resources.ApplyResources(this.txPreço, "txPreço");
            this.txPreço.Name = "txPreço";
            this.txPreço.TextChanged += new System.EventHandler(this.txPreço_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txModelo
            // 
            resources.ApplyResources(this.txModelo, "txModelo");
            this.txModelo.Name = "txModelo";
            this.txModelo.TextChanged += new System.EventHandler(this.txModelo_TextChanged_1);
            // 
            // lbEstadoVeiculo
            // 
            resources.ApplyResources(this.lbEstadoVeiculo, "lbEstadoVeiculo");
            this.lbEstadoVeiculo.Name = "lbEstadoVeiculo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // projetoDataSet1
            // 
            this.projetoDataSet1.DataSetName = "ProjetoDataSet1";
            this.projetoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataMember = "Veiculos";
            this.veiculosBindingSource.DataSource = this.projetoDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // veiculosTableAdapter
            // 
            this.veiculosTableAdapter.ClearBeforeFill = true;
            // 
            // veiculosBindingSource1
            // 
            this.veiculosBindingSource1.DataMember = "Veiculos";
            this.veiculosBindingSource1.DataSource = this.projetoDataSet1;
            // 
            // veiculosBindingSource2
            // 
            this.veiculosBindingSource2.DataMember = "Veiculos";
            this.veiculosBindingSource2.DataSource = this.projetoDataSet1;
            // 
            // veiculosBindingSource3
            // 
            this.veiculosBindingSource3.DataMember = "Veiculos";
            this.veiculosBindingSource3.DataSource = this.projetoDataSet1;
            // 
            // PesquisarVeiculos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PesquisarVeiculos";
            this.Load += new System.EventHandler(this.PesquisarVeiculos_Load);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label lbEstadoVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txPreço;
        private System.Windows.Forms.Label label4;
        private ProjetoDataSet1TableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private ProjetoDataSet1 projetoDataSet1;
        private System.Windows.Forms.BindingSource veiculosBindingSource3;
        private System.Windows.Forms.BindingSource veiculosBindingSource2;
        private System.Windows.Forms.BindingSource veiculosBindingSource1;
        private System.Windows.Forms.TextBox txEstado;
        private System.Windows.Forms.TextBox txAno;
        private System.Windows.Forms.TextBox txMarca;
    }
}