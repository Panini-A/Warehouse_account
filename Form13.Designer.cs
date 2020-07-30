namespace Storage
{
    partial class Form13
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.складDataSet = new Storage.СкладDataSet();
            this.складСиМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.склад_СиМTableAdapter = new Storage.СкладDataSetTableAdapters.Склад_СиМTableAdapter();
            this.кодСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеСырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоНаСкладеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складСиМBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодСырьяDataGridViewTextBoxColumn,
            this.наименованиеСырьяDataGridViewTextBoxColumn,
            this.количествоНаСкладеDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складСиМBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // складDataSet
            // 
            this.складDataSet.DataSetName = "СкладDataSet";
            this.складDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складСиМBindingSource
            // 
            this.складСиМBindingSource.DataMember = "Склад СиМ";
            this.складСиМBindingSource.DataSource = this.складDataSet;
            // 
            // склад_СиМTableAdapter
            // 
            this.склад_СиМTableAdapter.ClearBeforeFill = true;
            // 
            // кодСырьяDataGridViewTextBoxColumn
            // 
            this.кодСырьяDataGridViewTextBoxColumn.DataPropertyName = "Код сырья";
            this.кодСырьяDataGridViewTextBoxColumn.HeaderText = "Код сырья";
            this.кодСырьяDataGridViewTextBoxColumn.Name = "кодСырьяDataGridViewTextBoxColumn";
            // 
            // наименованиеСырьяDataGridViewTextBoxColumn
            // 
            this.наименованиеСырьяDataGridViewTextBoxColumn.DataPropertyName = "Наименование сырья";
            this.наименованиеСырьяDataGridViewTextBoxColumn.HeaderText = "Наименование сырья";
            this.наименованиеСырьяDataGridViewTextBoxColumn.Name = "наименованиеСырьяDataGridViewTextBoxColumn";
            // 
            // количествоНаСкладеDataGridViewTextBoxColumn
            // 
            this.количествоНаСкладеDataGridViewTextBoxColumn.DataPropertyName = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.HeaderText = "Количество на складе";
            this.количествоНаСкладеDataGridViewTextBoxColumn.Name = "количествоНаСкладеDataGridViewTextBoxColumn";
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список СиМ";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складСиМBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private СкладDataSet складDataSet;
        private System.Windows.Forms.BindingSource складСиМBindingSource;
        private СкладDataSetTableAdapters.Склад_СиМTableAdapter склад_СиМTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеСырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоНаСкладеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
    }
}