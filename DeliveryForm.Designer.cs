namespace Flower_s_App
{
    partial class DeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
            this.магазин_цветовDataSet = new Flower_s_App.Магазин_цветовDataSet();
            this.поставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкаTableAdapter = new Flower_s_App.Магазин_цветовDataSetTableAdapters.ПоставкаTableAdapter();
            this.tableAdapterManager = new Flower_s_App.Магазин_цветовDataSetTableAdapters.TableAdapterManager();
            this.поставщикTableAdapter = new Flower_s_App.Магазин_цветовDataSetTableAdapters.ПоставщикTableAdapter();
            this.цветокTableAdapter = new Flower_s_App.Магазин_цветовDataSetTableAdapters.ЦветокTableAdapter();
            this.поставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.цветокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.поставщикBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_цветовDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // магазин_цветовDataSet
            // 
            this.магазин_цветовDataSet.DataSetName = "Магазин_цветовDataSet";
            this.магазин_цветовDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставкаBindingSource
            // 
            this.поставкаBindingSource.DataMember = "Поставка";
            this.поставкаBindingSource.DataSource = this.магазин_цветовDataSet;
            // 
            // поставкаTableAdapter
            // 
            this.поставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_s_App.Магазин_цветовDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БукетTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = null;
            this.tableAdapterManager.ПоставкаTableAdapter = this.поставкаTableAdapter;
            this.tableAdapterManager.ПоставщикTableAdapter = this.поставщикTableAdapter;
            this.tableAdapterManager.ЦветокTableAdapter = this.цветокTableAdapter;
            this.tableAdapterManager.Цветы_в_букетеTableAdapter = null;
            // 
            // поставщикTableAdapter
            // 
            this.поставщикTableAdapter.ClearBeforeFill = true;
            // 
            // цветокTableAdapter
            // 
            this.цветокTableAdapter.ClearBeforeFill = true;
            // 
            // поставкаDataGridView
            // 
            this.поставкаDataGridView.AutoGenerateColumns = false;
            this.поставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.поставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.поставкаDataGridView.DataSource = this.поставкаBindingSource;
            this.поставкаDataGridView.Location = new System.Drawing.Point(75, 64);
            this.поставкаDataGridView.Name = "поставкаDataGridView";
            this.поставкаDataGridView.RowHeadersWidth = 62;
            this.поставкаDataGridView.RowTemplate.Height = 28;
            this.поставкаDataGridView.Size = new System.Drawing.Size(851, 210);
            this.поставкаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ПоставкаId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ПоставкаId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "КодЦветка";
            this.dataGridViewTextBoxColumn2.DataSource = this.цветокBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Наименование";
            this.dataGridViewTextBoxColumn2.HeaderText = "КодЦветка";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // цветокBindingSource
            // 
            this.цветокBindingSource.DataMember = "Цветок";
            this.цветокBindingSource.DataSource = this.магазин_цветовDataSet;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "КодПоставщика";
            this.dataGridViewTextBoxColumn3.DataSource = this.поставщикBindingSource;
            this.dataGridViewTextBoxColumn3.HeaderText = "КодПоставщика";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // поставщикBindingSource
            // 
            this.поставщикBindingSource.DataMember = "Поставщик";
            this.поставщикBindingSource.DataSource = this.магазин_цветовDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата поставки";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата поставки";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Количество";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(75, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 46);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(654, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(272, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(985, 487);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.поставкаDataGridView);
            this.Name = "DeliveryForm";
            this.Text = "DeliveryForm";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазин_цветовDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.цветокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Магазин_цветовDataSet магазин_цветовDataSet;
        private System.Windows.Forms.BindingSource поставкаBindingSource;
        private Магазин_цветовDataSetTableAdapters.ПоставкаTableAdapter поставкаTableAdapter;
        private Магазин_цветовDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView поставкаDataGridView;
        private Магазин_цветовDataSetTableAdapters.ЦветокTableAdapter цветокTableAdapter;
        private System.Windows.Forms.BindingSource цветокBindingSource;
        private Магазин_цветовDataSetTableAdapters.ПоставщикTableAdapter поставщикTableAdapter;
        private System.Windows.Forms.BindingSource поставщикBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}