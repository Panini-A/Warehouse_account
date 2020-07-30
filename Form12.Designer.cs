namespace Storage
{
    partial class Form12
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
            this.Информация_по_товарамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.СкладDataSet = new Storage.СкладDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Информация_по_товарамTableAdapter = new Storage.СкладDataSetTableAdapters.Информация_по_товарамTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Информация_по_товарамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Информация_по_товарамBindingSource
            // 
            this.Информация_по_товарамBindingSource.DataMember = "Информация по товарам";
            this.Информация_по_товарамBindingSource.DataSource = this.СкладDataSet;
            // 
            // СкладDataSet
            // 
            this.СкладDataSet.DataSetName = "СкладDataSet";
            this.СкладDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Информация_по_товарамBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storage.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(741, 189);
            this.reportViewer1.TabIndex = 0;
            // 
            // Информация_по_товарамTableAdapter
            // 
            this.Информация_по_товарамTableAdapter.ClearBeforeFill = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 240);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спецификации товаров";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Информация_по_товарамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Информация_по_товарамBindingSource;
        private СкладDataSet СкладDataSet;
        private СкладDataSetTableAdapters.Информация_по_товарамTableAdapter Информация_по_товарамTableAdapter;
    }
}