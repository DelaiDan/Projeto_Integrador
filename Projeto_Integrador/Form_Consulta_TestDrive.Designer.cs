namespace Projeto_Integrador
{
    partial class Form_Consulta_TestDrive
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
            this.cb_Usuario_Real = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_Veiculo = new System.Windows.Forms.ComboBox();
            this.tx_Cliente = new System.Windows.Forms.TextBox();
            this.dt_escolherData1 = new System.Windows.Forms.DateTimePicker();
            this.veiculosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.VeiculosTableAdapter();
            this.usuariosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.UsuariosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt_escolherData2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Usuario_Real
            // 
            this.cb_Usuario_Real.DataSource = this.usuariosBindingSource;
            this.cb_Usuario_Real.DisplayMember = "usuario";
            this.cb_Usuario_Real.FormattingEnabled = true;
            this.cb_Usuario_Real.Location = new System.Drawing.Point(13, 13);
            this.cb_Usuario_Real.Name = "cb_Usuario_Real";
            this.cb_Usuario_Real.Size = new System.Drawing.Size(256, 24);
            this.cb_Usuario_Real.TabIndex = 0;
            this.cb_Usuario_Real.ValueMember = "id_usuario";
            this.cb_Usuario_Real.SelectedIndexChanged += new System.EventHandler(this.cb_Usuario_Real_SelectedIndexChanged);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.projetoDataSet;
            // 
            // projetoDataSet
            // 
            this.projetoDataSet.DataSetName = "ProjetoDataSet";
            this.projetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculosBindingSource
            // 
            this.veiculosBindingSource.DataMember = "Veiculos";
            this.veiculosBindingSource.DataSource = this.projetoDataSet;
            // 
            // cb_Veiculo
            // 
            this.cb_Veiculo.DataSource = this.veiculosBindingSource;
            this.cb_Veiculo.DisplayMember = "Modelo";
            this.cb_Veiculo.FormattingEnabled = true;
            this.cb_Veiculo.Location = new System.Drawing.Point(292, 13);
            this.cb_Veiculo.Name = "cb_Veiculo";
            this.cb_Veiculo.Size = new System.Drawing.Size(256, 24);
            this.cb_Veiculo.TabIndex = 1;
            this.cb_Veiculo.ValueMember = "Modelo";
            this.cb_Veiculo.SelectedIndexChanged += new System.EventHandler(this.cb_Veiculo_SelectedIndexChanged);
            // 
            // tx_Cliente
            // 
            this.tx_Cliente.Location = new System.Drawing.Point(12, 71);
            this.tx_Cliente.Name = "tx_Cliente";
            this.tx_Cliente.Size = new System.Drawing.Size(256, 22);
            this.tx_Cliente.TabIndex = 3;
            this.tx_Cliente.TextChanged += new System.EventHandler(this.tx_Cliente_TextChanged);
            // 
            // dt_escolherData1
            // 
            this.dt_escolherData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_escolherData1.Location = new System.Drawing.Point(12, 43);
            this.dt_escolherData1.Name = "dt_escolherData1";
            this.dt_escolherData1.Size = new System.Drawing.Size(256, 22);
            this.dt_escolherData1.TabIndex = 4;
            this.dt_escolherData1.ValueChanged += new System.EventHandler(this.dt_escolherData1_ValueChanged);
            // 
            // veiculosTableAdapter
            // 
            this.veiculosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 275);
            this.dataGridView1.TabIndex = 6;
            // 
            // dt_escolherData2
            // 
            this.dt_escolherData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_escolherData2.Location = new System.Drawing.Point(292, 43);
            this.dt_escolherData2.Name = "dt_escolherData2";
            this.dt_escolherData2.Size = new System.Drawing.Size(256, 22);
            this.dt_escolherData2.TabIndex = 7;
            this.dt_escolherData2.ValueChanged += new System.EventHandler(this.dt_escolherData2_ValueChanged);
            // 
            // Form_Consulta_TestDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_escolherData2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dt_escolherData1);
            this.Controls.Add(this.tx_Cliente);
            this.Controls.Add(this.cb_Veiculo);
            this.Controls.Add(this.cb_Usuario_Real);
            this.Name = "Form_Consulta_TestDrive";
            this.Text = "Form_Consulta_TestDrive";
            this.Load += new System.EventHandler(this.Form_Consulta_TestDrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Usuario_Real;
        private System.Windows.Forms.ComboBox cb_Veiculo;
        private System.Windows.Forms.TextBox tx_Cliente;
        private System.Windows.Forms.DateTimePicker dt_escolherData1;
        private ProjetoDataSet projetoDataSet;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private ProjetoDataSetTableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ProjetoDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dt_escolherData2;
    }
}