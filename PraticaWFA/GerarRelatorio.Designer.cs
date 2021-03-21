namespace PraticaWFA
{
    partial class GerarRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.p_fisicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magiclinkDataSet_p_fisica = new PraticaWFA.magiclinkDataSet_p_fisica();
            this.p_juridicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.magiclinkDataSet_p_juridica = new PraticaWFA.magiclinkDataSet_p_juridica();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.p_fisicaTableAdapter = new PraticaWFA.magiclinkDataSet_p_fisicaTableAdapters.p_fisicaTableAdapter();
            this.p_juridicaTableAdapter = new PraticaWFA.magiclinkDataSet_p_juridicaTableAdapters.p_juridicaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.p_fisicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magiclinkDataSet_p_fisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_juridicaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magiclinkDataSet_p_juridica)).BeginInit();
            this.SuspendLayout();
            // 
            // p_fisicaBindingSource
            // 
            this.p_fisicaBindingSource.DataMember = "p_fisica";
            this.p_fisicaBindingSource.DataSource = this.magiclinkDataSet_p_fisica;
            // 
            // magiclinkDataSet_p_fisica
            // 
            this.magiclinkDataSet_p_fisica.DataSetName = "magiclinkDataSet_p_fisica";
            this.magiclinkDataSet_p_fisica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p_juridicaBindingSource
            // 
            this.p_juridicaBindingSource.DataMember = "p_juridica";
            this.p_juridicaBindingSource.DataSource = this.magiclinkDataSet_p_juridica;
            // 
            // magiclinkDataSet_p_juridica
            // 
            this.magiclinkDataSet_p_juridica.DataSetName = "magiclinkDataSet_p_juridica";
            this.magiclinkDataSet_p_juridica.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_p_fisica";
            reportDataSource1.Value = this.p_fisicaBindingSource;
            reportDataSource2.Name = "DataSet_p_juridica";
            reportDataSource2.Value = this.p_juridicaBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "PraticaWFA.Relatórios.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1081, 616);
            this.reportViewer2.TabIndex = 0;
            // 
            // p_fisicaTableAdapter
            // 
            this.p_fisicaTableAdapter.ClearBeforeFill = true;
            // 
            // p_juridicaTableAdapter
            // 
            this.p_juridicaTableAdapter.ClearBeforeFill = true;
            // 
            // Relatorio
            // 
            this.ClientSize = new System.Drawing.Size(1081, 616);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Relatorio_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.p_fisicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magiclinkDataSet_p_fisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_juridicaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magiclinkDataSet_p_juridica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        
        
        
       
        
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource p_fisicaBindingSource;
        private PraticaWFA.magiclinkDataSet_p_fisica magiclinkDataSet_p_fisica;
        private System.Windows.Forms.BindingSource p_juridicaBindingSource;
        private PraticaWFA.magiclinkDataSet_p_juridica magiclinkDataSet_p_juridica;
        private PraticaWFA.magiclinkDataSet_p_fisicaTableAdapters.p_fisicaTableAdapter p_fisicaTableAdapter;
        private PraticaWFA.magiclinkDataSet_p_juridicaTableAdapters.p_juridicaTableAdapter p_juridicaTableAdapter;
    }
}