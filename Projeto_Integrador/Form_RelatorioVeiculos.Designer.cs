
namespace Projeto_Integrador
{
    partial class Form_RelatorioVeiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RelatorioVeiculos));
            this.VeiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProjetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeiculosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.VeiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VeiculosBindingSource
            // 
            this.VeiculosBindingSource.DataMember = "Veiculos";
            this.VeiculosBindingSource.DataSource = this.ProjetoDataSet;
            // 
            // ProjetoDataSet
            // 
            this.ProjetoDataSet.DataSetName = "ProjetoDataSet";
            this.ProjetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVeiculos";
            reportDataSource1.Value = this.VeiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Integrador.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(842, 545);
            this.reportViewer1.TabIndex = 0;
            // 
            // VeiculosTableAdapter
            // 
            this.VeiculosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 545);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form_RelatorioVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório De Veículos";
            this.Load += new System.EventHandler(this.Form_RelatorioVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VeiculosBindingSource;
        private ProjetoDataSet ProjetoDataSet;
        private ProjetoDataSetTableAdapters.VeiculosTableAdapter VeiculosTableAdapter;
    }
}