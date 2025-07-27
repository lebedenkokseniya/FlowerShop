using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FLOWERshop
{
    public partial class PlantsStatistic : Form
    {
        public PlantsStatistic()
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
        private void LoadTopProducts(DateTime startDate, DateTime endDate)
        {
            string connectionString = "Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;";
            string query = @"
            SELECT TOP 10 
                p.plant_id, 
                p.plant_name,
                SUM(oi.ordered_plants_amount) AS total_sales
            FROM 
                Plant AS p
            JOIN 
                Order_item AS oi ON p.plant_id = oi.plant_id
            JOIN 
                [Order] AS o ON o.order_id = oi.order_id
            WHERE 
                o.order_date >= @startDate AND o.order_date <= @endDate
            GROUP BY 
                p.plant_id, p.plant_name
            ORDER BY 
                total_sales DESC;";
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
                Series series = new Series("Продажі")
                {
                    ChartType = SeriesChartType.Bar, 
                    IsValueShownAsLabel = true
                };
                foreach (DataRow row in dataTable.Rows)
                {
                    string plantName = row["plant_name"].ToString();
                    int totalSales = Convert.ToInt32(row["total_sales"]);
                    series.Points.AddXY(plantName, totalSales);
                }
                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Товари";
                chart1.ChartAreas[0].AxisY.Title = "Кількість продажів";
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
            LoadTopProducts(startDate, endDate);
        }
    }
}