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
    public partial class Admin_ : Form
    {
        public Admin_()
        {
            InitializeComponent();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }

        private void цветокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlowerForm flowerForm = new FlowerForm();
            flowerForm.Show();
        }

        private void букетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BouqectsForm bouqectsForm = new BouqectsForm();
            bouqectsForm.Show();
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorForm vendorForm = new VendorForm();
            vendorForm.Show();
        }

        private void поставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.Show();
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
        }






        private void открытьКаталогToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Страница_каталога = new Страница_каталога();
            Страница_каталога.Show();
            this.Hide();
        }

        private void Admin__Load(object sender, EventArgs e)
        {

        }

        private void открытьБДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        //private void Report_Click(object sender, EventArgs e)
        //{
        //    //Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();

        //    //app.Visible = true;

        //    //Workbook wb = app.Workbooks.Add();
        //    //Worksheet ws = wb.Worksheets[1];

        //    //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Magazine_of_flowers;Integrated Security=True");
        //    //conn.Open();
        //    //SqlCommand cmd = new SqlCommand(@"select [Name] as 'Имя', [Surname] as 'Фамилия',
        //    //(select count(*) from Sales S where S.EmployeId = E.id ) as 'Всего продаж'
        //    //from Employes E", conn);

        //    //SqlDataReader reader = cmd.ExecuteReader();

        //    //ws.Cells[1, 1].Value = reader.GetName(0);
        //    //ws.Cells[1, 2].Value = reader.GetName(1);
        //    //ws.Cells[1, 3].Value = reader.GetName(2);

        //    //int i = 2;
        //    //while (reader.Read())
        //    //{
        //    //    ws.Cells[i, 1].Value = reader[0];
        //    //    ws.Cells[i, 2].Value = reader[1];
        //    //    ws.Cells[i, 3].Value = reader[2];
        //    //    i++;
        //    //}

        //    //reader.Close();
        //    //conn.Close();
        //}
    }
}
