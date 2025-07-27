using FLOWERshop.FlowerShopDataSetTableAdapters;
using iText.Layout.Borders;
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

namespace FLOWERshop
{
    public partial class AmountOfPlant : Form
    {
        int plant;
        int user;
        int? orderItemId;
        int? orderId;
        public AmountOfPlant()
        {
            InitializeComponent();
        }
        public AmountOfPlant(int plantID, int userID, int? orderItemID = null, int? orderID = null) : this()
        {
            plant = plantID;
            user = userID;
            orderItemId = orderItemID;
            orderId = orderID;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime orderDate = DateTime.Now;
            DataTable table1 = new DataTable();
            table1 = orderTableAdapter1.GetDataByExisting(user);
            if (orderItemId.HasValue)
            {
                int orderedPlantAmount = (int)numericUpDown_amount.Value;
                decimal plantPrice = Convert.ToDecimal(plantTableAdapter1.ScalarQuery(plant));
                decimal orderedPlantsPrice = plantPrice * orderedPlantAmount;
                DataTable table = new DataTable();
                table = orderTableAdapter1.GetDataByOrderID(orderId.Value);
                DataRow row = table.Rows[0];
                int thatOrderID = Convert.ToInt32(row[0]);
                order_itemTableAdapter1.UpdateQuery(
                    plant,
                    thatOrderID,
                    orderedPlantsPrice,
                    orderedPlantAmount,
                    orderItemId.Value
                );
                orderTableAdapter1.UpdateQueryWithSum(thatOrderID);
                MessageBox.Show("Кількість оновлено!");
                Close();
            }
            else
            {
                if (table1.Rows.Count == 0)
                {
                    int orderedPlantAmount = (int)numericUpDown_amount.Value;
                    decimal plantPrice = Convert.ToDecimal(plantTableAdapter1.ScalarQuery(plant));
                    decimal orderedPlantsPrice = plantPrice * orderedPlantAmount;

                    string orderStatus = "В процесі формування";
                    string deliveryAddress = "Не обрана";
                    string paymentType = "Не обраний";
                    orderTableAdapter1.InsertQuery(
                        orderDate,
                        orderedPlantsPrice,
                        orderStatus,
                        deliveryAddress,
                        paymentType,
                        user
                    );
                    DataTable table = new DataTable();
                    table = orderTableAdapter1.GetDataByOrderDate(orderDate);
                    DataRow row = table.Rows[0];
                    int newOrderID = Convert.ToInt32(row[0]);
                    order_itemTableAdapter1.InsertQuery(
                        plant,
                        newOrderID,
                        orderedPlantsPrice,
                        orderedPlantAmount
                    );
                    orderTableAdapter1.Fill(flowerShopDataSet1.Order);
                    order_itemTableAdapter1.Fill(flowerShopDataSet1.Order_item);
                    MessageBox.Show("Товар додано до кошика!");
                    Close();
                }
                else
                {
                    int orderedPlantAmount = (int)numericUpDown_amount.Value;
                    decimal plantPrice = Convert.ToDecimal(plantTableAdapter1.ScalarQuery(plant));
                    decimal orderedPlantsPrice = plantPrice * orderedPlantAmount;
                    DataRow row = table1.Rows[0];
                    int orderID = Convert.ToInt32(row[0]);
                    orderTableAdapter1.UpdateQueryPrice(orderedPlantsPrice, orderID);
                    order_itemTableAdapter1.InsertQuery(
                        plant,
                        orderID,
                        orderedPlantsPrice,
                        orderedPlantAmount
                    );
                    orderTableAdapter1.Fill(flowerShopDataSet1.Order);
                    order_itemTableAdapter1.Fill(flowerShopDataSet1.Order_item);
                    MessageBox.Show("Товар додано до кошика!");
                    Close();
                }
            }
        }
        private void AmountOfPlant_Load(object sender, EventArgs e)
        {
            this.plantTableAdapter1.Fill(this.flowerShopDataSet1.Plant);
            this.orderTableAdapter1.Fill(this.flowerShopDataSet1.Order);
            this.order_itemTableAdapter1.Fill(this.flowerShopDataSet1.Order_item);
        }
    }
}