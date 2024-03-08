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

namespace Evolution_two_1_
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private MySqlConnection connection;
        private string connectionLine = "server=localhost;database=winfromdb;uid=root;password=Kowshik#2003";
        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionLine);
            connection.Open();

            Reffresh();

        }

        private void Reffresh()
        {
            dataTable = new DataTable();
            string query = "SELECT * FROM expense"; // Adjust the query according to your table name and structure
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                // MySqlDataAdapter adapter = new MySqlDataAdapter(command);  
                // adapter.Fill(dataTable);
                
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    dataTable.Load(reader);
                    dataGridView1.DataSource = dataTable;
                    reader.Close();
                }


            }

            List<string> L = new List<string>();
            string query1 = "SELECT Category FROM Categories"; // Adjust the query according to your table name and structure
            MySqlCommand command1 = new MySqlCommand(query1, connection);
            MySqlDataReader reader1 = command1.ExecuteReader();

            while (reader1.Read())
            {
                L.Add(reader1.GetString("Category"));
            }
            reader1.Close();

            comboBox1.DataSource = L;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddClicked(object sender, EventArgs e)
        {
            DateTime T = datePicker1.Value;

            string query = $"INSERT INTO expense(Category,ExpenseId,Amount,Date) VALUES(@Cat,@Id,@Amount,'{T.ToString("yyyy-MM-dd")}')";

            try
            {
              
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Cat", comboBox1.Text);
                    command.Parameters.AddWithValue("@Id", int.Parse(IdBox.Text));
                    command.Parameters.AddWithValue("@Amount", int.Parse(AmountRichTextBox.Text));


                    string date = T.Year + "-" + T.Month + "-" + T.Day;
                    command.Parameters.AddWithValue("@Date", date);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Record Added");
                }
                LimitChecker();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            Reffresh();
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            int Id = int.Parse(IdBox.Text);
            string query = "DELETE FROM expense WHERE ExpenseId=@Id";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Id", int.Parse(IdBox.Text));


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

            Reffresh();

        }

        private void EditClicked(object sender, EventArgs e)
        {
            string query = "UPDATE expense SET Category=@Cat,Amount=@Amount,Date=@Date WHERE ExpenseId=@Id";

            try
            {
              
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@Cat", comboBox1.Text);
                    command.Parameters.AddWithValue("@Id", int.Parse(IdBox.Text));
                    command.Parameters.AddWithValue("@Amount", int.Parse(AmountRichTextBox.Text));
                    DateTime T = datePicker1.Value;
                    string date = T.Year + "-" + T.Month + "-" + T.Day;
                    command.Parameters.AddWithValue("@Date", date);

                    command.ExecuteNonQuery();


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or could not be deleted.");
                    }
                }
                LimitChecker();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

            Reffresh();

        }

        private void TotalExpense(object sender, EventArgs e)
        {
            string query = "SELECT SUM(Amount) FROM expense";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {



                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value) // Check if the result is not null
                    {
                        int totalAmount = Convert.ToInt32(result);

                        MessageBox.Show(totalAmount + "", "TOTAL EXPENSE");
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

            Reffresh();
        }

        private void FilterClicked(object sender, EventArgs e)
        {
            string CategoryName = comboBox1.SelectedItem.ToString();
            DataTable FilterTable = new DataTable();
            FilterTable.Columns.Add("Category", typeof(string));
            FilterTable.Columns.Add("ExpenseId", typeof(string));
            FilterTable.Columns.Add("Amount", typeof(int));
            FilterTable.Columns.Add("Date", typeof(string));



            string query = "SELECT * FROM expense WHERE Category=@Cat";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Cat", CategoryName);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FilterTable.Rows.Add(reader.GetString("Category"), reader.GetUInt32("ExpenseId"),
                            reader.GetUInt32("Amount"), reader.GetDateTime("Date"));

                    }
                }

                dataGridView1.DataSource = FilterTable;

            }
        }

        private void RefreshClicked(object sender, EventArgs e)
        {
            Reffresh();
        }

        private void FilterByDateButtonClicked(object sender, EventArgs e)
        {

            DataTable FilterTable = new DataTable();
            FilterTable.Columns.Add("Category", typeof(string));
            FilterTable.Columns.Add("ExpenseId", typeof(string));
            FilterTable.Columns.Add("Amount", typeof(int));
            FilterTable.Columns.Add("Date", typeof(string));

            string query = "SELECT * FROM expense WHERE Date=@Date";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {

                DateTime T = datePicker1.Value;
                string date = T.Year + "-" + T.Month + "-" + T.Day;
                command.Parameters.AddWithValue("@Date", date);

                // command.ExecuteNonQuery();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FilterTable.Rows.Add(reader.GetString("Category"), reader.GetUInt32("ExpenseId"),
                            reader.GetUInt32("Amount"), reader.GetDateTime("Date"));

                    }
                }

                dataGridView1.DataSource = FilterTable;

            }

        }

        private void MounthRichTextBox_Click(object sender, EventArgs e)
        {

        }

        private void CustomButtonClicked(object sender, EventArgs e)
        {
            DateTime T = datePicker2.Value;
            string from = T.Year + "-" + T.Month + "-" + T.Day;
            DateTime T1 = datePicker3.Value;
            string to = T1.Year + "-" + T1.Month + "-" + T1.Day;

            DataTable FilterTable = new DataTable();
            FilterTable.Columns.Add("Category", typeof(string));
            FilterTable.Columns.Add("ExpenseId", typeof(string));
            FilterTable.Columns.Add("Amount", typeof(int));
            FilterTable.Columns.Add("Date", typeof(string));

            //   string query = "SELECT * FROM expense WHERE Date >= @From AND Date <= @To";
            string query = "SELECT * FROM expense WHERE Date BETWEEN @From AND  @To";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@From", from);
                command.Parameters.AddWithValue("@To", to);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        FilterTable.Rows.Add(reader.GetString("Category"), reader.GetUInt32("ExpenseId"),
                            reader.GetUInt32("Amount"), reader.GetDateTime("Date"));

                    }
                }

                dataGridView1.DataSource = FilterTable;

            }


            //int TotalExpense = 0;
            //for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            //{



            //    int Yr = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString().Substring(6, 4));
            //    int Mnth = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString().Substring(3, 2));
            //    int date = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString().Substring(0, 2));


            //    int frmYr = int.Parse(form.Substring(6, 4));

            //    int frmMnth = int.Parse(form.Substring(3, 2));
            //    int frmdate = int.Parse(form.Substring(0, 2));

            //    int ToYr = int.Parse(to.Substring(6, 4));
            //    int ToMnth = int.Parse(to.Substring(3, 2));
            //    int Todate = int.Parse(to.Substring(0, 2));


            //    if (Yr >= frmYr && Yr <= ToYr && Mnth >= frmMnth && Mnth <= ToMnth && date >= frmdate && date <= Todate)
            //    {
            //        //  if (dataGridView1.Rows[i].Cells[2].Value.ToString().Substring(3, 2).Equals(Month))


            //        FilterTable.Rows.Add(dataGridView1.Rows[i].Cells[0].Value.ToString(),
            //            int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()),
            //            int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()),
            //            dataGridView1.Rows[i].Cells[3].Value.ToString());
            //        TotalExpense += int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());

            //    }





        }
        private int index;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = e.RowIndex;
            index = r;

            DataGridViewRow Row = dataGridView1.Rows[index];
            comboBox1.Text = Row.Cells[0].Value + "";
            IdBox.Text = Row.Cells[1].Value + "";
            AmountRichTextBox.Text = Row.Cells[2].Value + "";

            string date = Row.Cells[3].Value.ToString().Substring(0, 10);

            datePicker1.Value = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
            //DataRichTextBox.Text = date;


        }
        private int CatId = 5;
        private void button3_Click(object sender, EventArgs e)
        {
            string N = (CategoryRichTextBox.Text);

            string query = $"INSERT INTO categories VALUES({CatId},'{N}')";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    command.ExecuteNonQuery();

                    MessageBox.Show("Record Added");
                }
                CatId++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string N = richTextBox1.Text;
            string query = $"DELETE FROM categories WHERE Category='{N}'";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            string query1 = $"DELETE FROM expense WHERE Category='{N}'";
            try
            {
                using (MySqlCommand command = new MySqlCommand(query1, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted SuccesFully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime T = new DateTime(datePicker1.Value.Year,datePicker1.Value.Month,1);
            
            string query = $"insert into Limits values('{T.ToString("yyyy-MM-dd")}' , {int.Parse(AmountRichTextBox.Text)},'{comboBox1.Text}')";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
        }


        private void LimitChecker()
        {
          DateTime T=new DateTime(datePicker1.Value.Year, datePicker1.Value.Month, 1);
            string query = $"select LimitAmount from Limits where Date='{T.ToString("yyyy-MM-dd")}' AND Category='{comboBox1.Text}'";
            string query2= $"select sum(Amount) from expense where month(Date)={T.Month} AND year(Date)={T.Year} AND Category='{comboBox1.Text}'";
            int LimitedAmount=0,CurrentAmount=-1;
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value) LimitedAmount = Convert.ToInt32(result);

                }
                using (MySqlCommand command = new MySqlCommand(query2, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value) CurrentAmount = Convert.ToInt32(result);

                }
                if (CurrentAmount > LimitedAmount) MessageBox.Show("Limit Exceeds","Warning", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = $"select * from Limits";
            string ans = "";
           
            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ans += $"Category : {reader.GetString("Category")}  ,  Date : {reader.GetDateTime("Date").ToString().Substring(0, 10)}  ,  Limit : {reader.GetInt32("LimitAmount")}";
                            ans += "\n";
                        }
                    }

                    MessageBox.Show(ans,"Monthly Limits",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                } 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string query = $"truncate Limits";
            string ans = "";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();

                    //MessageBox.Show(ans, "Monthly Limits", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }

        }
    }
}
