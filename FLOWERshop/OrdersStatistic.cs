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
using System.Windows.Forms.DataVisualization.Charting;

namespace FLOWERshop
{
    public partial class OrdersStatistic : Form
    {
        public OrdersStatistic()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] {
            "Останній тиждень",
            "Останній місяць",
            "Останній квартал",
            "Останній рік"
        });
            comboBox1.SelectedIndex = 0;
        }
        private void LoadOrderStatistics(DateTime startDate, DateTime endDate)
        {
            string connectionString = "Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;";
            string query = @"
        SELECT 
            FORMAT(order_date, 'yyyy-MM-dd') AS order_day, 
            SUM(order_price) AS total_orders_price
        FROM 
            [Order] 
        WHERE 
            order_date >= @startDate AND order_date <= @endDate
        GROUP BY 
            FORMAT(order_date, 'yyyy-MM-dd')
        ORDER BY 
            order_day;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("За вибраний період не було замовлень.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chart1.Series.Clear();
                    return;
                }
                chart1.Series.Clear();
                Series series = new Series("Сума замовлень")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true, 
                    BorderWidth = 1
                };
                foreach (DataRow row in dataTable.Rows)
                {
                    string orderDay = row["order_day"].ToString();
                    decimal totalOrdersPrice = Convert.ToDecimal(row["total_orders_price"]);
                    series.Points.AddXY(orderDay, totalOrdersPrice);
                }
                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Дата";
                chart1.ChartAreas[0].AxisY.Title = "Сума замовлень";
                chart1.ChartAreas[0].RecalculateAxesScale();
            }
        }
        private (DateTime startDate, DateTime endDate) GetPeriod()
        {
            DateTime today = DateTime.Today;
            DateTime startDate = today;
            DateTime endDate = today;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Останній тиждень":
                    startDate = today.AddDays(-7);
                    label1.Text = "Статистика за останній тиждень";
                    break;
                case "Останній місяць":
                    startDate = today.AddMonths(-1);
                    label1.Text = "Статистика за останній місяць";
                    break;
                case "Останній квартал":
                    startDate = today.AddMonths(-3);
                    label1.Text = "Статистика за останній квартал";
                    break;
                case "Останній рік":
                    startDate = today.AddYears(-1);
                    label1.Text = "Статистика за останній рік";
                    break;
            }
            return (startDate, endDate);
        }
        private void btnShowStatistics_Click(object sender, EventArgs e)
        {
            var (startDate, endDate) = GetPeriod();
            LoadOrderStatistics(startDate, endDate);
        }
    }
}