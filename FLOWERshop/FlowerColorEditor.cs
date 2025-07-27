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
    public partial class FlowerColorEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public FlowerColorEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public FlowerColorEditor(int id, string flower_color_name) : this()
        {
            flowerColorTableAdapter1.Fill(flowerShopDataSet1.FlowerColor);
            edit = true;
            this.id = id;
            textBox_name.Text = flower_color_name;
        }
        private void FlowerColorEditor_Load(object sender, EventArgs e)
        {

            this.flowerColorTableAdapter1.Fill(this.flowerShopDataSet1.FlowerColor);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                flowerColorTableAdapter1.UpdateQuery(textBox_name.Text, id);
            }
            else
            {
                flowerColorTableAdapter1.InsertQuery(textBox_name.Text);
            }
            Close();
        }
    }
}
