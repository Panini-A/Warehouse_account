namespace Storage
{
    partial class Form4
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Поставщик_СиМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.СкладDataSet = new Storage.СкладDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Поставщик_СиМTableAdapter = new Storage.СкладDataSetTableAdapters.Поставщик_СиМTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Поставщик_СиМBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Поставщик_СиМBindingSource
            // 
            this.Поставщик_СиМBindingSource.DataMember = "Поставщик СиМ";
            this.Поставщик_СиМBindingSource.DataSource = this.СкладDataSet;
            // 
            // СкладDataSet
            // 
            this.СкладDataSet.DataSetName = "СкладDataSet";
            this.СкладDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Поставщик_СиМBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storage.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(881, 368);
            this.reportViewer1.TabIndex = 0;
            // 
            // Поставщик_СиМTableAdapter
            // 
            this.Поставщик_СиМTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о поставщиках";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Поставщик_СиМBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Поставщик_СиМBindingSource;
        private СкладDataSet СкладDataSet;
        private СкладDataSetTableAdapters.Поставщик_СиМTableAdapter Поставщик_СиМTableAdapter;
    }
}