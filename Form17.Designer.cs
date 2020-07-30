namespace Storage
{
    partial class Form17
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
            this.Операции_по_цехуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.СкладDataSet = new Storage.СкладDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Операции_по_цехуTableAdapter = new Storage.СкладDataSetTableAdapters.Операции_по_цехуTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Операции_по_цехуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Операции_по_цехуBindingSource
            // 
            this.Операции_по_цехуBindingSource.DataMember = "Операции по цеху";
            this.Операции_по_цехуBindingSource.DataSource = this.СкладDataSet;
            // 
            // СкладDataSet
            // 
            this.СкладDataSet.DataSetName = "СкладDataSet";
            this.СкладDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Операции_по_цехуBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storage.Report8.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(731, 317);
            this.reportViewer1.TabIndex = 0;
            // 
            // Операции_по_цехуTableAdapter
            // 
            this.Операции_по_цехуTableAdapter.ClearBeforeFill = true;
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операции по цеху";
            this.Load += new System.EventHandler(this.Form17_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Операции_по_цехуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Операции_по_цехуBindingSource;
        private СкладDataSet СкладDataSet;
        private СкладDataSetTableAdapters.Операции_по_цехуTableAdapter Операции_по_цехуTableAdapter;
    }
}