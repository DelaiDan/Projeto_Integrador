
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
            this.ProjetoDataSet1 = new Projeto_Integrador.ProjetoDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VeiculosTableAdapter = new Projeto_Integrador.ProjetoDataSet1TableAdapters.VeiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // VeiculosBindingSource
            // 
            this.VeiculosBindingSource.DataMember = "Veiculos";
            this.VeiculosBindingSource.DataSource = this.ProjetoDataSet1;
            // 
            // ProjetoDataSet1
            // 
            this.ProjetoDataSet1.DataSetName = "ProjetoDataSet1";
            this.ProjetoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetVeiculos";
            reportDataSource1.Value = this.VeiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Integrador.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 6);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1099, 653);
            this.reportViewer1.TabIndex = 0;
            // 
            // VeiculosTableAdapter
            // 
            this.VeiculosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RelatorioVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 671);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_RelatorioVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório De Veículos";
            this.Load += new System.EventHandler(this.Form_RelatorioVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjetoDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VeiculosBindingSource;
        private ProjetoDataSet1 ProjetoDataSet1;
        private ProjetoDataSet1TableAdapters.VeiculosTableAdapter VeiculosTableAdapter;
    }
}