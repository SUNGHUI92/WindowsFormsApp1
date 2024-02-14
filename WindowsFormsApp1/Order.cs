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
using MetroFramework.Controls;
using System.IO;

namespace SQLTest2
{
    public partial class order : MetroFramework.Forms.MetroForm
    {
		string _server = "localhost"; //DB 서버 주소, 로컬일 경우 localhost
		int _port = 3306; //DB 서버 포트
		string _database = "dbtest"; //DB 이름
		string _id = "root"; //계정 아이디
		string _pw = "ICTmysql07"; //계정 비밀번호
		string _connectionAddress = "";

		public order()
        {
            InitializeComponent();
			//dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
			//dateTimePicker2.CustomFormat = "tt h: mm";
			metroTextBox202.TextChanged += metroTextBox_TextChaned;
			metroTextBox203.TextChanged += metroTextBox_TextChaned;
			metroTextBox204.TextChanged += metroTextBox_TextChaned;
			
			_connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
		}

		private void HighlightItemsWithDate(ListView listView)
		{
			int targetColumnIndex = 10; // 특정 컬럼의 인덱스 (0부터 시작)

			foreach (ListViewItem item in listView.Items)
			{
				if (DateTime.TryParse(item.SubItems[targetColumnIndex].Text, out _))
				{
					// 해당 컬럼의 데이터가 날짜인 경우 아이템의 배경색을 녹색으로 변경
					item.SubItems[targetColumnIndex].BackColor = Color.LightGreen;
				}
			}
		}

		private void metroTextBox_TextChaned(object sender, EventArgs e) //품명 자동완성
		{
			metroTextBox205.Text = $"{metroTextBox202.Text} - {metroTextBox203.Text} {metroTextBox204.Text}";
		}
		
		private void selectTable(string[] columnNames = null, string[] textBoxValues = null /* = "SELECT * FROM product"*/) //데이터 조회
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
				{
					mysql.Open();

					bool allEmpty = true;

					if (textBoxValues != null)
					{
						foreach (string value in textBoxValues)
						{
							if (!string.IsNullOrWhiteSpace(value))
							{
								allEmpty = false;
								break;
							}
						}
					}
					else allEmpty = true;

					string query = "SELECT * FROM product";

					if (!allEmpty)
					{
						query += " WHERE ";

						

						// 각 텍스트박스에서 입력된 값들을 사용하여 동적으로 SQL 조건 생성
						for (int i = 0; i < textBoxValues.Length; i++)
						{
							// 검색어가 비어있지 않은 경우에만 해당 컬럼에 대한 검색 조건 추가
							if (!string.IsNullOrWhiteSpace(textBoxValues[i]))
							{
								query += $"{columnNames[i]} LIKE '%{textBoxValues[i]}%' OR ";
								
							}
						}
						// 마지막 OR 삭제
						query = query.Remove(query.Length - 4);
					}

					string selectQuery = string.Format(query);

					MySqlCommand command = new MySqlCommand(selectQuery, mysql);
					MySqlDataReader table = command.ExecuteReader();

					listView1.Items.Clear();

					while (table.Read())
					{
						ListViewItem item = new ListViewItem();
						item.UseItemStyleForSubItems = false;
						item.Text = table["No"].ToString();
						item.SubItems.Add(table["수주일자"].ToString());
						item.SubItems.Add(table["제조사"].ToString());
						item.SubItems.Add(table["품종"].ToString());
						item.SubItems.Add(table["품목"].ToString());
						item.SubItems.Add(table["규격"].ToString());
						item.SubItems.Add(table["품명"].ToString());
						item.SubItems.Add(table["상품코드"].ToString());
						item.SubItems.Add(table["수량"].ToString());
						item.SubItems.Add(table["판정"].ToString());
						item.SubItems.Add(table["출고일자"].ToString());
						
						listView1.Items.Add(item);
						
					}
					HighlightItemsWithDate(listView1);
					table.Close();
					
				}
				
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void button201_Click(object sender, EventArgs e) //데이터 추가
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
				{

					mysql.Open();
					//string date = DateTime.Now.ToString("F");
					string date = dateTimePicker1.Text;
					//string time = dateTimePicker2.Value.ToString("tt h: mm");
					string insertQuery = "INSERT INTO product (수주일자, 제조사, 품종, 품목, 규격, 품명, 상품코드, 수량, 판정) VALUES ('" + date + "','" + metroTextBox201.Text + "','" + metroTextBox202.Text + "','" + metroTextBox203.Text + "','" + metroTextBox204.Text + "','" + metroTextBox205.Text + "','" + metroTextBox206.Text + "','" + metroTextBox207.Text + "','" + metroTextBox208.Text + "');";
					
					DialogResult result = MessageBox.Show("수주를 추가하시겠습니까?", "수주추가", MessageBoxButtons.YesNo);

					if (result == DialogResult.Yes)
					{
						// 예 선택 시 실행할 동작
						MySqlCommand command = new MySqlCommand(insertQuery, mysql);
						if (command.ExecuteNonQuery() != 1)
							MessageBox.Show("Failed to insert data.");

						metroTextBox201.Text = "";
						metroTextBox202.Text = "";
						metroTextBox203.Text = "";
						metroTextBox204.Text = "";
						metroTextBox205.Text = "";
						metroTextBox206.Text = "";
						metroTextBox207.Text = "";
						metroTextBox208.Text = "";

						selectTable();
					}
					else
					{
						// 아니오 선택 시 실행할 동작
						return;
					}
					
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}
		private void button202_Click(object sender, EventArgs e) //데이터 수정
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
				{
					mysql.Open();
					int pos = listView1.SelectedItems[0].Index;
					int index = Convert.ToInt32(listView1.Items[pos].Text);
					//accounts_table의 특정 id의 name column과 phone column 데이터를 수정합니다.
					string updateQuery = string.Format("UPDATE product SET 제조사 = '{1}', 품종 = '{2}', 품목 = '{3}', 규격 = '{4}', 품명 = '{5}', 상품코드 = '{6}', 수량 = '{7}', 판정 = '{8}' WHERE No={0};", index, 
						metroTextBox201.Text, metroTextBox202.Text, metroTextBox203.Text, metroTextBox204.Text, metroTextBox205.Text, metroTextBox206.Text, metroTextBox207.Text, metroTextBox208.Text);

					MySqlCommand command = new MySqlCommand(updateQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("Failed to delete data.");

					MessageBox.Show("수정하였습니다.");
					selectTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

        private void button203_Click(object sender, EventArgs e) //데이터 삭제
        {
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
				{
					mysql.Open();
					int pos = listView1.SelectedItems[0].Index;
					int index = Convert.ToInt32(listView1.Items[pos].Text);
					string deleteQuery = string.Format("DELETE FROM product WHERE no={0};", index);

					MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("Failed to delete data.");

					selectTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

        private void button207_Click(object sender, EventArgs e) //검색
        {
			MetroTextBox[] textBoxes = { metroTextBox201, metroTextBox202, metroTextBox203, metroTextBox204, metroTextBox205, metroTextBox206, metroTextBox207, metroTextBox208 };

			bool allEmpty = true;
			foreach (MetroTextBox textBox in textBoxes)
			{
				if (!string.IsNullOrEmpty(textBox.Text))
				{
					string[] textBoxValues = {metroTextBox201.Text,metroTextBox202.Text,metroTextBox203.Text, metroTextBox204.Text, metroTextBox205.Text, metroTextBox206.Text, metroTextBox207.Text, metroTextBox208.Text };
					// 나머지 텍스트박스에 대해서도 동일하게 추가

					// 각 컬럼명을 배열로 저장
					string[] columnNames = {"제조사","품종","품목","규격","품명","상품코드","수량","판정", };
					// 나머지 컬럼에 대해서도 동일하게 추가
					allEmpty = false;
					selectTable(columnNames, textBoxValues);
				}

			}
			// 모든 텍스트박스가 비어있는 경우
			if (allEmpty==true) selectTable();
		}


        private void button204_Click(object sender, EventArgs e) //출고 처리
        {
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
				{
					mysql.Open();
					string date = dateTimePicker1.Text;
					//string time = dateTimePicker2.Value.ToString("tt h: mm");
					int pos = listView1.SelectedItems[0].Index;
					int index = Convert.ToInt32(listView1.Items[pos].Text);
					
					string updateQuery = string.Format("UPDATE product SET 출고일자 = '{1}' WHERE No={0};", index, date);
					
					MySqlCommand command = new MySqlCommand(updateQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("Failed to delete data.");


					selectTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}

		private void button208_Click(object sender, EventArgs e) //미출고 처리
		{
			try
			{
				using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
				{
					mysql.Open();
					int pos = listView1.SelectedItems[0].Index;
					int index = Convert.ToInt32(listView1.Items[pos].Text);

					string updateQuery = string.Format("UPDATE product SET 출고일자 = '{1}' WHERE No={0};", index, "");

					MySqlCommand command = new MySqlCommand(updateQuery, mysql);
					if (command.ExecuteNonQuery() != 1)
						MessageBox.Show("Failed to delete data.");


					selectTable();
				}
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.Message);
			}
		}


		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (listView1.SelectedItems.Count != 0)
			{
				int SelectRow = listView1.SelectedItems[0].Index;
				metroTextBox201.Text = listView1.Items[SelectRow].SubItems[2].Text;
				metroTextBox202.Text = listView1.Items[SelectRow].SubItems[3].Text;
				metroTextBox203.Text = listView1.Items[SelectRow].SubItems[4].Text;
				metroTextBox204.Text = listView1.Items[SelectRow].SubItems[5].Text;
				metroTextBox205.Text = listView1.Items[SelectRow].SubItems[6].Text;
				metroTextBox206.Text = listView1.Items[SelectRow].SubItems[7].Text;
				metroTextBox207.Text = listView1.Items[SelectRow].SubItems[8].Text;
				metroTextBox208.Text = listView1.Items[SelectRow].SubItems[9].Text;
			}
		}

        private void button205_Click(object sender, EventArgs e)
        {
			for (int i = 1; i <= 8; i++)
			{
				MetroTextBox metroTextBox = this.Controls.Find("metroTextBox" + i, true).FirstOrDefault() as MetroTextBox;
					
				if (metroTextBox != null)
				{
					metroTextBox.Text = "";
				}
			}
		}

		private void SaveListViewItemsToCSV(ListView listView)
		{
			// SaveFileDialog 생성
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "CSV 파일 (*.csv)|*.csv";
			saveFileDialog.Title = "저장할 파일 선택";
			saveFileDialog.ShowDialog();

			// 사용자가 취소를 누른 경우 함수 종료
			if (saveFileDialog.FileName == "")
				return;

			// 선택된 파일 경로
			string filePath = saveFileDialog.FileName;

			StringBuilder csvContent = new StringBuilder();

			// 헤더 행 추가
			for (int i = 0; i < listView.Columns.Count; i++)
			{
				csvContent.Append(listView.Columns[i].Text);
				if (i < listView.Columns.Count - 1)
					csvContent.Append(",");
			}
			csvContent.AppendLine();

			// 아이템 행 추가
			foreach (ListViewItem item in listView.Items)
			{
				for (int i = 0; i < item.SubItems.Count; i++)
				{
					csvContent.Append(item.SubItems[i].Text);
					if (i < item.SubItems.Count - 1)
						csvContent.Append(",");
				}
				csvContent.AppendLine();
			}

			// CSV 파일로 저장
			File.WriteAllText(filePath, csvContent.ToString());

			MessageBox.Show("CSV 파일이 저장되었습니다.");
		}

		private void button206_Click(object sender, EventArgs e) //파일로 저장
        {
			SaveListViewItemsToCSV(listView1);
		}

     
    }
}
