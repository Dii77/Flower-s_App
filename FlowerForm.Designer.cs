namespace Flower_s_App
{
    partial class FlowerForm
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
            this.магазин_цветовDataSet = new Flower_s_App.Магазин_цветовDataSet();
            this.цветокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.цветокTableAdapter = new Flower_s_App.Магазин_цветовDataSetTableAdapters.ЦветокTableAdapter();
            this.tableAdapterManager = new Flower_s_App.Магазин_цветовDataSetTableAdapters.TableAdapterManager();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.цветокDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_цветовDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветокDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // магазин_цветовDataSet
            // 
            this.магазин_цветовDataSet.DataSetName = "Магазин_цветовDataSet";
            this.магазин_цветовDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цветокBindingSource
            // 
            this.цветокBindingSource.DataMember = "Цветок";
            this.цветокBindingSource.DataSource = this.магазин_цветовDataSet;
            // 
            // цветокTableAdapter
            // 
            this.цветокTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_s_App.Магазин_цветовDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БукетTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.ЦветокTableAdapter = this.цветокTableAdapter;
            this.tableAdapterManager.Цветы_в_букетеTableAdapter = null;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(494, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // цветокDataGridView
            // 
            this.цветокDataGridView.AutoGenerateColumns = false;
            this.цветокDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.цветокDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.цветокDataGridView.DataSource = this.цветокBindingSource;
            this.цветокDataGridView.Location = new System.Drawing.Point(35, 54);
            this.цветокDataGridView.Name = "цветокDataGridView";
            this.цветокDataGridView.RowHeadersWidth = 62;
            this.цветокDataGridView.RowTemplate.Height = 28;
            this.цветокDataGridView.Size = new System.Drawing.Size(723, 220);
            this.цветокDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Категория";
            this.dataGridViewTextBoxColumn4.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // FlowerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.цветокDataGridView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "FlowerForm";
            this.Text = "FlowerForm";
            this.Load += new System.EventHandler(this.FlowerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазин_цветовDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветокDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Магазин_цветовDataSet магазин_цветовDataSet;
        private System.Windows.Forms.BindingSource цветокBindingSource;
        private Магазин_цветовDataSetTableAdapters.ЦветокTableAdapter цветокTableAdapter;
        private Магазин_цветовDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView цветокDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}