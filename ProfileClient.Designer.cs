namespace Flower_s_App
{
    partial class ProfileClient
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
            System.Windows.Forms.Label имяLabel;
            this.магазин_цветовDataSet = new Flower_s_App.Магазин_цветовDataSet();
            this.клиентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентTableAdapter = new Flower_s_App.Магазин_цветовDataSetTableAdapters.КлиентTableAdapter();
            this.tableAdapterManager = new Flower_s_App.Магазин_цветовDataSetTableAdapters.TableAdapterManager();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            имяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.магазин_цветовDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(214, 79);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(44, 20);
            имяLabel.TabIndex = 0;
            имяLabel.Text = "Имя:";
            // 
            // магазин_цветовDataSet
            // 
            this.магазин_цветовDataSet.DataSetName = "Магазин_цветовDataSet";
            this.магазин_цветовDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентBindingSource
            // 
            this.клиентBindingSource.DataMember = "Клиент";
            this.клиентBindingSource.DataSource = this.магазин_цветовDataSet;
            // 
            // клиентTableAdapter
            // 
            this.клиентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Flower_s_App.Магазин_цветовDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БукетTableAdapter = null;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.КлиентTableAdapter = this.клиентTableAdapter;
            this.tableAdapterManager.ПоставкаTableAdapter = null;
            this.tableAdapterManager.ПоставщикTableAdapter = null;
            this.tableAdapterManager.ЦветокTableAdapter = null;
            this.tableAdapterManager.Цветы_в_букетеTableAdapter = null;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(264, 76);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(201, 26);
            this.имяTextBox.TabIndex = 1;
            // 
            // ProfileClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 407);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Name = "ProfileClient";
            this.Text = "ProfileClient";
            this.Load += new System.EventHandler(this.ProfileClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазин_цветовDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Магазин_цветовDataSet магазин_цветовDataSet;
        private System.Windows.Forms.BindingSource клиентBindingSource;
        private Магазин_цветовDataSetTableAdapters.КлиентTableAdapter клиентTableAdapter;
        private Магазин_цветовDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox имяTextBox;
    }
}