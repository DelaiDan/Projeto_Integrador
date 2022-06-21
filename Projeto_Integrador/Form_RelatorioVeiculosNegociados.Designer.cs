namespace Projeto_Integrador
{
    partial class Form_RelatorioVeiculosNegociados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RelatorioVeiculosNegociados));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.projetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.relVeiculosNegociadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rel_VeiculosNegociadosTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.Rel_VeiculosNegociadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relVeiculosNegociadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelVeiculosNeg";
            reportDataSource1.Value = this.relVeiculosNegociadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Integrador.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(944, 546);
            this.reportViewer1.TabIndex = 0;
            // 
            // projetoDataSet
            // 
            this.projetoDataSet.DataSetName = "ProjetoDataSet";
            this.projetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relVeiculosNegociadosBindingSource
            // 
            this.relVeiculosNegociadosBindingSource.DataMember = "Rel_VeiculosNegociados";
            this.relVeiculosNegociadosBindingSource.DataSource = this.projetoDataSet;
            // 
            // rel_VeiculosNegociadosTableAdapter
            // 
            this.rel_VeiculosNegociadosTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RelatorioVeiculosNegociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 546);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_RelatorioVeiculosNegociados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Veículos Negociados";
            this.Load += new System.EventHandler(this.Form_RelatorioVeiculosNegociados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relVeiculosNegociadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProjetoDataSet projetoDataSet;
        private System.Windows.Forms.BindingSource relVeiculosNegociadosBindingSource;
        private ProjetoDataSetTableAdapters.Rel_VeiculosNegociadosTableAdapter rel_VeiculosNegociadosTableAdapter;
    }
}