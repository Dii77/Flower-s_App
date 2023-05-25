using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Flower_s_App
{
    public partial class AuthorizationForm : Form
    {
        public static String use = "";
        bool vision = true;

        public AuthorizationForm()
        {
            InitializeComponent();
            txtUserLogin.Validating += txtUserLogin_Validating;
            txtUserPassword.Validating += txtUserPassword_Validating;
        }

        private void txtUserLogin_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserLogin.Text))
            {
                errorProvider1.SetError(txtUserLogin, "Не указан логин!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtUserPassword_Validating(object sender, CancelEventArgs e)
        {
            int pas = 0;
            if (String.IsNullOrEmpty(txtUserPassword.Text))
            {
                errorProvider1.SetError(txtUserPassword, "Не указан пароль!");
            }
            else if (!Int32.TryParse(txtUserPassword.Text, out pas))
            {
                errorProvider1.SetError(txtUserPassword, "Некорретный пароль!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btn_Registration_Click(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void btnCheckPassword_Click(object sender, EventArgs e)
        {
            if (vision)
            {
                txtUserPassword.UseSystemPasswordChar = false;
                vision = false;
            }
            else
            {
                txtUserPassword.UseSystemPasswordChar = true;
                vision = true;
            }
        }

        //private void brnChangePassword_Click(object sender, EventArgs e)
        //{
        //    //this.Hide();
        //    //ChangePassword changePassword = new ChangePassword();
        //    //changePassword.Show();
        //}

        public void btn_Enter_Click(object sender, EventArgs e)
        {
            use = this.txtUserLogin.Text;
            string b = this.txtUserPassword.Text;
            if (use == "di" && b == "777")
            {
                this.Hide();
                Admin_ admin_ = new Admin_();
                admin_.Show();
            }
            else
            {
                try
                {
                    SqlConnection con  = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Магазин_цветов; Integrated Security = True");
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select [Логин], [Пароль] from Клиент where [Логин] = '" + use + "' and [Пароль] = '" + b + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        ProfileClient profile = new ProfileClient();
                        profile.Show();
                        //Страница_каталога Страница_каталога = new Страница_каталога();
                        //Страница_каталога.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("У данного пользователя другой пароль, попробуйте его вспомнить)");
                    }
                }
                catch (Exception ae)
                {
                    Console.WriteLine(ae.ToString());
                }
            }              
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUserLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutApp_Click(object sender, EventArgs e)
        {
            AboutForm frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }

    
    }
}
