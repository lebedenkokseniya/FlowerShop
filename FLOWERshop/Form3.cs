using FLOWERshop.FlowerShopDataSetTableAdapters;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
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
using iText.Layout;
using iText.IO.Font.Constants;

namespace FLOWERshop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string table)
        {
            InitializeComponent();
            if (table == "Users")
            {
                dataGridView1.DataSource = userBindingSource;
                label2.Text = "Users";
                button7.Visible = true;
                button1.Visible = true;
            }
            else if (table == "Orders")
            {
                dataGridView1.DataSource = orderBindingSource;
                label2.Text = "Orders";
                button7.Visible = true;
                button1.Visible = false;
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.order_itemTableAdapter.Fill(this.flowerShopDataSet1.Order_item);
            this.userTableAdapter.Fill(this.flowerShopDataSet1.User);
            this.orderTableAdapter.Fill(this.flowerShopDataSet1.Order);
        }
        private bool edit;
        private void button2_Click(object sender, EventArgs e)
        {
            edit = true;
            if (label2.Text == "Users")
            {
                var st = new FlowerShopDataSet.UserDataTable();
                userTableAdapter.FillBy1(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new UserEditor(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    row[2].ToString(),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    Convert.ToDateTime(row[6]),
                    row[7].ToString()
                );
                edt.ShowDialog();
                userTableAdapter.Fill(flowerShopDataSet1.User);
                flowerShopDataSet1.AcceptChanges();
            }
            else if (label2.Text == "Orders")
            {
                var st = new FlowerShopDataSet.OrderDataTable();
                orderTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                object[] row = st.Rows[0].ItemArray;
                var edt = new OrderEditor(
                    Convert.ToInt32(row[0]),
                    Convert.ToDateTime(row[1]),
                    Convert.ToDecimal(row[2]),
                    row[3].ToString(),
                    row[4].ToString(),
                    row[5].ToString(),
                    Convert.ToInt32(row[6])
                );
                edt.ShowDialog();
                orderTableAdapter.Fill(flowerShopDataSet1.Order);
                flowerShopDataSet1.AcceptChanges();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Users")
            {
                userTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                userTableAdapter.Fill(flowerShopDataSet1.User);
                flowerShopDataSet1.AcceptChanges();
            }
            else if (label2.Text == "Orders")
            {
                orderTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                orderTableAdapter.Fill(flowerShopDataSet1.Order);
                flowerShopDataSet1.AcceptChanges();
            }
        }
        private void plantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Plants");
            anth.Show();
            this.Close();
        }
        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Suppliers");
            anth.Show();
            this.Close();
        }
        private void suppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Supplies");
            anth.Show();
            this.Close();
        }
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Categories");
            anth.Show();
            this.Close();
        }
        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Batches");
            anth.Show();
            this.Close();
        }
        private void flowerColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Flower types");
            anth.Show();
            this.Close();
        }
        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Materials");
            anth.Show();
            this.Close();
        }
        private void plantTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var anth = new Form2("Plant types");
            anth.Show();
            this.Close();
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = userBindingSource;
            label2.Text = "Users";
            button7.Visible = true;
            button1.Visible = true;
        }
        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orderBindingSource;
            label2.Text = "Orders";
            button7.Visible = true;
            button1.Visible = false;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && label2.Text == "Orders")
            {
                int orderId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                var orderDetailsForm = new OrderDetails(orderId);
                orderDetailsForm.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Orders")
            {
                var ordersStat = new OrdersStatistic();
                ordersStat.ShowDialog();
            }
            else if (label2.Text == "Users")
            {
                var usersStat = new UsersStatistic();
                usersStat.ShowDialog();
            }
        }
        private void GenerateOrderReport(int userId, string userName)
        {
            string connectionString = "Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;";
            string query = @"
    SELECT 
        o.order_id, 
        o.order_date, 
        o.order_price, 
        o.order_status, 
        o.delivery_address, 
        o.payment_type
    FROM 
        [Order] AS o
    WHERE 
        o.user_id = @userId
    ORDER BY 
        o.order_date;";
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@userId", userId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Немає замовлень від користувача {userName}.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF файли (*.pdf)|*.pdf",
                FileName = $"Звіт_замовлень_{userName}.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fontPath = @"C:\Windows\Fonts\arial.ttf"; 
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

                    using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    using (Document document = new Document(pdf))
                    {
                        document.SetFont(font);
                        document.Add(new Paragraph($"Звіт про замовлення від користувача: {userName}")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(18));
                        document.Add(new Paragraph($"Дата формування: {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}")
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetFontSize(10));
                        Table table = new Table(new float[] { 1, 2, 2, 2, 3, 2 })
                            .UseAllAvailableWidth();
                        table.AddHeaderCell(new Cell().Add(new Paragraph("ID замовлення").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Дата замовлення").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Ціна замовлення").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Статус замовлення").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Адреса доставки").SetFont(font)));
                        table.AddHeaderCell(new Cell().Add(new Paragraph("Тип оплати").SetFont(font)));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(row["order_id"].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(Convert.ToDateTime(row["order_date"]).ToString("dd.MM.yyyy")).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(Convert.ToDecimal(row["order_price"]).ToString("0.00")).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row["order_status"].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row["delivery_address"].ToString()).SetFont(font)));
                            table.AddCell(new Cell().Add(new Paragraph(row["payment_type"].ToString()).SetFont(font)));
                        }
                        document.Add(table);
                        MessageBox.Show($"Звіт збережено за адресою: {saveFileDialog.FileName}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час створення звіту: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Users")
            {
                int selectedUserId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string selectedUserName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                GenerateOrderReport(selectedUserId, selectedUserName);
            }
        }
    }
}