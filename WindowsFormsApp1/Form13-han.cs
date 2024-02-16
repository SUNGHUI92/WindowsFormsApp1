using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;


namespace WindowsFormsApp1
{
    public partial class Form13 : Form
    {
        string Conn = "Server=localhost:Database=team1;Uid=root;Pwd=0000;";

        public Form13()
        {
            InitializeComponent();
            monthCalendar1.DateSelected += new DateRangeEventHandler(monthCalendar1_DateSelected);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;
            if ((selectedDate.Month == 1 && selectedDate.Day >= 1 && selectedDate.Day <= 30)||
                (selectedDate.Month == 2 && selectedDate.Day >= 1 && selectedDate.Day <= 28)) ;
            {
                LoadDataAndBindChart(selectedDate);
                LoadDataAndBindChart2(selectedDate);
            }

                

        }
        private void Form13_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDataAndBindChart(DateTime selectedDate)
        {
            string connectionString = "server=localhost;user=root;database=team1;port=3306;password=0000";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // 데이터베이스 연결
                connection.Open();

                // 데이터베이스에서 데이터를 가져오는 쿼리
                string query = $"SELECT Time, T_A구역, T_B구역, T_C구역, T_D구역 FROM day_time WHERE Date BETWEEN '{selectedDate.ToString("yyyy-MM-dd")}' AND '{selectedDate.AddDays(0).ToString("yyyy-MM-dd")}';";


                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Chart 컨트롤에 데이터 바인딩3
                chart1.DataSource = dataTable;
                chart1.Series.Clear();

                // 시리즈 생성 및 설정
                Series seriesA = new Series();
                seriesA.Name = "A구역";
                seriesA.ChartType = SeriesChartType.Column;
                seriesA.XValueMember = "Time";
                seriesA.YValueMembers = "T_A구역";

                Series seriesB = new Series();
                seriesB.Name = "B구역";
                seriesB.ChartType = SeriesChartType.Column;
                seriesB.XValueMember = "Time";
                seriesB.YValueMembers = "T_B구역";

                Series seriesC = new Series();
                seriesC.Name = "C구역";
                seriesC.ChartType = SeriesChartType.Column;
                seriesC.XValueMember = "Time";
                seriesC.YValueMembers = "T_C구역";

                Series seriesD = new Series();
                seriesD.Name = "D구역";
                seriesD.ChartType = SeriesChartType.Column;
                seriesD.XValueMember = "Time";
                seriesD.YValueMembers = "T_D구역";

                // 차트에 시리즈 추가
                chart1.Series.Add(seriesA);
                chart1.Series.Add(seriesB);
                chart1.Series.Add(seriesC);
                chart1.Series.Add(seriesD);

                // 차트 설정
                chart1.ChartAreas[0].AxisX.Title = $"Time ({selectedDate.ToShortDateString()})";
                chart1.ChartAreas[0].AxisY.Title = "Temperature (°C)";
                chart1.ChartAreas[0].AxisX.Interval = 2;

                //차트 종류 변경
                seriesA.ChartType = SeriesChartType.Line;
                seriesB.ChartType = SeriesChartType.Line;
                seriesC.ChartType = SeriesChartType.Line;
                seriesD.ChartType = SeriesChartType.Line;

                chart1.ChartAreas[0].AxisY.Minimum = -17; // Y축의 최소값
                chart1.ChartAreas[0].AxisY.Maximum = -8; // Y축의 최대값

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
            finally
            {
                // 연결 종료
                connection.Close();
            }
        }
        private void LoadDataAndBindChart2(DateTime selectedDate)
        {
            string connectionString = "server=localhost;user=root;database=team1;port=3306;password=0000";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // 데이터베이스 연결
                connection.Open();

                // 데이터베이스에서 데이터를 가져오는 쿼리
                string query = $"SELECT Time, KW_A구역, KW_B구역, KW_C구역, KW_D구역 FROM day_time WHERE Date BETWEEN '{selectedDate.ToString("yyyy-MM-dd")}' AND '{selectedDate.AddDays(0).ToString("yyyy-MM-dd")}';";


                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Chart 컨트롤에 데이터 바인딩3
                chart2.DataSource = dataTable;
                chart2.Series.Clear();

                // 시리즈 생성 및 설정
                Series seriesA = new Series();
                seriesA.Name = "A구역";
                seriesA.ChartType = SeriesChartType.Column;
                seriesA.XValueMember = "Time";
                seriesA.YValueMembers = "KW_A구역";

                Series seriesB = new Series();
                seriesB.Name = "B구역";
                seriesB.ChartType = SeriesChartType.Column;
                seriesB.XValueMember = "Time";
                seriesB.YValueMembers = "KW_B구역";

                Series seriesC = new Series();
                seriesC.Name = "C구역";
                seriesC.ChartType = SeriesChartType.Column;
                seriesC.XValueMember = "Time";
                seriesC.YValueMembers = "KW_C구역";

                Series seriesD = new Series();
                seriesD.Name = "D구역";
                seriesD.ChartType = SeriesChartType.Column;
                seriesD.XValueMember = "Time";
                seriesD.YValueMembers = "KW_D구역";

                // 차트에 시리즈 추가
                chart2.Series.Add(seriesA);
                chart2.Series.Add(seriesB);
                chart2.Series.Add(seriesC);
                chart2.Series.Add(seriesD);

                // 차트 설정
                chart2.ChartAreas[0].AxisX.Title = $"Time ({selectedDate.ToShortDateString()})";
                chart2.ChartAreas[0].AxisY.Title = "Watt (kW)";
                chart2.ChartAreas[0].AxisX.Interval = 2;

                //차트 종류 변경
                seriesA.ChartType = SeriesChartType.Line;
                seriesB.ChartType = SeriesChartType.Line;
                seriesC.ChartType = SeriesChartType.Line;
                seriesD.ChartType = SeriesChartType.Line;

                chart2.ChartAreas[0].AxisY.Minimum = 290; // Y축의 최소값
                chart2.ChartAreas[0].AxisY.Maximum = 465; // Y축의 최대값

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
            finally
            {
                // 연결 종료
                connection.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button301_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionStart;

            // 선택한 날짜가 속한 주의 첫날과 마지막 날을 계산합니다.
            DateTime firstDayOfWeek = selectedDate.AddDays(-(int)selectedDate.DayOfWeek);
            DateTime lastDayOfWeek = firstDayOfWeek.AddDays(6);

            // MySQL에서 해당 주의 데이터를 가져오는 쿼리를 작성합니다.
            string query = $"SELECT Date2, T_A구역, T_B구역, T_C구역, T_D구역, KW_A구역, KW_B구역, KW_C구역, KW_D구역 FROM temp WHERE Date BETWEEN '{firstDayOfWeek.ToString("yyyy-MM-dd")}' AND '{lastDayOfWeek.ToString("yyyy-MM-dd")}';";

            LoadDataAndBindChart(chart1, query, "T");
            LoadDataAndBindChart(chart2, query, "KW");
        }

        private void LoadDataAndBindChart(Chart chart, string query, string prefix)
        {
            string connectionString = "server=localhost;user=root;database=team1;port=3306;password=0000";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // 데이터베이스 연결
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Chart에 데이터를 바인딩하여 표시합니다.
                chart.Series.Clear(); // 이전 데이터를 지웁니다.

                foreach (DataColumn column in dataTable.Columns)
                {
                    if (column.ColumnName != "Date2" && column.ColumnName.StartsWith(prefix)) // Date2를 제외한 모든 컬럼을 Series로 추가합니다.
                    {
                        Series series = new Series();
                        series.Name = column.ColumnName;
                        series.ChartType = SeriesChartType.Line;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            series.Points.AddXY(row["Date2"], row[column.ColumnName]);
                        }

                        chart.Series.Add(series);
                    }
                }

                // 차트 설정
                chart.ChartAreas[0].AxisX.Title = "Date";
                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisY.Minimum = prefix == "T" ? -14 : 330; // Y축의 최소값
                chart.ChartAreas[0].AxisY.Maximum = prefix == "T" ? -11 : 415; // Y축의 최대값
                chart.ChartAreas[0].AxisY.Title = prefix == "T" ? "Temperature (°C)" : "Watt (kW)";

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류: " + ex.Message);
            }
            finally
            {
                // 연결 종료
                connection.Close();
            }
        }
    }
    }
