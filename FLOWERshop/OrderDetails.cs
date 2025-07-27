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
    public partial class OrderDetails : Form
    {
        private int _orderID;
        public OrderDetails()
        {
            InitializeComponent();
        }
        public OrderDetails(int orderID)
        {
            InitializeComponent();
            _orderID = orderID;
        }
        private void OrderDetails_Load(object sender, EventArgs e)
        {
            this.plantTypeTableAdapter.Fill(this.flowerShopDataSet.PlantType);
            this.plantTableAdapter.Fill(this.flowerShopDataSet.Plant);
            this.order_itemTableAdapter.Fill(this.flowerShopDataSet.Order_item);
            this.orderTableAdapter.Fill(this.flowerShopDataSet.Order);
            this.flowerColorTableAdapter.Fill(this.flowerShopDataSet.FlowerColor);
            this.materialTableAdapter.Fill(this.flowerShopDataSet.Material);
            this.categoryTableAdapter.Fill(this.flowerShopDataSet.Category);
            var orderItemTable = new FlowerShopDataSet.Order_itemDataTable();
            var orderItemAdapter = new FlowerShopDataSetTableAdapters.Order_itemTableAdapter();
            orderItemAdapter.FillByOrderId(orderItemTable, _orderID);
            dataGridView1.DataSource = orderItemTable;
            var plantsTable = new FlowerShopDataSet.PlantDataTable();
            var plantAdapter = new FlowerShopDataSetTableAdapters.PlantTableAdapter();
            plantAdapter.FillByOrderId(plantsTable, _orderID);
            dataGridView2.DataSource = plantsTable;
        }
        private bool edit;
        private void button1_Click(object sender, EventArgs e)
        {
            edit = false;
            var edt = new OrderItemEditor();
            edt.ShowDialog();
            order_itemTableAdapter.Fill(flowerShopDataSet.Order_item);
            flowerShopDataSet.AcceptChanges();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            edit = true;
            var st = new FlowerShopDataSet.Order_itemDataTable();
            order_itemTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = st.Rows[0].ItemArray;
            var edt = new OrderItemEditor(
                Convert.ToInt32(row[0]),
                Convert.ToInt32(row[1]),
                Convert.ToInt32(row[2]),
                Convert.ToInt32(row[3]),
                Convert.ToDecimal(row[4])
            );
            edt.ShowDialog();
            order_itemTableAdapter.Fill(flowerShopDataSet.Order_item);
            flowerShopDataSet.AcceptChanges();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            order_itemTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            order_itemTableAdapter.Fill(flowerShopDataSet.Order_item);
            flowerShopDataSet.AcceptChanges();
        }
    }
}