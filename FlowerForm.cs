using Flower_s_App.Магазин_цветовDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_s_App
{
    public partial class FlowerForm : Form
    {
        public FlowerForm()
        {
            InitializeComponent();
        }

        //private void цветокBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.цветокBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.магазин_цветовDataSet);

        //}

        private void FlowerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Цветок". При необходимости она может быть перемещена или удалена.
            this.цветокTableAdapter.Fill(this.магазин_цветовDataSet.Цветок);

        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
             цветокTableAdapter.Update(this.магазин_цветовDataSet.Цветок);
             MessageBox.Show("Цветок успешно добавлен в базу данных 'Цветок'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить цветок?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                цветокBindingSource.RemoveCurrent();
                цветокTableAdapter.Update(this.магазин_цветовDataSet.Цветок);
                MessageBox.Show("Цветок успешно удален из базы данных");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Цветок не удален");
            }
            //цветокBindingSource.RemoveCurrent();
            //цветокTableAdapter.Update(this.магазин_цветовDataSet.Цветок);
        }
    }
}
