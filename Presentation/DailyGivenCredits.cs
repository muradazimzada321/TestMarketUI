using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TestMarketUI
{
    public partial class DailyGivenCredits : Form
    {
        public DailyGivenCredits()
        {
            InitializeComponent();
            ShowDailyLoansData();
            daTimePicker.Value = DateTime.Today;

        }
        readonly SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True");
        DataTable table = new DataTable();
        void ShowDailyLoansData()
        {
            SqlCommand sqlCommand = new SqlCommand("GetDailyPayments", sqlCon)
            { CommandType = CommandType.StoredProcedure };

            try
            {
                sqlCommand.Parameters.AddWithValue("@date",daTimePicker.Value);
                sqlCon.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataDailyGivenLoans.DataSource = table;
                this.table = table;

                sqlCon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                MessageBox.Show("Something went wong");
            }

        }
        private void backMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
            dashBoard.FormClosed += (s, a) => this.Close();
        }

        private void daTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ShowDailyLoansData();
        }

        private void DailyGivenCredits_Load(object sender, EventArgs e)
        {

        }

        private void AllPaymentsBtn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select dbo.GetAllCurrentPaymentAmount()", sqlCon)
            { CommandType = CommandType.Text };

            try
            {
                sqlCon.Open();
                decimal allamount = sqlCommand.ExecuteScalar() == DBNull.Value ? 0 : (decimal)sqlCommand.ExecuteScalar();
                MessageBox.Show($"bütün alınan verilen nisyələrin cəmi : {allamount} ");
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

        private void todayspaymentsButton_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("select dbo.GetAllPaymentAmountBasedOnDate(@date)", sqlCon)
            { CommandType = CommandType.Text };

            try
            {
                sqlCon.Open();
                sqlCommand.Parameters.AddWithValue("@date", DateTime.Now.Date.ToString("yyyy-MM-dd"));
                decimal allamount = sqlCommand.ExecuteScalar() == DBNull.Value ? 0 : (decimal)sqlCommand.ExecuteScalar();
                MessageBox.Show($"Bügün veril nisyələrin cəmi : {allamount} ");
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
