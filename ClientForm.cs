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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        //private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.клиентBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.магазин_цветовDataSet);

        //}

        private void ClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.магазин_цветовDataSet.Клиент);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                клиентBindingSource.RemoveCurrent();
                клиентTableAdapter.Update(this.магазин_цветовDataSet.Клиент);
                MessageBox.Show("Клиент успешно удален из базы данных");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Клиент не удален");
            }
        }
    }
}
