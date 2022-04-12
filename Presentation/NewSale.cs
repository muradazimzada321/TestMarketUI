using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TestMarketUI
{
    public partial class NewSale : Form
    {
        public NewSale()
        {
            InitializeComponent();

        }
        readonly SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True");
        DataTable table = new DataTable();
        void ShowCurrentClientData()
        {
            SqlCommand sqlCommand = new SqlCommand($"Select id as [Müştəri kodu], Fname as AD , Lname as SOYAD ,FatherNAme as [Ata Adı], credit as Borc from customers where id = {CustomerIdTB.Text}", sqlCon)
            {
                CommandType = CommandType.Text
            };
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
                MessageBox.Show("Musteri melumatlarini gostere bilmedik");
            }
        }
        private void ResetB_Click(object sender, EventArgs e)
        {
            CustomerIdTB.Clear();
            NewSaleAmTB.Clear();
            dataclientGW.ClearSelection();
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CustomerIdTB.Text) || string.IsNullOrWhiteSpace(NewSaleAmTB.Text))
            {
                MessageBox.Show("Məlumatları tam daxil edin");
                return;
            }
            ShowCurrentClientData();
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand("UpdateCredit", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            string amount = NewSaleAmTB.Text.Replace(",", ".");
            double cred = Convert.ToDouble(table.Rows[0].ItemArray[4]);
            sqlcmd.Parameters.AddWithValue("@value", Convert.ToDecimal(amount));
            sqlcmd.Parameters.AddWithValue("@cusid", Convert.ToInt32(CustomerIdTB.Text));
            sqlcmd.ExecuteNonQuery();
            sqlCon.Close();
            ShowCurrentClientData();
            //"Datatablename".Rows(“rownumber”).Item(“columnName / columnNumber”)
            MessageBox.Show($"{table.Rows[0].ItemArray[1]} {table.Rows[0].ItemArray[2]} {table.Rows[0].ItemArray[3]} oğlu/qızı-nın borcuna {NewSaleAmTB.Text} manat əlavə olundu.\n" +
                $"Əvvəlki Borc : {cred} \nCari Borc : {table.Rows[0].ItemArray[4]} manat təşkil edir");
            sqlCon.Open();

            sqlcmd = new SqlCommand("InsertCredit", sqlCon)
            {
                CommandType = CommandType.StoredProcedure

            };
            try
            {
                sqlcmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(amount));
                sqlcmd.Parameters.AddWithValue("@id", Convert.ToInt32(CustomerIdTB.Text));
                sqlcmd.ExecuteNonQuery();

            }
            catch(FormatException)
            {
                MessageBox.Show("Məlumatları düzgün daxil edin");

            }
            catch (SqlException)
            {
                MessageBox.Show("Nəsə səhv getdi \n Yenidən sınayın");

            }
            finally
            {
                sqlCon.Close();

            }
         
     
        }
        private void SearchBut_Click(object sender, EventArgs e)
        {
            ShowCurrentClientData();
            if (table.Rows.Count == 0)
            {
                MessageBox.Show($"Müştəri kodu {CustomerIdTB.Text} olan alıcı sistemdə yoxdur ");
                return;
            }
        }
        private void backMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
            dashBoard.FormClosed += (s, a) => this.Close();
        }

        private void NewSale_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
