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
    public partial class CategoryEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public CategoryEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public CategoryEditor(int id, string category_name) : this()
        {
            categoryTableAdapter1.Fill(flowerShopDataSet1.Category);
            edit = true;
            this.id = id;
            textBox_name.Text = category_name;
        }
        private void CategoryEditor_Load(object sender, EventArgs e)
        {
            this.categoryTableAdapter1.Fill(this.flowerShopDataSet1.Category);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                categoryTableAdapter1.UpdateQuery(textBox_name.Text, id);
            }
            else
            {
                categoryTableAdapter1.InsertQuery(textBox_name.Text);
            }
            Close();
        }
    }
}
