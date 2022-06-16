namespace Projeto_Integrador
{
    partial class Form_RelatorioTestDrive
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
            this.projetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.test_DriveTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.Test_DriveTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rel_TestDriveTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.Rel_TestDriveTableAdapter();
            this.relTestDriveBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relTestDriveBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // projetoDataSet
            // 
            this.projetoDataSet.DataSetName = "ProjetoDataSet";
            this.projetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_DriveTableAdapter
            // 
            this.test_DriveTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelTestDrive";
            reportDataSource1.Value = this.relTestDriveBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Integrador.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "Projeto_Integrador.Report3";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("localhost\\SQLEXPRESS", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(806, 539);
            this.reportViewer1.TabIndex = 1;
            // 
            // rel_TestDriveTableAdapter
            // 
            this.rel_TestDriveTableAdapter.ClearBeforeFill = true;
            // 
            // relTestDriveBindingSource2
            // 
            this.relTestDriveBindingSource2.DataMember = "Rel_TestDrive";
            this.relTestDriveBindingSource2.DataSource = this.projetoDataSet;
            // 
            // Form_RelatorioTestDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 539);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_RelatorioTestDrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio De Test-Drives";
            this.Load += new System.EventHandler(this.Form_RelatorioTestDrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relTestDriveBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjetoDataSet projetoDataSet;
        private ProjetoDataSetTableAdapters.Test_DriveTableAdapter test_DriveTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProjetoDataSetTableAdapters.Rel_TestDriveTableAdapter rel_TestDriveTableAdapter;
        private System.Windows.Forms.BindingSource relTestDriveBindingSource2;
    }
}