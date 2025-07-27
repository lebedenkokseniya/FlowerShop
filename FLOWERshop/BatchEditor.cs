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
    public partial class BatchEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public BatchEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public BatchEditor(int id, int batch_plants_amount, decimal batch_price, int quantity_sold, int quantity_reserved, int supply_id, int plant_id) : this()
        {
            batchTableAdapter1.Fill(flowerShopDataSet.Batch);
            supplyTableAdapter.Fill(flowerShopDataSet.Supply);
            plantTableAdapter.Fill(flowerShopDataSet.Plant);
            edit = true;
            this.id = id;
            textBox_amount.Text = batch_plants_amount.ToString();
            textBox_price.Text = batch_price.ToString();
            textBox_quantitySold.Text = quantity_sold.ToString();
            textBox_quantityReserved.Text = quantity_reserved.ToString();
            comboBox_supply.SelectedValue = supply_id;
            comboBox_plant.SelectedValue = plant_id;
        }
        private void BatchEditor_Load(object sender, EventArgs e)
        {
            this.plantTableAdapter.Fill(this.flowerShopDataSet.Plant);
            this.batchTableAdapter1.Fill(this.flowerShopDataSet.Batch);
            this.supplyTableAdapter.Fill(this.flowerShopDataSet.Supply);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                batchTableAdapter1.UpdateQuery(Convert.ToInt32(textBox_amount.Text),
                    Convert.ToDecimal(textBox_price.Text),
                    Convert.ToInt32(textBox_quantitySold.Text),
                    Convert.ToInt32(textBox_quantityReserved.Text),
                    Convert.ToInt32(comboBox_supply.SelectedValue),
                    Convert.ToInt32(comboBox_plant.SelectedValue),
                    id);
            }
            else
            {
                batchTableAdapter1.InsertQuery(Convert.ToInt32(textBox_amount.Text),
                    Convert.ToDecimal(textBox_price.Text),
                    Convert.ToInt32(textBox_quantitySold.Text),
                    Convert.ToInt32(textBox_quantityReserved.Text),
                    Convert.ToInt32(comboBox_supply.SelectedValue),
                    Convert.ToInt32(comboBox_plant.SelectedValue));
            }
            Close();
        }
    }
}