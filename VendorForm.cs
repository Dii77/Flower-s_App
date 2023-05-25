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
    public partial class VendorForm : Form
    {
        public VendorForm()
        {
            InitializeComponent();
        }

        private void VendorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.магазин_цветовDataSet.Поставщик);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            поставщикTableAdapter.Update(this.магазин_цветовDataSet.Поставщик);
            MessageBox.Show("Поставщик успешно добавлен в базу данных 'Поставщик'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                поставщикBindingSource.RemoveCurrent();
                поставщикTableAdapter.Update(this.магазин_цветовDataSet.Поставщик);
                MessageBox.Show("Поставщик успешно удален из базы данных");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Поставщик не удален");
            }
        }
    }
}
