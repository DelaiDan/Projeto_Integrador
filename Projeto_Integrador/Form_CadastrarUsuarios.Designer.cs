
namespace Projeto_Integrador
{
    partial class Form_CadastrarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastrarUsuarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGerente = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.txConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txSobrenome = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCadastrarUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGerente);
            this.groupBox1.Controls.Add(this.rbVendedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rbAdministrador);
            this.groupBox1.Controls.Add(this.txConfirmaSenha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txSenha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txSobrenome);
            this.groupBox1.Controls.Add(this.txNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(268, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Informações";
            // 
            // rbGerente
            // 
            this.rbGerente.AutoSize = true;
            this.rbGerente.Location = new System.Drawing.Point(112, 203);
            this.rbGerente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbGerente.Name = "rbGerente";
            this.rbGerente.Size = new System.Drawing.Size(63, 17);
            this.rbGerente.TabIndex = 13;
            this.rbGerente.TabStop = true;
            this.rbGerente.Text = "Gerente";
            this.rbGerente.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Location = new System.Drawing.Point(112, 225);
            this.rbVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rbVendedor.TabIndex = 12;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo:";
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.AutoSize = true;
            this.rbAdministrador.Location = new System.Drawing.Point(112, 180);
            this.rbAdministrador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(88, 17);
            this.rbAdministrador.TabIndex = 10;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // txConfirmaSenha
            // 
            this.txConfirmaSenha.Location = new System.Drawing.Point(112, 145);
            this.txConfirmaSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txConfirmaSenha.MaxLength = 50;
            this.txConfirmaSenha.Name = "txConfirmaSenha";
            this.txConfirmaSenha.Size = new System.Drawing.Size(144, 20);
            this.txConfirmaSenha.TabIndex = 9;
            this.txConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirme sua senha:";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(112, 115);
            this.txSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txSenha.MaxLength = 50;
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(144, 20);
            this.txSenha.TabIndex = 7;
            this.txSenha.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // txUsuario
            // 
            this.txUsuario.Location = new System.Drawing.Point(112, 83);
            this.txUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txUsuario.MaxLength = 30;
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.Size = new System.Drawing.Size(144, 20);
            this.txUsuario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuário:";
            // 
            // txSobrenome
            // 
            this.txSobrenome.Location = new System.Drawing.Point(112, 48);
            this.txSobrenome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txSobrenome.MaxLength = 20;
            this.txSobrenome.Name = "txSobrenome";
            this.txSobrenome.Size = new System.Drawing.Size(144, 20);
            this.txSobrenome.TabIndex = 3;
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(112, 22);
            this.txNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNome.MaxLength = 20;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(144, 20);
            this.txNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btCadastrarUsuario
            // 
            this.btCadastrarUsuario.Location = new System.Drawing.Point(9, 266);
            this.btCadastrarUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrarUsuario.Name = "btCadastrarUsuario";
            this.btCadastrarUsuario.Size = new System.Drawing.Size(90, 36);
            this.btCadastrarUsuario.TabIndex = 1;
            this.btCadastrarUsuario.Text = "Cadastrar";
            this.btCadastrarUsuario.UseVisualStyleBackColor = true;
            this.btCadastrarUsuario.Click += new System.EventHandler(this.btCadastrarUsuario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 266);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_CadastrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 312);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCadastrarUsuario);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_CadastrarUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txConfirmaSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txSobrenome;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCadastrarUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbGerente;
    }
}