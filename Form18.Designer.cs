namespace Storage
{
    partial class Form18
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
            this.готоваяПродукцияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.готовая_продукцияTableAdapter = new Storage.СкладDataSetTableAdapters.Готовая_продукцияTableAdapter();
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоИзготовленийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.единицаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.готоваяПродукцияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.наименованиеТовараDataGridViewTextBoxColumn,
            this.количествоИзготовленийDataGridViewTextBoxColumn,
            this.единицаИзмеренияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.готоваяПродукцияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 184);
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
            // готоваяПродукцияBindingSource
            // 
            this.готоваяПродукцияBindingSource.DataMember = "Готовая продукция";
            this.готоваяПродукцияBindingSource.DataSource = this.складDataSetBindingSource;
            // 
            // готовая_продукцияTableAdapter
            // 
            this.готовая_продукцияTableAdapter.ClearBeforeFill = true;
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "Код товара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "Код товара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            // 
            // наименованиеТовараDataGridViewTextBoxColumn
            // 
            this.наименованиеТовараDataGridViewTextBoxColumn.DataPropertyName = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.HeaderText = "Наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.Name = "наименованиеТовараDataGridViewTextBoxColumn";
            // 
            // количествоИзготовленийDataGridViewTextBoxColumn
            // 
            this.количествоИзготовленийDataGridViewTextBoxColumn.DataPropertyName = "Количество изготовлений";
            this.количествоИзготовленийDataGridViewTextBoxColumn.HeaderText = "Количество изготовлений";
            this.количествоИзготовленийDataGridViewTextBoxColumn.Name = "количествоИзготовленийDataGridViewTextBoxColumn";
            // 
            // единицаИзмеренияDataGridViewTextBoxColumn
            // 
            this.единицаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.HeaderText = "Единица измерения";
            this.единицаИзмеренияDataGridViewTextBoxColumn.Name = "единицаИзмеренияDataGridViewTextBoxColumn";
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список продукции";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.готоваяПродукцияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource складDataSetBindingSource;
        private СкладDataSet складDataSet;
        private System.Windows.Forms.BindingSource готоваяПродукцияBindingSource;
        private СкладDataSetTableAdapters.Готовая_продукцияTableAdapter готовая_продукцияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоИзготовленийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn единицаИзмеренияDataGridViewTextBoxColumn;
    }
}