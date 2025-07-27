using FLOWERshop.FlowerShopDataSetTableAdapters;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace FLOWERshop
{
    public partial class Catalogue : Form
    {
        int user;
        public Catalogue()
        {
            InitializeComponent();
        }
        private void Catalogue_Load(object sender, EventArgs e)
        {
            this.plantTableAdapter.Fill(this.flowerShopDataSet.Plant);
            this.userTableAdapter1.Fill(this.flowerShopDataSet.User);
        }
        public Catalogue(int userID) : this()
        {
            plantTableAdapter.Fill(flowerShopDataSet.Plant);
            dataGridView1.DataSource = plantBindingSource;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            user = userID;
            checkedListBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int plantID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            var am = new AmountOfPlant(plantID, user);
            am.ShowDialog();
            plantTableAdapter.Fill(flowerShopDataSet.Plant);
            flowerShopDataSet.AcceptChanges();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void кошикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = orderTableAdapter1.GetDataByExisting(user);
            if (table.Rows.Count > 0)
            {
            var crt = new Cart(user);
            crt.ShowDialog();
            plantTableAdapter.Fill(flowerShopDataSet.Plant);
            flowerShopDataSet.AcceptChanges();
            }
            else
            {
                MessageBox.Show("Кошик порожній!");
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string baseQuery = @"
        SELECT plant_id, plant_name, plant_description, plant_image, plant_price, plant_amount, plant_height, plant_width, plant_weight, category_id, material_id, plant_type_id, flower_color_id
        FROM Plant
        WHERE plant_name LIKE '%' + @search + '%'";

            List<string> conditions = new List<string>();
            List<SqlParameter> parameters = new List<SqlParameter>();

            if (selectedMat.Any())
            {
                conditions.Add("material_id IN (" + string.Join(", ", selectedMat.Select((_, i) => "@materialId" + i)) + ")");
                for (int i = 0; i < selectedMat.Count; i++)
                {
                    parameters.Add(new SqlParameter("@materialId" + i, selectedMat[i]));
                }
            }
            if (selectedPlTp.Any())
            {
                conditions.Add("plant_type_id IN (" + string.Join(", ", selectedPlTp.Select((_, i) => "@plantTypeId" + i)) + ")");
                for (int i = 0; i < selectedPlTp.Count; i++)
                {
                    parameters.Add(new SqlParameter("@plantTypeId" + i, selectedPlTp[i]));
                }
            }
            if (selectedFlCol.Any())
            {
                conditions.Add("flower_color_id IN (" + string.Join(", ", selectedFlCol.Select((_, i) => "@flowerColorId" + i)) + ")");
                for (int i = 0; i < selectedFlCol.Count; i++)
                {
                    parameters.Add(new SqlParameter("@flowerColorId" + i, selectedFlCol[i]));
                }
            }
            if (selectedCat.Any())
            {
                conditions.Add("category_id IN (" + string.Join(", ", selectedCat.Select((_, i) => "@categoryId" + i)) + ")");
                for (int i = 0; i < selectedCat.Count; i++)
                {
                    parameters.Add(new SqlParameter("@categoryId" + i, selectedCat[i]));
                }
            }
            if (conditions.Any())
            {
                baseQuery += " AND " + string.Join(" AND ", conditions);
            }
            using (SqlConnection conn = new SqlConnection("Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;"))
            {
                SqlCommand command = new SqlCommand(baseQuery, conn);
                command.Parameters.AddWithValue("@search", textBox1.Text);
                foreach (var param in parameters)
                {
                    command.Parameters.Add(param);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            selectedMat.Clear();
            selectedPlTp.Clear();
            selectedCat.Clear();
            selectedFlCol.Clear();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBox1.SelectedItem.ToString();
            if (selectedOption == "За ціною (спадання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Descending);
            }
            else if (selectedOption == "За ціною (зростання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
            }
            else if (selectedOption == "В алфавітному порядку (назва)")
            {
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
            }
            else if (selectedOption == "За висотою (зростання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Ascending);
            }
            else if (selectedOption == "За висотою (спадання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Descending);
            }
            else if (selectedOption == "За вагою (зростання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Ascending);
            }
            else if (selectedOption == "За вагою (спадання)")
            {
                dataGridView1.Sort(dataGridView1.Columns[8], ListSortDirection.Descending);
            }
        }
        List<int> selectedMat = new List<int>();
        List<int> selectedPlTp = new List<int>();
        List<int> selectedCat = new List<int>();
        List<int> selectedFlCol = new List<int>();
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Contains("Колір: Червоні"))
            {
                selectedFlCol.Add(1);
            }
            if (checkedListBox1.CheckedItems.Contains("Рожеві"))
            {
                selectedFlCol.Add(2);
            }
            if (checkedListBox1.CheckedItems.Contains("Білі"))
            {
                selectedFlCol.Add(3);
            }
            if (checkedListBox1.CheckedItems.Contains("Жовті"))
            {
                selectedFlCol.Add(4);
            }
            if (checkedListBox1.CheckedItems.Contains("Фіолетові"))
            {
                selectedFlCol.Add(5);
            }
            if (checkedListBox1.CheckedItems.Contains("Помаранчеві"))
            {
                selectedFlCol.Add(6);
            }
            if (checkedListBox1.CheckedItems.Contains("Сині"))
            {
                selectedFlCol.Add(7);
            }
            if (checkedListBox1.CheckedItems.Contains("Не цвіте"))
            {
                selectedFlCol.Add(8);
            }
            if (checkedListBox1.CheckedItems.Contains("Матеріал: Пластик"))
            {
                selectedMat.Add(1);
            }
            if (checkedListBox1.CheckedItems.Contains("Метал"))
            {
                selectedMat.Add(2);
            }
            if (checkedListBox1.CheckedItems.Contains("Фоамін"))
            {
                selectedMat.Add(3);
            }
            if (checkedListBox1.CheckedItems.Contains("Шовк"))
            {
                selectedMat.Add(4);
            }
            if (checkedListBox1.CheckedItems.Contains("Категорія: Штучні квіти в горщиках"))
            {
                selectedCat.Add(1);
            }
            if (checkedListBox1.CheckedItems.Contains("Штучні квіти поштучно"))
            {
                selectedCat.Add(2);
            }
            if (checkedListBox1.CheckedItems.Contains("Букети штучних квітів"))
            {
                selectedCat.Add(3);
            }
            if (checkedListBox1.CheckedItems.Contains("Штучні квіти на стіну"))
            {
                selectedCat.Add(4);
            }
            if (checkedListBox1.CheckedItems.Contains("Квіти для двору"))
            {
                selectedCat.Add(5);
            }
            if (checkedListBox1.CheckedItems.Contains("Квіти підвісні"))
            {
                selectedCat.Add(6);
            }
            if (checkedListBox1.CheckedItems.Contains("Тип рослини: Квітучі"))
            {
                selectedPlTp.Add(1);
            }
            if (checkedListBox1.CheckedItems.Contains("Листяні"))
            {
                selectedPlTp.Add(2);
            }
            if (checkedListBox1.CheckedItems.Contains("Пальми"))
            {
                selectedPlTp.Add(3);
            }
            if (checkedListBox1.CheckedItems.Contains("Плодові"))
            {
                selectedPlTp.Add(4);
            }
            if (checkedListBox1.CheckedItems.Contains("Кактуси"))
            {
                selectedPlTp.Add(5);
            }
            if (checkedListBox1.CheckedItems.Contains("Ліани"))
            {
                selectedPlTp.Add(6);
            }
            checkedListBox1.Visible = false;
            button3.Visible = false;  
            button4.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }
        private void textBox2_Click_1(object sender, EventArgs e)
        {
            selectedMat.Clear();
            selectedPlTp.Clear();
            selectedCat.Clear();
            selectedFlCol.Clear();
            checkedListBox1.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button3.BringToFront();
            button4.BringToFront();
        }
    }
}