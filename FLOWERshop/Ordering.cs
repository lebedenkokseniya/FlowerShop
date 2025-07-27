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
    public partial class Ordering : Form
    {
        int order;
        public Ordering()
        {
            InitializeComponent();
        }
        public Ordering(int orderID) : this()
        {
            order = orderID;
            comboBox1.Items.Add(new { Text = "Картка", Value = "Картка" });
            comboBox1.Items.Add(new { Text = "Готівка", Value = "Готівка" });
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderTableAdapter1.UpdateQueryCompleteOrdering("Сформовано", textBox1.Text, comboBox1.Text, order);
            plantTableAdapter1.UpdatePlantAmountDecr(order);
            MessageBox.Show("Замовлення успішно сформовано!");
            Close();
        }
    }
}
