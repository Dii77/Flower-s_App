using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flower_s_App
{
    public partial class Form1 : Form
    {
        private string use;

        public Form1()
        {
            InitializeComponent();
            txtLogin.Validating += txtLogin_Validating;
        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            use = this.txtLogin.Text;
            try
            {
                SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Магазин_цветов; Integrated Security = True");
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select [Логин] from Клиент where [Логин] = '" + use + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Такой пользователь уже существует, попробуйте придумать другой логин)");
                }
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.ToString());
            }

            if (String.IsNullOrEmpty(txtLogin.Text))
            {
                errorProvider1.SetError(txtLogin, "Не указан логин!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Магазин_цветов; Integrated Security = True
                SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Магазин_цветов; Integrated Security = True");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Клиент]
               ([Имя]
               ,[Фамилия]
               ,[Почта]
               ,[Телефон]
               ,[Логин]
               ,[Пароль])
         VALUES
                      ('" + txtName.Text + "', '" + txtSurname.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + txtLogin.Text + "', '" + txtPassword.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Регистрация прошла успешно!");
            }
        }

        private void btn_to_Autorization_Click(object sender, EventArgs e)
        {
            Form AutorizationForm = new AuthorizationForm();
            AutorizationForm.Show();
            this.Hide();
        }
    }
}
