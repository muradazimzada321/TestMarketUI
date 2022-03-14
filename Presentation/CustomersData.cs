using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace TestMarketUI
{
    public partial class CustomersData : Form
    {
        public CustomersData()
        {
            InitializeComponent();
            GetCustomersData();
        }

        private void CustomersData_Load(object sender, EventArgs e)
        {

        }
        SqlConnection sqlCon = new SqlConnection(@"Data Source=ACER-2021;Initial Catalog=MyMarketDB;Integrated Security=True");

        private void GetCustomersData()
        {

            SqlCommand sqlCommand = new SqlCommand($"select id as N'Müştəri kodu',FName As Ad , LName as Soyad ,  Credit as [  Borc  ],FIN, Telephone as Telefon,   Address   as [ Ünvan] from Customers", sqlCon); ;
            sqlCon.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlCon.Close();
            CustomersTable.DataSource = dt;
        }

        private void backMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
