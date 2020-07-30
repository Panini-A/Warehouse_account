namespace Storage
{
    partial class Form5
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
            this.Операции_по_складу_СиМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.СкладDataSet = new Storage.СкладDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Операции_по_складу_СиМTableAdapter = new Storage.СкладDataSetTableAdapters.Операции_по_складу_СиМTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Операции_по_складу_СиМBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Операции_по_складу_СиМBindingSource
            // 
            this.Операции_по_складу_СиМBindingSource.DataMember = "Операции по складу СиМ";
            this.Операции_по_складу_СиМBindingSource.DataSource = this.СкладDataSet;
            // 
            // СкладDataSet
            // 
            this.СкладDataSet.DataSetName = "СкладDataSet";
            this.СкладDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Операции_по_складу_СиМBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storage.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(793, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // Операции_по_складу_СиМTableAdapter
            // 
            this.Операции_по_складу_СиМTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операции по складу СиМ";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Операции_по_складу_СиМBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Операции_по_складу_СиМBindingSource;
        private СкладDataSet СкладDataSet;
        private СкладDataSetTableAdapters.Операции_по_складу_СиМTableAdapter Операции_по_складу_СиМTableAdapter;
    }
}