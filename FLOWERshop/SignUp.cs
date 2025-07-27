using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FLOWERshop
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void SignUn_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userTableAdapter1.InsertQuery(textBox3.Text, textBox1.Text, textBox4.Text, null, textBox2.Text, DateTime.Now, "Клієнт");
            MessageBox.Show("Акаунт успішно створено!");
            Close();
        }
    }
}
