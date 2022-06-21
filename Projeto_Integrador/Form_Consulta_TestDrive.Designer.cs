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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Consulta_TestDrive));
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.veiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.VeiculosTableAdapter();
            this.usuariosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.UsuariosTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_FiltrosConsultaTD = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_escolherData2 = new System.Windows.Forms.DateTimePicker();
            this.dt_escolherData1 = new System.Windows.Forms.DateTimePicker();
            this.tx_Cliente = new System.Windows.Forms.TextBox();
            this.cb_Veiculo = new System.Windows.Forms.ComboBox();
            this.cb_Usuario_Real = new System.Windows.Forms.ComboBox();
            this.btDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_FiltrosConsultaTD.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 329);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gb_FiltrosConsultaTD
            // 
            this.gb_FiltrosConsultaTD.Controls.Add(this.btDeletar);
            this.gb_FiltrosConsultaTD.Controls.Add(this.label1);
            this.gb_FiltrosConsultaTD.Controls.Add(this.label3);
            this.gb_FiltrosConsultaTD.Controls.Add(this.label4);
            this.gb_FiltrosConsultaTD.Controls.Add(this.label2);
            this.gb_FiltrosConsultaTD.Controls.Add(this.label5);
            this.gb_FiltrosConsultaTD.Controls.Add(this.tx_Cliente);
            this.gb_FiltrosConsultaTD.Controls.Add(this.dt_escolherData1);
            this.gb_FiltrosConsultaTD.Controls.Add(this.cb_Veiculo);
            this.gb_FiltrosConsultaTD.Controls.Add(this.dt_escolherData2);
            this.gb_FiltrosConsultaTD.Controls.Add(this.cb_Usuario_Real);
            this.gb_FiltrosConsultaTD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gb_FiltrosConsultaTD.Location = new System.Drawing.Point(16, 11);
            this.gb_FiltrosConsultaTD.Margin = new System.Windows.Forms.Padding(4);
            this.gb_FiltrosConsultaTD.Name = "gb_FiltrosConsultaTD";
            this.gb_FiltrosConsultaTD.Padding = new System.Windows.Forms.Padding(4);
            this.gb_FiltrosConsultaTD.Size = new System.Drawing.Size(768, 91);
            this.gb_FiltrosConsultaTD.TabIndex = 13;
            this.gb_FiltrosConsultaTD.TabStop = false;
            this.gb_FiltrosConsultaTD.Text = "Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(199, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "até";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(1, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(1, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Realizador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(362, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(360, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Modelo:";
            // 
            // dt_escolherData2
            // 
            this.dt_escolherData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dt_escolherData2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_escolherData2.Location = new System.Drawing.Point(240, 51);
            this.dt_escolherData2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_escolherData2.Name = "dt_escolherData2";
            this.dt_escolherData2.Size = new System.Drawing.Size(104, 23);
            this.dt_escolherData2.TabIndex = 17;
            this.dt_escolherData2.ValueChanged += new System.EventHandler(this.dt_escolherData2_ValueChanged);
            // 
            // dt_escolherData1
            // 
            this.dt_escolherData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dt_escolherData1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_escolherData1.Location = new System.Drawing.Point(88, 51);
            this.dt_escolherData1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_escolherData1.Name = "dt_escolherData1";
            this.dt_escolherData1.Size = new System.Drawing.Size(104, 23);
            this.dt_escolherData1.TabIndex = 16;
            this.dt_escolherData1.ValueChanged += new System.EventHandler(this.dt_escolherData1_ValueChanged);
            // 
            // tx_Cliente
            // 
            this.tx_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tx_Cliente.Location = new System.Drawing.Point(426, 51);
            this.tx_Cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tx_Cliente.Name = "tx_Cliente";
            this.tx_Cliente.Size = new System.Drawing.Size(184, 23);
            this.tx_Cliente.TabIndex = 15;
            this.tx_Cliente.TextChanged += new System.EventHandler(this.tx_Cliente_TextChanged);
            // 
            // cb_Veiculo
            // 
            this.cb_Veiculo.DataSource = this.veiculosBindingSource;
            this.cb_Veiculo.DisplayMember = "Modelo";
            this.cb_Veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Veiculo.FormattingEnabled = true;
            this.cb_Veiculo.Location = new System.Drawing.Point(426, 17);
            this.cb_Veiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Veiculo.Name = "cb_Veiculo";
            this.cb_Veiculo.Size = new System.Drawing.Size(184, 25);
            this.cb_Veiculo.TabIndex = 14;
            this.cb_Veiculo.ValueMember = "Modelo";
            this.cb_Veiculo.SelectedIndexChanged += new System.EventHandler(this.cb_Veiculo_SelectedIndexChanged);
            // 
            // cb_Usuario_Real
            // 
            this.cb_Usuario_Real.DataSource = this.usuariosBindingSource;
            this.cb_Usuario_Real.DisplayMember = "usuario";
            this.cb_Usuario_Real.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Usuario_Real.FormattingEnabled = true;
            this.cb_Usuario_Real.Location = new System.Drawing.Point(88, 17);
            this.cb_Usuario_Real.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Usuario_Real.Name = "cb_Usuario_Real";
            this.cb_Usuario_Real.Size = new System.Drawing.Size(256, 25);
            this.cb_Usuario_Real.TabIndex = 13;
            this.cb_Usuario_Real.ValueMember = "id_usuario";
            this.cb_Usuario_Real.SelectedIndexChanged += new System.EventHandler(this.cb_Usuario_Real_SelectedIndexChanged);
            // 
            // btDeletar
            // 
            this.btDeletar.BackColor = System.Drawing.Color.Tomato;
            this.btDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(653, 31);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(108, 41);
            this.btDeletar.TabIndex = 23;
            this.btDeletar.Text = "Excluir";
            this.btDeletar.UseVisualStyleBackColor = false;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // Form_Consulta_TestDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_FiltrosConsultaTD);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form_Consulta_TestDrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Agendamentos de Test Drive";
            this.Load += new System.EventHandler(this.Form_Consulta_TestDrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_FiltrosConsultaTD.ResumeLayout(false);
            this.gb_FiltrosConsultaTD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjetoDataSet projetoDataSet;
        private System.Windows.Forms.BindingSource veiculosBindingSource;
        private ProjetoDataSetTableAdapters.VeiculosTableAdapter veiculosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ProjetoDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_FiltrosConsultaTD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Veiculo;
        private System.Windows.Forms.ComboBox cb_Usuario_Real;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_escolherData2;
        private System.Windows.Forms.DateTimePicker dt_escolherData1;
        private System.Windows.Forms.TextBox tx_Cliente;
        private System.Windows.Forms.Button btDeletar;
    }
}