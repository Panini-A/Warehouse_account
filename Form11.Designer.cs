namespace Storage
{
    partial class Form11
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.СкладDataSet = new Storage.СкладDataSet();
            this.Заказчик_ГПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Заказчик_ГПTableAdapter = new Storage.СкладDataSetTableAdapters.Заказчик_ГПTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Заказчик_ГПBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Заказчик_ГПBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storage.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // СкладDataSet
            // 
            this.СкладDataSet.DataSetName = "СкладDataSet";
            this.СкладDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Заказчик_ГПBindingSource
            // 
            this.Заказчик_ГПBindingSource.DataMember = "Заказчик ГП";
            this.Заказчик_ГПBindingSource.DataSource = this.СкладDataSet;
            // 
            // Заказчик_ГПTableAdapter
            // 
            this.Заказчик_ГПTableAdapter.ClearBeforeFill = true;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 309);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет о заказах";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Заказчик_ГПBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Заказчик_ГПBindingSource;
        private СкладDataSet СкладDataSet;
        private СкладDataSetTableAdapters.Заказчик_ГПTableAdapter Заказчик_ГПTableAdapter;
    }
}