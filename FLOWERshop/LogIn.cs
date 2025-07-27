using FLOWERshop.FlowerShopDataSetTableAdapters;
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
using static FLOWERshop.FlowerShopDataSet;

namespace FLOWERshop
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            var userDataTable = this.userTableAdapter1.GetDataByCredentials(login, password);
            if (userDataTable.Rows.Count > 0)
            {
                var userRole = userDataTable.Rows[0]["user_role"].ToString();
                if (userRole == "Адміністратор")
                {
                    Form2 adminForm = new Form2();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    int user = Convert.ToInt32(userDataTable.Rows[0]["user_id"]);
                    Catalogue userForm = new Catalogue(user);
                    userForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Невірний логін або пароль.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}