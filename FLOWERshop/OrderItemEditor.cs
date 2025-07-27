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
    public partial class OrderItemEditor : Form
    {
        private void Form4_Load(object sender, EventArgs e)
        {
            this.plantTableAdapter.Fill(this.flowerShopDataSet.Plant);
            this.orderTableAdapter.Fill(this.flowerShopDataSet.Order);
            this.order_itemTableAdapter1.Fill(this.flowerShopDataSet.Order_item);
        }
        private readonly int id;
        readonly bool edit;
        public OrderItemEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public OrderItemEditor(int id, int order_id, int plant_id, int orderedPlantsAmount, decimal orderedPlantsPrice) : this()
        {
            order_itemTableAdapter1.Fill(flowerShopDataSet.Order_item);
            orderTableAdapter.Fill(flowerShopDataSet.Order);
            plantTableAdapter.Fill(flowerShopDataSet.Plant);
            edit = true;
            this.id = id;
            comboBox_order.Text = order_id.ToString();
            comboBox_plant.Text = plant_id.ToString();
            textBox_amount.Text = orderedPlantsAmount.ToString();
            textBox_price.Text = orderedPlantsPrice.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(comboBox_order.SelectedValue);
            DataTable table = new DataTable();
            table = orderTableAdapter.GetDataByOrderID(orderID);
            DataRow row = table.Rows[0];
            decimal orderPrice = Convert.ToDecimal(row[2]);
            if (edit)
            {
                DataTable tableItem = new DataTable();
                tableItem = order_itemTableAdapter1.GetDataByOrderItemID(id);
                DataRow rowItem = tableItem.Rows[0];
                decimal orderItPrice = Convert.ToDecimal(rowItem[4]);
                decimal newPrice = orderPrice - orderItPrice;
                order_itemTableAdapter1.UpdateQuery(
                    Convert.ToInt32(comboBox_plant.SelectedValue),
                    Convert.ToInt32(comboBox_order.SelectedValue),
                    Convert.ToDecimal(textBox_price.Text),
                    Convert.ToInt32(textBox_amount.Text),
                    id);
                newPrice = newPrice + Convert.ToDecimal(textBox_price.Text);
                orderTableAdapter.UpdateNewPrice(newPrice, orderID);
            }
            else
            {
                order_itemTableAdapter1.InsertQuery(
                    Convert.ToInt32(comboBox_plant.SelectedValue),
                    Convert.ToInt32(comboBox_order.SelectedValue),
                    Convert.ToDecimal(textBox_price.Text),
                    Convert.ToInt32(textBox_amount.Text));
                
                decimal newPrice = orderPrice + Convert.ToDecimal(textBox_price.Text);
                orderTableAdapter.UpdateNewPrice(newPrice, orderID);
            }
            Close();
        }
    }
}
