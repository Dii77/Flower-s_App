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
    public partial class DeliveryForm : Form
    {
        public DeliveryForm()
        {
            InitializeComponent();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this.магазин_цветовDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Цветок". При необходимости она может быть перемещена или удалена.
            this.цветокTableAdapter.Fill(this.магазин_цветовDataSet.Цветок);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Поставка". При необходимости она может быть перемещена или удалена.
            this.поставкаTableAdapter.Fill(this.магазин_цветовDataSet.Поставка);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            поставкаTableAdapter.Update(this.магазин_цветовDataSet.Поставка);
            MessageBox.Show("Поставка успешно добавлена в базу данных 'Поставка'");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                поставщикBindingSource.RemoveCurrent();
                поставщикTableAdapter.Update(this.магазин_цветовDataSet.Поставщик);
                MessageBox.Show("Поставка успешно удалена из базы данных");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Поставка не удалена");
            }
        }
    }
}
