using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace TestMarketUI
{
    public partial class Registration : Form
    {
        
        SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost;Initial Catalog=MyMarketDB;Integrated Security=True");
        public Registration()
        {
            InitializeComponent();
            
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            GetCustomersData();

        }
        DataTable dt;
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
                return false;
            if (string.IsNullOrEmpty(SNameTB.Text))
                return false;
            if (string.IsNullOrEmpty(TelTB.Text))
                return false;
            if (string.IsNullOrEmpty(txtbxFatherName.Text))
                return false;
            if (string.IsNullOrEmpty(InitCredTB.Text))
                return false;
            //if (string.IsNullOrEmpty(FINTB.Text))
                //return false;
            return true;

        }
        private void GetCustomersData()
        {
            SqlCommand sqlCommand = new SqlCommand($"select id as N'Müştəri kodu',FName As Ad , LName as Soyad ,  Credit as [  Borc  ],FIN, Telephone as Telefon,   Address   as [ Ünvan] from Customers order by id desc", sqlCon); ;
            sqlCon.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
             dt = new DataTable();
            dt.Load(sqlDataReader);
            sqlCon.Close();
            CustomersTable.DataSource = dt;
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
         int customrId = 0;
            SqlCommand sqlcmd;
            if (IsValid())
            {
                 sqlcmd = new SqlCommand("insert into Customers(FName,LName,FIN,Telephone,Credit,Address,FatherName) Values(@FName,@LName, @FIN,@Telephone, @InitialCredit,@Address,@FatherName)", sqlCon)
                {
                    CommandType = CommandType.Text
                };
                SqlCommand sqlCommandGetId = new SqlCommand("Select dbo.GetCustomerID(@telephone)", sqlCon);
                try
                {
                    sqlcmd.Parameters.AddWithValue("@FName", nameTextBox.Text);
                    sqlcmd.Parameters.AddWithValue("@LName", SNameTB.Text);
                    sqlcmd.Parameters.AddWithValue("@FIN", FINTB.Text);
                    sqlcmd.Parameters.AddWithValue("@Telephone", TelTB.Text);
                    sqlcmd.Parameters.AddWithValue("@InitialCredit",Convert.ToDouble( InitCredTB.Text));
                    sqlcmd.Parameters.AddWithValue("@Address", AddresTB.Text);
                    sqlcmd.Parameters.AddWithValue("@FatherName", txtbxFatherName.Text);

                    sqlCon.Open();
                    sqlcmd.ExecuteNonQuery();
                    sqlCon.Close();
                    sqlCon.Open();
                    
                    sqlCommandGetId.Parameters.AddWithValue("@telephone", TelTB.Text);
                    
                    customrId = (int)sqlCommandGetId.ExecuteScalar();
                    MessageBox.Show("Sistəmə yeni müştəri uğurla əlavə edildi.😊");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Məlumatların yazılışında problem var və ya nömrə təkrarlanır \nYenidən yoxlamağa çalışın");
                    return;
                }
                sqlCon.Close();
                GetCustomersData();
            }
            else
            {
                MessageBox.Show("Bütün əsas məlumatlar doldurulmalıdır", "Səhv... ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            sqlcmd = new SqlCommand("InsertCredit", sqlCon)
            {
                CommandType = CommandType.StoredProcedure

            };
            MessageBox.Show($"{nameTextBox.Text } { SNameTB.Text} üçün Müştəri kodu " + customrId.ToString()); 
            string amount = InitCredTB.Text;
            sqlcmd.Parameters.AddWithValue("@amount", Convert.ToDouble(amount));
            sqlcmd.Parameters.AddWithValue("@id", Convert.ToInt32(dt.Rows[0].ItemArray[0]));
            sqlCon.Open();
            sqlcmd.ExecuteNonQuery();
            sqlCon.Close();
        }

        private void ResetBut_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            SNameTB.Clear();
            FINTB.Clear();
            TelTB.Clear();
            InitCredTB.Clear();
            AddresTB.Clear();
            txtbxFatherName.Clear();
        }


        private void backMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
            dashBoard.FormClosed += (s, a) => this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
