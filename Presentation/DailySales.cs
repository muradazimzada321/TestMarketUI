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
            //daTimePicker.Format = DateTimePickerFormat.Custom;
            //daTimePicker.CustomFormat = "dd-MM-yyyy";
        }
        readonly SqlConnection sqlCon = new SqlConnection(@"Data Source=ACER-2021;Initial Catalog=MyMarketDB;Integrated Security=True");
        void ShowDailyLoansData()
        {
            SqlCommand sqlCommand = new SqlCommand("GetDailyLoans", sqlCon)
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

        private void label1_Click(object sender, EventArgs e)
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
