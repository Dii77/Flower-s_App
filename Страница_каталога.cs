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
    public partial class Страница_каталога : Form
    {
        public Страница_каталога()
        {
            InitializeComponent();
        }

        private void Страница_каталога_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "магазин_цветовDataSet.Букет". При необходимости она может быть перемещена или удалена.
            this.букетTableAdapter.Fill(this.магазин_цветовDataSet.Букет);

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Profile profile = new Profile();
            //profile.Show();
        }

        private void букетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.букетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.магазин_цветовDataSet);

        }
    }
}
