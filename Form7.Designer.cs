namespace Storage
{
    partial class Form7
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
            this.складDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикСиМBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщик_СиМTableAdapter = new Storage.СкладDataSetTableAdapters.Поставщик_СиМTableAdapter();
            this.наименованиеорганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиесырьяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаизмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресорганизацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикСиМBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.наименованиеорганизацииDataGridViewTextBoxColumn,
            this.наименованиесырьяDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn,
            this.единицаизмеренияDataGridViewTextBoxColumn,
            this.адресорганизацииDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставщикСиМBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 134);
            this.dataGridView1.TabIndex = 1;
            // 
            // складDataSet
            // 
            this.складDataSet.DataSetName = "СкладDataSet";
            this.складDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // складDataSetBindingSource
            // 
            this.складDataSetBindingSource.DataSource = this.складDataSet;
            this.складDataSetBindingSource.Position = 0;
            // 
            // поставщикСиМBindingSource
            // 
            this.поставщикСиМBindingSource.DataMember = "Поставщик СиМ";
            this.поставщикСиМBindingSource.DataSource = this.складDataSet;
            // 
            // поставщик_СиМTableAdapter
            // 
            this.поставщик_СиМTableAdapter.ClearBeforeFill = true;
            // 
            // наименованиеорганизацииDataGridViewTextBoxColumn
            // 
            this.наименованиеорганизацииDataGridViewTextBoxColumn.DataPropertyName = "Наименование_организации";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.HeaderText = "Наименование_организации";
            this.наименованиеорганизацииDataGridViewTextBoxColumn.Name = "наименованиеорганизацииDataGridViewTextBoxColumn";
            // 
            // наименованиесырьяDataGridViewTextBoxColumn
            // 
            this.наименованиесырьяDataGridViewTextBoxColumn.DataPropertyName = "Наименование_сырья";
            this.наименованиесырьяDataGridViewTextBoxColumn.HeaderText = "Наименование_сырья";
            this.наименованиесырьяDataGridViewTextBoxColumn.Name = "наименованиесырьяDataGridViewTextBoxColumn";
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            // 
            // единицаизмеренияDataGridViewTextBoxColumn
            // 
            this.единицаизмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.HeaderText = "Единица_измерения";
            this.единицаизмеренияDataGridViewTextBoxColumn.Name = "единицаизмеренияDataGridViewTextBoxColumn";
            // 
            // адресорганизацииDataGridViewTextBoxColumn
            // 
            this.адресорганизацииDataGridViewTextBoxColumn.DataPropertyName = "Адрес_организации";
            this.адресорганизацииDataGridViewTextBoxColumn.HeaderText = "Адрес_организации";
            this.адресорганизацииDataGridViewTextBoxColumn.Name = "адресорганизацииDataGridViewTextBoxColumn";
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список поставщиков";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикСиМBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource складDataSetBindingSource;
        private СкладDataSet складDataSet;
        private System.Windows.Forms.BindingSource поставщикСиМBindingSource;
        private СкладDataSetTableAdapters.Поставщик_СиМTableAdapter поставщик_СиМTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеорганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиесырьяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаизмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресорганизацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
    }
}