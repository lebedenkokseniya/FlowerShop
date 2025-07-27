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
    public partial class SupplierEditor : Form
    {
        private readonly int id;
        readonly bool edit;
        public SupplierEditor()
        {
            InitializeComponent();
            edit = false;
        }
        public SupplierEditor(int id, string supplier_name, string contact_person, string supplier_phone, string supplier_email, string legal_address, string physical_address) : this()
        {
            supplierTableAdapter1.Fill(flowerShopDataSet1.Supplier);
            edit = true;
            this.id = id;
            textBox_name.Text = supplier_name;
            textBox_contactPerson.Text = contact_person;
            textBox_phone.Text = supplier_phone;
            textBox_email.Text = supplier_email;
            textBox_legalAddress.Text = legal_address;
            textBox_physicalAddress.Text = physical_address;
        }
        private void SupplierEditor_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter1.Fill(this.flowerShopDataSet1.Supplier);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                supplierTableAdapter1.UpdateQuery(textBox_name.Text,
                    textBox_contactPerson.Text,
                    textBox_phone.Text,
                    textBox_email.Text,
                    textBox_legalAddress.Text,
                    textBox_physicalAddress.Text,
                    id);
            }
            else
            {
                supplierTableAdapter1.InsertQuery(textBox_name.Text,
                    textBox_contactPerson.Text,
                    textBox_phone.Text,
                    textBox_email.Text,
                    textBox_legalAddress.Text,
                    textBox_physicalAddress.Text);
            }
            Close();
        }
    }
}