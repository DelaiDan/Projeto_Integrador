
namespace Projeto_Integrador
{
    partial class Form_RelatórioUsuarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RelatórioUsuarios));
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsuariosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataMember = "Usuarios";
            this.UsuariosBindingSource.DataSource = this.ProjetoDataSet;
            // 
            // ProjetoDataSet
            // 
            this.ProjetoDataSet.DataSetName = "ProjetoDataSet";
            this.ProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsuarios";
            reportDataSource1.Value = this.UsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Integrador.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(842, 545);
            this.reportViewer1.TabIndex = 0;
            // 
            // UsuariosTableAdapter
            // 
            this.UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RelatórioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 545);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_RelatórioUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Usuários";
            this.Load += new System.EventHandler(this.Form_RelatórioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private ProjetoDataSet ProjetoDataSet;
        private ProjetoDataSetTableAdapters.UsuariosTableAdapter UsuariosTableAdapter;
    }
}