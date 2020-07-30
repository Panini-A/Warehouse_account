namespace Storage
{
    partial class Form10
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
            this.Склад_ГПBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.СкладDataSet = new Storage.СкладDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Склад_ГПTableAdapter = new Storage.СкладDataSetTableAdapters.Склад_ГПTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Склад_ГПBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Склад_ГПBindingSource
            // 
            this.Склад_ГПBindingSource.DataMember = "Склад ГП";
            this.Склад_ГПBindingSource.DataSource = this.СкладDataSet;
            // 
            // СкладDataSet
            // 
            this.СкладDataSet.DataSetName = "СкладDataSet";
            this.СкладDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Склад_ГПBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Storage.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(731, 255);
            this.reportViewer1.TabIndex = 0;
            // 
            // Склад_ГПTableAdapter
            // 
            this.Склад_ГПTableAdapter.ClearBeforeFill = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 351);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары на складе ГП";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Склад_ГПBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.СкладDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Склад_ГПBindingSource;
        private СкладDataSet СкладDataSet;
        private СкладDataSetTableAdapters.Склад_ГПTableAdapter Склад_ГПTableAdapter;
    }
}