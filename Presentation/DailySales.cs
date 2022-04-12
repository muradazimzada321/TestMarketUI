using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;


namespace TestMarketUI
{
    public partial class DailySales : Form
    {
        public DailySales()
        {
            
            InitializeComponent();
            ShowDailyLoansData();
            daTimePicker.Value = DateTime.Today;
        }
        readonly SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True");
        void ShowDailyLoansData()
        {
            SqlCommand sqlCommand = new SqlCommand("GetDailyCredits", sqlCon)
            { CommandType = CommandType.StoredProcedure };

            try
            {
                sqlCommand.Parameters.AddWithValue("@date",daTimePicker.Value);
                sqlCon.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;

                sqlCon.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);

                MessageBox.Show("Nese sehv oldu");
            }
            finally
            {
                sqlCon.Close();
            }

        }
        private void daTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ShowDailyLoansData();
        }
        private void backMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
            dashBoard.FormClosed += (s, a) => this.Close();

        }

        private void DailySales_Load(object sender, EventArgs e)
        {

        }

        private void AllCreditsBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select dbo.GetAllCurrentCreditsAmount()", sqlCon)
            { CommandType = CommandType.Text };

            try
            {
                sqlCon.Open();
                decimal allamount =  sqlCommand.ExecuteScalar() ==DBNull.Value? 0: (decimal)sqlCommand.ExecuteScalar();
                MessageBox.Show($"bütün alınan nisyələrin cəmi : {allamount} ");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wong");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        
        private void todayscreditsButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select dbo.GetAllCreditAmountBasedOnDate(@date)", sqlCon)
            { CommandType = CommandType.Text };

            try
            {
                sqlCon.Open();
                sqlCommand.Parameters.AddWithValue("@date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                decimal allamount =  sqlCommand.ExecuteScalar() ==DBNull.Value? 0: (decimal)sqlCommand.ExecuteScalar();
                MessageBox.Show($"Bügün alınan nisyələrin cəmi : {allamount} ");
            }
            catch (Exception)
            {
                MessageBox.Show("Nəsə səhv getdi");
            }
            finally
            {
                sqlCon.Close();
            }
        }
    }
}
