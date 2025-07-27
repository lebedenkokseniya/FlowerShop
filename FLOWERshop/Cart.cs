using FLOWERshop.FlowerShopDataSetTableAdapters;
using iText.Layout.Element;
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
    public partial class Cart : Form
    {
        int user;
        int orderID;
        public Cart()
        {
            InitializeComponent();
        }
        public Cart(int userID) : this()
        {
            user = userID;
            order_itemTableAdapter.Fill(flowerShopDataSet.Order_item);
            orderTableAdapter.Fill(flowerShopDataSet.Order);
            plantTableAdapter.Fill(flowerShopDataSet.Plant);
            userTableAdapter1.Fill(flowerShopDataSet.User);
            DataTable table = new DataTable();
            table = orderTableAdapter.GetDataByExisting(user);
            DataRow row = table.Rows[0];
            orderID = Convert.ToInt32(row[0]);
            dataGridView1.DataSource = order_itemTableAdapter.GetDataByOrderId(orderID);
            dataGridView2.DataSource = plantTableAdapter.GetDataByOrderId(orderID);
            dataGridView3.DataSource = table;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Кількість";
            dataGridView1.Columns[4].Visible = false;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "Назва";
            dataGridView2.Columns[2].HeaderText = "Опис";
            dataGridView2.Columns[3].HeaderText = "Зображення";
            dataGridView2.Columns[4].HeaderText = "Ціна";
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].HeaderText = "Висота";
            dataGridView2.Columns[7].HeaderText = "Ширина";
            dataGridView2.Columns[8].HeaderText = "Вага";
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.Columns[11].Visible = false;
            dataGridView2.Columns[12].Visible = false;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].HeaderText = "Сума";
            dataGridView3.Columns[3].Visible = false;
            dataGridView3.Columns[4].Visible = false;
            dataGridView3.Columns[5].Visible = false;
            dataGridView3.Columns[6].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var ordr = new Ordering(orderID);
            ordr.ShowDialog();
            flowerShopDataSet.AcceptChanges();
            Close();
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            this.orderTableAdapter.Fill(this.flowerShopDataSet.Order);
            this.plantTableAdapter.Fill(this.flowerShopDataSet.Plant);
            this.order_itemTableAdapter.Fill(this.flowerShopDataSet.Order_item);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                order_itemTableAdapter.DeleteQuery(orderItemId);
                orderTableAdapter.UpdateQueryWithSum(orderID);
                dataGridView1.DataSource = order_itemTableAdapter.GetDataByOrderId(orderID);
                dataGridView2.DataSource = plantTableAdapter.GetDataByOrderId(orderID);
                DataTable table = new DataTable();
                table = orderTableAdapter.GetDataByExisting(user);
                dataGridView3.DataSource = table;
            }
            else
            {
                MessageBox.Show("Оберіть елемент для видалення.");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderItemId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int plantId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                var form = new AmountOfPlant(plantId, user, orderItemId, orderID);
                form.ShowDialog();
                dataGridView1.DataSource = order_itemTableAdapter.GetDataByOrderId(orderID); 
                DataTable table = new DataTable();
                table = orderTableAdapter.GetDataByExisting(user);
                dataGridView3.DataSource = table;
            }
            else
            {
                MessageBox.Show("Оберіть елемент для зміни кількості.");
            }
        }
    }
}
