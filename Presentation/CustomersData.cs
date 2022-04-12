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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True");
        int SearchedCustomerId= 0;   
        private void GetCustomersData()
        {

            SqlCommand sqlCommand = new SqlCommand($"select id as N'Müştəri kodu',FName As Ad , LName as Soyad, FatherName as [Ata Adı  ],  Credit as [  Borc  ],FIN, Telephone as Telefon,   Address   as [ Ünvan] from Customers", sqlCon); 
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
            dashBoard.FormClosed += (s, a) => this.Close();

        }
        bool Isvalid()
        {
            if (string.IsNullOrWhiteSpace(txtbxName.Text))
                return false; 
            if (string.IsNullOrWhiteSpace(txtbxSurname.Text))
                return false;
            if (string.IsNullOrWhiteSpace(txtbxFatherName.Text))
                return false;
            return true;
        }
        private void ShowId_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True"))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlcommand = new SqlCommand("select dbo.GetcustomerIdByNames (@FName,@LName,@FatherName)", sqlConnection);
                        sqlcommand.Parameters.AddWithValue("@FName", txtbxName.Text);
                        sqlcommand.Parameters.AddWithValue("@LName", txtbxSurname.Text);
                        sqlcommand.Parameters.AddWithValue("@FatherName", txtbxFatherName.Text);
                        SearchedCustomerId = (int)sqlcommand.ExecuteScalar();

                    }

                    MessageBox.Show($"Axtarılan müştərinin kodu {SearchedCustomerId}-dir");
                }
                catch
                {
                    MessageBox.Show("Nə isə səhv getdi \n Məlumatları yoxlayın və yenidən cəhd edin");
                }
                

            }
            else
            {
                MessageBox.Show("Bütün məlumatlar yazılmalıdır");
                    return;
            }
        }
    }
}
