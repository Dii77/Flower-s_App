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
    public partial class BouqectsForm : Form
    {
        public BouqectsForm()
        {
            InitializeComponent();
        }

        //private void букетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.букетBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.магазин_цветовDataSet);

        //}

        private void Букеты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Букет". При необходимости она может быть перемещена или удалена.
            this.букетTableAdapter.Fill(this.магазин_цветовDataSet.Букет);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            букетTableAdapter.Update(this.магазин_цветовDataSet.Букет);
            MessageBox.Show("Букет успешно добавлен в базу данных 'Букет'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                букетBindingSource.RemoveCurrent();
                букетTableAdapter.Update(this.магазин_цветовDataSet.Букет);
                MessageBox.Show("Букет успешно удален из базы данных");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Букет не удален");
            }
        }
    }
}
