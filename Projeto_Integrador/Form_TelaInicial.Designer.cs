
namespace Projeto_Integrador
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripPesquisar = new System.Windows.Forms.ToolStripMenuItem();
            this.concessionáriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarTestDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAgendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaDeVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.veículosNegociadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "CAVALO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(477, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "OPACO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(477, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 9);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gestão de Veículos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripPesquisar,
            this.concessionáriasToolStripMenuItem,
            this.agendarTestDriveToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripPesquisar
            // 
            this.stripPesquisar.Name = "stripPesquisar";
            this.stripPesquisar.Size = new System.Drawing.Size(115, 20);
            this.stripPesquisar.Text = "Pesquisar Veículos";
            this.stripPesquisar.Click += new System.EventHandler(this.stripPesquisar_Click);
            // 
            // concessionáriasToolStripMenuItem
            // 
            this.concessionáriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.concessionáriasToolStripMenuItem.Name = "concessionáriasToolStripMenuItem";
            this.concessionáriasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.concessionáriasToolStripMenuItem.Text = "Cadastrar";
            // 
            // veículosToolStripMenuItem
            // 
            this.veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
            this.veículosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.veículosToolStripMenuItem.Text = "Veículos";
            this.veículosToolStripMenuItem.Click += new System.EventHandler(this.veículosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // agendarTestDriveToolStripMenuItem
            // 
            this.agendarTestDriveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem,
            this.consultarAgendamentosToolStripMenuItem});
            this.agendarTestDriveToolStripMenuItem.Name = "agendarTestDriveToolStripMenuItem";
            this.agendarTestDriveToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.agendarTestDriveToolStripMenuItem.Text = "Test-Drive";
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.agendarToolStripMenuItem.Text = "Agendar";
            this.agendarToolStripMenuItem.Click += new System.EventHandler(this.agendarToolStripMenuItem_Click);
            // 
            // consultarAgendamentosToolStripMenuItem
            // 
            this.consultarAgendamentosToolStripMenuItem.Name = "consultarAgendamentosToolStripMenuItem";
            this.consultarAgendamentosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.consultarAgendamentosToolStripMenuItem.Text = "Consultar Agendamentos";
            this.consultarAgendamentosToolStripMenuItem.Click += new System.EventHandler(this.consultarAgendamentosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscaDeVeículosToolStripMenuItem,
            this.veículosNegociadosToolStripMenuItem,
            this.usuáriosToolStripMenuItem1,
            this.testDriveToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // buscaDeVeículosToolStripMenuItem
            // 
            this.buscaDeVeículosToolStripMenuItem.Name = "buscaDeVeículosToolStripMenuItem";
            this.buscaDeVeículosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscaDeVeículosToolStripMenuItem.Text = "Veículos";
            this.buscaDeVeículosToolStripMenuItem.Click += new System.EventHandler(this.buscaDeVeículosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem1
            // 
            this.usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            this.usuáriosToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.usuáriosToolStripMenuItem1.Text = "Usuários";
            this.usuáriosToolStripMenuItem1.Click += new System.EventHandler(this.usuáriosToolStripMenuItem1_Click);
            // 
            // testDriveToolStripMenuItem
            // 
            this.testDriveToolStripMenuItem.Name = "testDriveToolStripMenuItem";
            this.testDriveToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.testDriveToolStripMenuItem.Text = "Test-Drive";
            this.testDriveToolStripMenuItem.Click += new System.EventHandler(this.testDriveToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 47);
            this.label4.TabIndex = 11;
            this.label4.Text = "C";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(430, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 47);
            this.label5.TabIndex = 13;
            this.label5.Text = "O";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_usuario.Location = new System.Drawing.Point(756, 9);
            this.lb_usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(35, 13);
            this.lb_usuario.TabIndex = 15;
            this.lb_usuario.Text = "label6";
            // 
            // veículosNegociadosToolStripMenuItem
            // 
            this.veículosNegociadosToolStripMenuItem.Name = "veículosNegociadosToolStripMenuItem";
            this.veículosNegociadosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.veículosNegociadosToolStripMenuItem.Text = "Veículos Negociados";
            this.veículosNegociadosToolStripMenuItem.Click += new System.EventHandler(this.veículosNegociadosToolStripMenuItem_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cavalo Opaco";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripPesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem concessionáriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaDeVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.ToolStripMenuItem agendarTestDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAgendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosNegociadosToolStripMenuItem;
    }
}

