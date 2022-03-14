using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestMarketUI
{
    public partial class ClearCredit : Form
    {
        public ClearCredit()
        {
            InitializeComponent();
        }

        private void ClearCredit_Load(object sender, EventArgs e)
        {

        }
        readonly SqlConnection sqlCon = new SqlConnection(@"Data Source=ACER-2021;Initial Catalog=MyMarketDB;Integrated Security=True");
        DataTable table = new DataTable();
        void ShowCurrentClientData()
        {
            SqlCommand sqlCommand = new SqlCommand($"Select id as [Müştəri kodu], Fname as AD , Lname as SOYAD, credit as Borc from customers where id = {CustomerIdTB.Text}", sqlCon)
            { CommandType = CommandType.Text };
            try
            {
                sqlCon.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataclientGW.DataSource = table;
                this.table = table;
                sqlCon.Close();
            }
            catch
            {
                MessageBox.Show("Something went wong in ");
            }

        }
     

        private void MakeZero_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerIdTB.Text))
            {
                MessageBox.Show("Məlumatları tam daxil edin");
                return;
            }
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand("MakeCreditZero", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            double cred = Convert.ToDouble(table.Rows[0].ItemArray[3]);
            sqlcmd.Parameters.AddWithValue("@cusid", Convert.ToInt32(CustomerIdTB.Text));
            sqlcmd.ExecuteNonQuery(); 
            sqlCon.Close();
            ShowCurrentClientData();
            //"Datatablename".Rows(“rownumber”).Item(“columnName / columnNumber”)
            MessageBox.Show($"{table.Rows[0].ItemArray[1]} {table.Rows[0].ItemArray[2]}-nin borcundan {cred} manat çıxıldı və borc sıfırlandı.\n" +
                $"Əvvəlki Borc : {cred} \nCari Borc : {table.Rows[0].ItemArray[3]} manat təşkil edir"); 
        }

        private void ResetB_Click(object sender, EventArgs e)
        {
            CustomerIdTB.Clear();
            NewGivenCretidAmTB.Clear();
            dataclientGW.ClearSelection();
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            ShowCurrentClientData();
        }

        private void SaveBut_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerIdTB.Text) || string.IsNullOrWhiteSpace(NewGivenCretidAmTB.Text))
            {
                MessageBox.Show("Məlumatları tam daxil edin");
                return;
            }
            sqlCon.Open();
            string amount = NewGivenCretidAmTB.Text.Replace(".", ",");
            SqlCommand sqlcmd = new SqlCommand("DeleteCredits", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            double cred = Convert.ToDouble(table.Rows[0].ItemArray[3]);
            sqlcmd.Parameters.AddWithValue("@value", Convert.ToDecimal(amount));
            sqlcmd.Parameters.AddWithValue("@cusid", Convert.ToInt32(CustomerIdTB.Text));
            sqlcmd.ExecuteNonQuery();
            sqlCon.Close();
            ShowCurrentClientData();
            //"Datatablename".Rows(“rownumber”).Item(“columnName / columnNumber”)
            MessageBox.Show($"{table.Rows[0].ItemArray[1]} {table.Rows[0].ItemArray[2]}-nin borcundan {NewGivenCretidAmTB.Text} manat çıxıldı.\n" +
                $"Əvvəlki Borc : {cred} \nCari Borc : {table.Rows[0].ItemArray[3]} manat təşkil edir");
            sqlCon.Open();
            sqlcmd = new SqlCommand("InsertNewDailyGivenCredits", sqlCon) { CommandType = CommandType.StoredProcedure };
            sqlcmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(amount));
            sqlcmd.Parameters.AddWithValue("@id", Convert.ToInt32(CustomerIdTB.Text));
            sqlcmd.ExecuteNonQuery();
            sqlCon.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void CustomerIdTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
