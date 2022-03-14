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
        }
        readonly SqlConnection sqlCon = new SqlConnection(@"Data Source=ACER-2021;Initial Catalog=MyMarketDB;Integrated Security=True");
        DataTable table = new DataTable();
        void ShowDailyLoansData()
        {
            SqlCommand sqlCommand = new SqlCommand("GetDailyGivevLoans", sqlCon)
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






        private void DailySales_Load(object sender, EventArgs e)
        {


        }

        private void daTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ShowDailyLoansData();


        }
        private void DailyGivenCredits_Load(object sender, EventArgs e)
        {

        }

        private void backMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }
    }
}
