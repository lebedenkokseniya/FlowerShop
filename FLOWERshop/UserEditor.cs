using FLOWERshop.FlowerShopDataSetTableAdapters;
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
    public partial class UserEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public UserEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public UserEditor(int id, string user_name, string user_email, string user_phone, string user_address, string password, DateTime registration_date, string user_role) : this()
        {
            userTableAdapter1.Fill(flowerShopDataSet1.User);
            edit = true;
            this.id = id;
            textBox_name.Text = user_name;
            textBox_email.Text = user_email;
            textBox_phone.Text = user_phone;
            textBox_address.Text = user_address;
            textBox_password.Text = password;
            dateTimePicker.Value = registration_date;
            comboBox_role.Text = user_role;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                userTableAdapter1.UpdateQuery(textBox_name.Text, 
                    textBox_email.Text, 
                    textBox_phone.Text, 
                    textBox_address.Text,
                    textBox_password.Text,
                    dateTimePicker.Value,
                    comboBox_role.Text,
                    id);
            }
            Close();
        }
    }
}