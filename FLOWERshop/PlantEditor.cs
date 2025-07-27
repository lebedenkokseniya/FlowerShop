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
    public partial class PlantEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public PlantEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public PlantEditor(int id, string plant_name, string plant_description, string plant_image, decimal plant_price, int plant_amount, decimal plant_height, decimal plant_width, decimal plant_weight, int category_id, int material_id, int plant_type_id, int flower_color_id) : this()
        {
            plantTableAdapter1.Fill(flowerShopDataSet.Plant);
            categoryTableAdapter.Fill(flowerShopDataSet.Category);
            materialTableAdapter.Fill(flowerShopDataSet.Material);
            plantTypeTableAdapter.Fill(flowerShopDataSet.PlantType);
            flowerColorTableAdapter.Fill(flowerShopDataSet.FlowerColor);
            edit = true;
            this.id = id;
            textBox_name.Text = plant_name;
            textBox_description.Text = plant_description;
            textBox_image.Text = plant_image;
            textBox_price.Text = plant_price.ToString();
            textBox_amount.Text = plant_amount.ToString();
            textBox_height.Text = plant_height.ToString();
            textBox_width.Text = plant_width.ToString();
            textBox_weight.Text = plant_weight.ToString();
            comboBox_category.SelectedValue = category_id;
            comboBox_material.SelectedValue = material_id;
            comboBox_plantType.SelectedValue = plant_type_id;
            comboBox_flowerColor.SelectedValue = flower_color_id;
        }
        private void PlantEditor_Load(object sender, EventArgs e)
        {
            this.plantTableAdapter1.Fill(this.flowerShopDataSet.Plant);
            this.categoryTableAdapter.Fill(this.flowerShopDataSet.Category);
            this.flowerColorTableAdapter.Fill(this.flowerShopDataSet.FlowerColor);
            this.materialTableAdapter.Fill(this.flowerShopDataSet.Material);
            this.plantTypeTableAdapter.Fill(this.flowerShopDataSet.PlantType);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                plantTableAdapter1.UpdateQuery(textBox_name.Text,
                    textBox_description.Text,
                    textBox_image.Text,
                    Convert.ToDecimal(textBox_price.Text),
                    Convert.ToInt32(textBox_amount.Text),
                    Convert.ToDecimal(textBox_height.Text),
                    Convert.ToDecimal(textBox_width.Text),
                    Convert.ToDecimal(textBox_weight.Text),
                    Convert.ToInt32(comboBox_category.SelectedValue),
                    Convert.ToInt32(comboBox_material.SelectedValue),
                    Convert.ToInt32(comboBox_plantType.SelectedValue),
                    Convert.ToInt32(comboBox_flowerColor.SelectedValue),
                    id);
            }
            else
            {
                plantTableAdapter1.InsertQuery(textBox_name.Text,
                    textBox_description.Text,
                    textBox_image.Text,
                    Convert.ToDecimal(textBox_price.Text),
                    Convert.ToInt32(textBox_amount.Text),
                    Convert.ToDecimal(textBox_height.Text),
                    Convert.ToDecimal(textBox_width.Text),
                    Convert.ToDecimal(textBox_weight.Text),
                    Convert.ToInt32(comboBox_category.SelectedValue),
                    Convert.ToInt32(comboBox_material.SelectedValue),
                    Convert.ToInt32(comboBox_plantType.SelectedValue),
                    Convert.ToInt32(comboBox_flowerColor.SelectedValue));
            }
            Close();
        }
    }
}