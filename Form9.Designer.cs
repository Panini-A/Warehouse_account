namespace Storage
{
    partial class Form9
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.складDataSet = new Storage.СкладDataSet();
            this.цехBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цехTableAdapter = new Storage.СкладDataSetTableAdapters.ЦехTableAdapter();
            this.наименованиеСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПоступленийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеСырьяDataGridViewTextBoxColumn,
            this.количествоПоступленийDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.цехBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 138);
            this.dataGridView1.TabIndex = 1;
            // 
            // складDataSet
            // 
            this.складDataSet.DataSetName = "СкладDataSet";
            this.складDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цехBindingSource
            // 
            this.цехBindingSource.DataMember = "Цех";
            this.цехBindingSource.DataSource = this.складDataSet;
            // 
            // цехTableAdapter
            // 
            this.цехTableAdapter.ClearBeforeFill = true;
            // 
            // наименованиеСырьяDataGridViewTextBoxColumn
            // 
            this.наименованиеСырьяDataGridViewTextBoxColumn.DataPropertyName = "Наименование сырья";
            this.наименованиеСырьяDataGridViewTextBoxColumn.HeaderText = "Наименование сырья";
            this.наименованиеСырьяDataGridViewTextBoxColumn.Name = "наименованиеСырьяDataGridViewTextBoxColumn";
            // 
            // количествоПоступленийDataGridViewTextBoxColumn
            // 
            this.количествоПоступленийDataGridViewTextBoxColumn.DataPropertyName = "Количество поступлений";
            this.количествоПоступленийDataGridViewTextBoxColumn.HeaderText = "Количество поступлений";
            this.количествоПоступленийDataGridViewTextBoxColumn.Name = "количествоПоступленийDataGridViewTextBoxColumn";
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список сырья";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цехBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private СкладDataSet складDataSet;
        private System.Windows.Forms.BindingSource цехBindingSource;
        private СкладDataSetTableAdapters.ЦехTableAdapter цехTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПоступленийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
    }
}