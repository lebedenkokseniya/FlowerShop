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
    public partial class SuppliesStatistic : Form
    {
        public SuppliesStatistic()
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
        private void LoadSupplyStatistics(DateTime startDate, DateTime endDate)
        {
            string connectionString = "Server=KSENIYA-PC59;Database=FlowerShop;Trusted_Connection=True;";
            string query = @"
        SELECT 
            sr.supplier_name, 
            COUNT(sl.invoice_number) AS supplies_count
        FROM 
            Supply AS sl
        JOIN 
            Supplier AS sr ON sr.supplier_id = sl.supplier_id
        WHERE 
            sl.supply_date >= @startDate AND sl.supply_date <= @endDate
        GROUP BY 
            sr.supplier_name
        ORDER BY 
            supplies_count DESC;";
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
                    MessageBox.Show("За вибраний період не було поставок.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chart1.Series.Clear();
                    return;
                }
                chart1.Series.Clear();
                Series series = new Series("Кількість поставок")
                {
                    ChartType = SeriesChartType.Bar, 
                    IsValueShownAsLabel = true,
                    BorderWidth = 1
                };
                foreach (DataRow row in dataTable.Rows)
                {
                    string supplierName = row["supplier_name"].ToString();
                    int suppliesCount = Convert.ToInt32(row["supplies_count"]);
                    series.Points.AddXY(supplierName, suppliesCount);
                }
                chart1.Series.Add(series);
                chart1.ChartAreas[0].AxisX.Title = "Постачальник";
                chart1.ChartAreas[0].AxisY.Title = "Кількість поставок";
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
            LoadSupplyStatistics(startDate, endDate);
        }
    }
}