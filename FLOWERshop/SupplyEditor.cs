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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FLOWERshop
{
    public partial class SupplyEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        string status;
        int supID;
        public SupplyEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public SupplyEditor(int id, string invoice_number, int supply_plants_amount, DateTime supply_date, DateTime? delivery_date, string supply_status, int supplier_id) : this()
        {
            supplyTableAdapter1.Fill(flowerShopDataSet.Supply);
            supplierTableAdapter.Fill(flowerShopDataSet.Supplier);
            edit = true;
            this.id = id;
            supID = id;
            status = supply_status;
            textBox_invoiceNumber.Text = invoice_number;
            textBox_amount.Text = supply_plants_amount.ToString();
            dateTimePicker_supplyDate.Value = supply_date;
            if (delivery_date.HasValue)
            {
                dateTimePicker_deliveryDate.Value = delivery_date.Value;
            }
            comboBox_status.Text = supply_status;
            comboBox_supplier.SelectedValue = supplier_id;
        }
        private void SupplyEditor_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Fill(this.flowerShopDataSet.Supplier);
            this.supplyTableAdapter1.Fill(this.flowerShopDataSet.Supply);
            checkBox1.Checked = false;
            checkBox1.Visible = true;
            dateTimePicker_deliveryDate.Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Visible = false;
                dateTimePicker_deliveryDate.Visible = true;
                dateTimePicker_deliveryDate.Value = DateTime.Now; 
            }
        }
        private void button2_Click(object sender, EventArgs e)
        { 
            if (edit)
            {
                supplyTableAdapter1.UpdateQuery(textBox_invoiceNumber.Text,
                    Convert.ToInt32(textBox_amount.Text),
                    dateTimePicker_supplyDate.Value,
                    dateTimePicker_deliveryDate.Value,
                    comboBox_status.Text,
                    Convert.ToInt32(comboBox_supplier.SelectedValue),
                    id);
                if (status == "Очікується" && comboBox_status.Text == "Доставлено")
                {
                    plantTableAdapter1.UpdatePlantAmountIncr(supID);
                }
            }
            else
            {
                supplyTableAdapter1.InsertQuery(textBox_invoiceNumber.Text,
                    Convert.ToInt32(textBox_amount.Text),
                    dateTimePicker_supplyDate.Value,
                    dateTimePicker_deliveryDate.Value,
                    comboBox_status.Text,
                    Convert.ToInt32(comboBox_supplier.SelectedValue));
                if (comboBox_status.Text == "Доставлено")
                {
                    plantTableAdapter1.UpdatePlantAmountIncr(supID);
                }
            }
            Close();
        }
    }
}