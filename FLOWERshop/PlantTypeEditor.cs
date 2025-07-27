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
    public partial class PlantTypeEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public PlantTypeEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public PlantTypeEditor(int id, string plant_type_name) : this()
        {
            plantTypeTableAdapter1.Fill(flowerShopDataSet1.PlantType);
            edit = true;
            this.id = id;
            textBox_name.Text = plant_type_name;
        }
        private void PlantTypeEditor_Load(object sender, EventArgs e)
        {
            this.plantTypeTableAdapter1.Fill(this.flowerShopDataSet1.PlantType);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                plantTypeTableAdapter1.UpdateQuery(textBox_name.Text, id);
            }
            else
            {
                plantTypeTableAdapter1.InsertQuery(textBox_name.Text);
            }
            Close();
        }
    }
}
