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
    public partial class MaterialEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public MaterialEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public MaterialEditor(int id, string material_name) : this()
        {
            materialTableAdapter1.Fill(flowerShopDataSet1.Material);
            edit = true;
            this.id = id;
            textBox_name.Text = material_name;
        }
        private void MaterialEditor_Load(object sender, EventArgs e)
        {
            this.materialTableAdapter1.Fill(this.flowerShopDataSet1.Material);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                materialTableAdapter1.UpdateQuery(textBox_name.Text, id);
            }
            else
            {
                materialTableAdapter1.InsertQuery(textBox_name.Text);
            }
            Close();
        }
    }
}