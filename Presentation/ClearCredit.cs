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

        SqlConnection sqlCon = null;
        DataTable table = new DataTable();
        void ShowCurrentClientData()
        {
            using (sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True"))
            
            {
                SqlCommand sqlCommand = new SqlCommand($"Select id as [Müştəri kodu], Fname as AD , Lname as SOYAD, FatherName as [Ata adı], credit as Borc from customers where id = {CustomerIdTB.Text}", sqlCon)
                { CommandType = CommandType.Text };
                try
                {
                    sqlCon.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    dataGridView1.DataSource = table;
                    this.table = table;

                }
                catch
                {
                    MessageBox.Show("Nese sehv getdi ");
                }
               
            }
           

        }
     

       

        private void ResetB_Click(object sender, EventArgs e)
        {
            CustomerIdTB.Clear();
            NewGivenCretidAmTB.Clear();
            dataGridView1.ClearSelection();
        }

        private void SearchBut_Click(object sender, EventArgs e)
        {
            ShowCurrentClientData();
        }
 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
            dashBoard.FormClosed += (s, a) => this.Close();

        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(CustomerIdTB.Text) || string.IsNullOrWhiteSpace(NewGivenCretidAmTB.Text))
            {
                MessageBox.Show("Məlumatları tam daxil edin");
                return;
            }
            ShowCurrentClientData();
            using (sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True"))
            {
                sqlCon.Open();
                string amount = NewGivenCretidAmTB.Text.Replace(",", ".");
                SqlCommand sqlcmd = new SqlCommand("DeleteCredits", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                try
                {
                    double cred = Convert.ToDouble(table.Rows[0].ItemArray[4]);
                    sqlcmd.Parameters.AddWithValue("@value", Convert.ToDecimal(amount));
                    sqlcmd.Parameters.AddWithValue("@cusid", Convert.ToInt32(CustomerIdTB.Text));
                    sqlcmd.ExecuteNonQuery();
                    sqlCon.Close();
                    ShowCurrentClientData();
                    //"Datatablename".Rows(“rownumber”).Item(“columnName / columnNumber”)
                    MessageBox.Show($"{table.Rows[0].ItemArray[1]} {table.Rows[0].ItemArray[2]} {table.Rows[0].ItemArray[3]} oğlu/qızı-nın borcundan {NewGivenCretidAmTB.Text} manat çıxıldı.\n" +
                        $"Əvvəlki Borc : {cred} \nCari Borc : {table.Rows[0].ItemArray[4]} manat təşkil edir");
                   
                    using (sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True"))
                    {

                        sqlCon.Open();
                        sqlcmd = new SqlCommand("InsertPayment", sqlCon) { CommandType = CommandType.StoredProcedure };
                        sqlcmd.Parameters.AddWithValue("@amount", Convert.ToDouble(amount));
                        sqlcmd.Parameters.AddWithValue("@id", Convert.ToInt32(CustomerIdTB.Text));
                        sqlcmd.ExecuteNonQuery();
                    }



                }
                catch
                {
                    MessageBox.Show("Nə isə səhv getdi");
                }
            }
           
        }

        private void btnMakeZero_Click(object sender, EventArgs e)
        {
            double cred;
            if (string.IsNullOrWhiteSpace(CustomerIdTB.Text))
            {
                MessageBox.Show("Məlumatları tam daxil edin");
                return;
            }
            ShowCurrentClientData();
            using (sqlCon=new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True"))
            {
                sqlCon.Open();
                SqlCommand sqlcmd = new SqlCommand("MakeCreditZero", sqlCon)
                {
                    CommandType = CommandType.StoredProcedure
                };
                  cred = Convert.ToDouble(table.Rows[0].ItemArray[4]);
                sqlcmd.Parameters.AddWithValue("@cusid", Convert.ToInt32(CustomerIdTB.Text));
                sqlcmd.ExecuteNonQuery();

            }
            ShowCurrentClientData();
            //"Datatablename".Rows(“rownumber”).Item(“columnName / columnNumber”)
            MessageBox.Show($"{table.Rows[0].ItemArray[1]} {table.Rows[0].ItemArray[2]}-nin borcundan {cred} manat çıxıldı və borc sıfırlandı.\n" +
                $"Əvvəlki Borc : {cred} \nCari Borc : {table.Rows[0].ItemArray[4]} manat təşkil edir");
        }
           
          
           
           

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            ShowCurrentClientData();
        }

        private void ClearCredit_Load(object sender, EventArgs e)
        {

        }
    }
}
