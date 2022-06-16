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
            this.Test_DriveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoDataSet = new Projeto_Integrador.ProjetoDataSet();
            this.testDriveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_DriveTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.Test_DriveTableAdapter();
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Rel_TestDriveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relTestDriveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rel_TestDriveTableAdapter = new Projeto_Integrador.ProjetoDataSetTableAdapters.Rel_TestDriveTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Test_DriveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDriveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_TestDriveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relTestDriveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Test_DriveBindingSource
            // 
            this.Test_DriveBindingSource.DataMember = "Test_Drive";
            this.Test_DriveBindingSource.DataSource = this.projetoDataSet;
            // 
            // projetoDataSet
            // 
            this.projetoDataSet.DataSetName = "ProjetoDataSet";
            this.projetoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDriveBindingSource
            // 
            this.testDriveBindingSource.DataMember = "Test_Drive";
            this.testDriveBindingSource.DataSource = this.projetoDataSet;
            // 
            // test_DriveTableAdapter
            // 
            this.test_DriveTableAdapter.ClearBeforeFill = true;
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataMember = "Usuarios";
            this.UsuariosBindingSource.DataSource = this.projetoDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RelTestDrive";
            reportDataSource1.Value = this.relTestDriveBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projeto_Integrador.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ServerReport.ReportPath = "Projeto_Integrador.Report3";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("localhost\\SQLEXPRESS", System.UriKind.Relative);
            this.reportViewer1.Size = new System.Drawing.Size(1123, 671);
            this.reportViewer1.TabIndex = 1;
            // 
            // Rel_TestDriveBindingSource
            // 
            this.Rel_TestDriveBindingSource.DataMember = "Rel_TestDrive";
            this.Rel_TestDriveBindingSource.DataSource = this.projetoDataSet;
            // 
            // relTestDriveBindingSource
            // 
            this.relTestDriveBindingSource.DataMember = "Rel_TestDrive";
            this.relTestDriveBindingSource.DataSource = this.projetoDataSet;
            // 
            // rel_TestDriveTableAdapter
            // 
            this.rel_TestDriveTableAdapter.ClearBeforeFill = true;
            // 
            // Form_RelatorioTestDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 671);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_RelatorioTestDrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio De Test-Drives";
            this.Load += new System.EventHandler(this.Form_RelatorioTestDrive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Test_DriveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDriveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rel_TestDriveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relTestDriveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjetoDataSet projetoDataSet;
        private System.Windows.Forms.BindingSource testDriveBindingSource;
        private ProjetoDataSetTableAdapters.Test_DriveTableAdapter test_DriveTableAdapter;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Test_DriveBindingSource;
        private System.Windows.Forms.BindingSource Rel_TestDriveBindingSource;
        private System.Windows.Forms.BindingSource relTestDriveBindingSource;
        private ProjetoDataSetTableAdapters.Rel_TestDriveTableAdapter rel_TestDriveTableAdapter;
    }
}