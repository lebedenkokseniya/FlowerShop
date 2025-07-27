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
    public partial class OrderEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public OrderEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public OrderEditor(int id, DateTime order_date, decimal order_price, string order_status, string deliver_address, string payment_type, int user_id) : this()
        {
            orderTableAdapter1.Fill(flowerShopDataSet1.Order);
            userTableAdapter.Fill(flowerShopDataSet1.User);
            edit = true;
            this.id = id;
            dateTimePicker.Value = order_date;
            textBox_price.Text = order_price.ToString(); 
            comboBox_status.SelectedValue = order_status;
            textBox_address.Text = deliver_address; 
            comboBox_payment.Text = payment_type;
            comboBox_user.SelectedValue = user_id;
        }
        private void OrderEditor_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.flowerShopDataSet1.User);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                orderTableAdapter1.UpdateQuery(dateTimePicker.Value,
                    Convert.ToDecimal(textBox_price.Text),
                    comboBox_status.Text,
                    textBox_address.Text,
                    comboBox_payment.Text,
                    Convert.ToInt32(comboBox_user.SelectedValue),
                    id);
            }
            Close();
        }
    }
}