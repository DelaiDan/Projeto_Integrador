namespace Projeto_Integrador
{
    partial class Form_TestDrive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TestDrive));
            this.lb_dataEscolhida = new System.Windows.Forms.Label();
            this.dt_escolherData = new System.Windows.Forms.DateTimePicker();
            this.gb_Data = new System.Windows.Forms.GroupBox();
            this.lb_horaEscolhida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Texto1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txCondicao = new System.Windows.Forms.TextBox();
            this.txAno = new System.Windows.Forms.TextBox();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.txPreço = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.lbCondicaoVeiculo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Criador = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Realizador = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.projetoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.UsuariosTableAdapter();
            this.lb_Preview = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.gb_Cliente = new System.Windows.Forms.GroupBox();
            this.tx_Cliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btLimparAgendamento = new System.Windows.Forms.Button();
            this.gb_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetBindingSource)).BeginInit();
            this.gb_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_dataEscolhida
            // 
            this.lb_dataEscolhida.AutoSize = true;
            this.lb_dataEscolhida.Location = new System.Drawing.Point(76, 53);
            this.lb_dataEscolhida.Name = "lb_dataEscolhida";
            this.lb_dataEscolhida.Size = new System.Drawing.Size(99, 16);
            this.lb_dataEscolhida.TabIndex = 1;
            this.lb_dataEscolhida.Text = "Escolha a Data";
            // 
            // dt_escolherData
            // 
            this.dt_escolherData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_escolherData.Location = new System.Drawing.Point(6, 21);
            this.dt_escolherData.Name = "dt_escolherData";
            this.dt_escolherData.Size = new System.Drawing.Size(256, 22);
            this.dt_escolherData.TabIndex = 2;
            this.dt_escolherData.ValueChanged += new System.EventHandler(this.dt_escolherData_ValueChanged);
            // 
            // gb_Data
            // 
            this.gb_Data.Controls.Add(this.lb_horaEscolhida);
            this.gb_Data.Controls.Add(this.label2);
            this.gb_Data.Controls.Add(this.lb_Texto1);
            this.gb_Data.Controls.Add(this.dt_escolherData);
            this.gb_Data.Controls.Add(this.lb_dataEscolhida);
            this.gb_Data.Location = new System.Drawing.Point(701, 12);
            this.gb_Data.Name = "gb_Data";
            this.gb_Data.Size = new System.Drawing.Size(268, 107);
            this.gb_Data.TabIndex = 3;
            this.gb_Data.TabStop = false;
            this.gb_Data.Text = "Data e Hora";
            // 
            // lb_horaEscolhida
            // 
            this.lb_horaEscolhida.AutoSize = true;
            this.lb_horaEscolhida.Location = new System.Drawing.Point(76, 79);
            this.lb_horaEscolhida.Name = "lb_horaEscolhida";
            this.lb_horaEscolhida.Size = new System.Drawing.Size(100, 16);
            this.lb_horaEscolhida.TabIndex = 5;
            this.lb_horaEscolhida.Text = "Escolha a Hora\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // lb_Texto1
            // 
            this.lb_Texto1.AutoSize = true;
            this.lb_Texto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Texto1.Location = new System.Drawing.Point(6, 49);
            this.lb_Texto1.Name = "lb_Texto1";
            this.lb_Texto1.Size = new System.Drawing.Size(55, 20);
            this.lb_Texto1.TabIndex = 3;
            this.lb_Texto1.Text = "Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(641, 230);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.txCondicao);
            this.gbFiltros.Controls.Add(this.txAno);
            this.gbFiltros.Controls.Add(this.txMarca);
            this.gbFiltros.Controls.Add(this.txPreço);
            this.gbFiltros.Controls.Add(this.label4);
            this.gbFiltros.Controls.Add(this.txModelo);
            this.gbFiltros.Controls.Add(this.lbCondicaoVeiculo);
            this.gbFiltros.Controls.Add(this.label3);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Controls.Add(this.label5);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(10, 21);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(641, 120);
            this.gbFiltros.TabIndex = 4;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txCondicao
            // 
            this.txCondicao.Location = new System.Drawing.Point(416, 15);
            this.txCondicao.Name = "txCondicao";
            this.txCondicao.Size = new System.Drawing.Size(214, 22);
            this.txCondicao.TabIndex = 4;
            this.txCondicao.TextChanged += new System.EventHandler(this.txCondicao_TextChanged);
            // 
            // txAno
            // 
            this.txAno.Location = new System.Drawing.Point(79, 83);
            this.txAno.Name = "txAno";
            this.txAno.Size = new System.Drawing.Size(82, 22);
            this.txAno.TabIndex = 3;
            this.txAno.TextChanged += new System.EventHandler(this.txAno_TextChanged);
            // 
            // txMarca
            // 
            this.txMarca.Location = new System.Drawing.Point(79, 52);
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(214, 22);
            this.txMarca.TabIndex = 2;
            this.txMarca.TextChanged += new System.EventHandler(this.txMarca_TextChanged);
            // 
            // txPreço
            // 
            this.txPreço.Location = new System.Drawing.Point(416, 46);
            this.txPreço.Name = "txPreço";
            this.txPreço.Size = new System.Drawing.Size(214, 22);
            this.txPreço.TabIndex = 5;
            this.txPreço.TextChanged += new System.EventHandler(this.txPreço_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(327, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Preço: R$";
            // 
            // txModelo
            // 
            this.txModelo.Location = new System.Drawing.Point(79, 22);
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(214, 22);
            this.txModelo.TabIndex = 1;
            this.txModelo.TextChanged += new System.EventHandler(this.txModelo_TextChanged_1);
            // 
            // lbCondicaoVeiculo
            // 
            this.lbCondicaoVeiculo.AutoSize = true;
            this.lbCondicaoVeiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lbCondicaoVeiculo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCondicaoVeiculo.Location = new System.Drawing.Point(327, 18);
            this.lbCondicaoVeiculo.Name = "lbCondicaoVeiculo";
            this.lbCondicaoVeiculo.Size = new System.Drawing.Size(68, 16);
            this.lbCondicaoVeiculo.TabIndex = 3;
            this.lbCondicaoVeiculo.Text = "Condição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ano:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(7, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Criador);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_Realizador);
            this.groupBox1.Location = new System.Drawing.Point(702, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // lb_Criador
            // 
            this.lb_Criador.AutoSize = true;
            this.lb_Criador.Location = new System.Drawing.Point(6, 136);
            this.lb_Criador.Name = "lb_Criador";
            this.lb_Criador.Size = new System.Drawing.Size(0, 16);
            this.lb_Criador.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuário Criador:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Selecione o Usuário realizador:";
            // 
            // cb_Realizador
            // 
            this.cb_Realizador.DataSource = this.usuariosBindingSource;
            this.cb_Realizador.DisplayMember = "usuario";
            this.cb_Realizador.FormattingEnabled = true;
            this.cb_Realizador.Location = new System.Drawing.Point(6, 63);
            this.cb_Realizador.Name = "cb_Realizador";
            this.cb_Realizador.Size = new System.Drawing.Size(256, 24);
            this.cb_Realizador.TabIndex = 0;
            this.cb_Realizador.ValueMember = "id_usuario";
            this.cb_Realizador.SelectedIndexChanged += new System.EventHandler(this.cb_Realizador_SelectedIndexChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbFiltros);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 393);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veículo";
            // 
            // projetoDataSetBindingSource
            // 
            this.projetoDataSetBindingSource.DataSource = this.projetoDataSet;
            this.projetoDataSetBindingSource.Position = 0;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // lb_Preview
            // 
            this.lb_Preview.AutoSize = true;
            this.lb_Preview.Location = new System.Drawing.Point(19, 411);
            this.lb_Preview.Name = "lb_Preview";
            this.lb_Preview.Size = new System.Drawing.Size(0, 16);
            this.lb_Preview.TabIndex = 8;
            // 
            // btnAgendar
            // 
            this.btnAgendar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.Location = new System.Drawing.Point(871, 427);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(99, 46);
            this.btnAgendar.TabIndex = 9;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.tx_Cliente);
            this.gb_Cliente.Controls.Add(this.label8);
            this.gb_Cliente.Location = new System.Drawing.Point(701, 304);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(269, 101);
            this.gb_Cliente.TabIndex = 10;
            this.gb_Cliente.TabStop = false;
            this.gb_Cliente.Text = "Cliente";
            // 
            // tx_Cliente
            // 
            this.tx_Cliente.Location = new System.Drawing.Point(6, 63);
            this.tx_Cliente.Name = "tx_Cliente";
            this.tx_Cliente.Size = new System.Drawing.Size(257, 22);
            this.tx_Cliente.TabIndex = 5;
            this.tx_Cliente.TextChanged += new System.EventHandler(this.tx_Cliente_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Digite o Nome do Cliente:";
            // 
            // btLimparAgendamento
            // 
            this.btLimparAgendamento.BackColor = System.Drawing.Color.Tomato;
            this.btLimparAgendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparAgendamento.Location = new System.Drawing.Point(701, 427);
            this.btLimparAgendamento.Name = "btLimparAgendamento";
            this.btLimparAgendamento.Size = new System.Drawing.Size(95, 46);
            this.btLimparAgendamento.TabIndex = 11;
            this.btLimparAgendamento.Text = "Limpar";
            this.btLimparAgendamento.UseVisualStyleBackColor = false;
            this.btLimparAgendamento.Click += new System.EventHandler(this.btLimparAgendamento_Click);
            // 
            // Form_TestDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 485);
            this.Controls.Add(this.btLimparAgendamento);
            this.Controls.Add(this.gb_Cliente);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.lb_Preview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_TestDrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendar Test-Drive";
            this.Load += new System.EventHandler(this.Form_TestDrive_Load);
            this.gb_Data.ResumeLayout(false);
            this.gb_Data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSetBindingSource)).EndInit();
            this.gb_Cliente.ResumeLayout(false);
            this.gb_Cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_dataEscolhida;
        private System.Windows.Forms.DateTimePicker dt_escolherData;
        private System.Windows.Forms.GroupBox gb_Data;
        private System.Windows.Forms.Label lb_horaEscolhida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Texto1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.TextBox txCondicao;
        private System.Windows.Forms.TextBox txAno;
        private System.Windows.Forms.TextBox txMarca;
        private System.Windows.Forms.TextBox txPreço;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label lbCondicaoVeiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_Criador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Realizador;
        private System.Windows.Forms.BindingSource projetoDataSetBindingSource;
        private ProjetoDataSet projetoDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private ProjetoDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Label lb_Preview;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.GroupBox gb_Cliente;
        private System.Windows.Forms.TextBox tx_Cliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btLimparAgendamento;
    }
}