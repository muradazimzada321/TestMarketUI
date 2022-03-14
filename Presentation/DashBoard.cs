using System;
using System.Windows.Forms;

namespace TestMarketUI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }    

        private void NewCreditBut_Click(object sender, EventArgs e)
        {
            NewSale newSale = new NewSale(); 
            this.Hide();
            newSale.Show();
            newSale.FormClosed += (s, a) => this.Close(); 
           
            
        }

        private void NewCustomerBut_Click(object sender, EventArgs e)
        {           
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
            registration.FormClosed += (s, a) => this.Close();

        }

        private void OpenCustDatasBut_Click(object sender, EventArgs e)
        {
            CustomersData customersData = new CustomersData();
            customersData.Show();
            customersData.FormClosed += (s, a) => this.Close();

            this.Hide();
        }

        private void RemoveCreditBut_Click(object sender, EventArgs e)
        {
            ClearCredit clearCredit = new ClearCredit();
            clearCredit.Show();
            this.Hide();
            clearCredit.FormClosed += (s, a) => this.Close();

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void AllCreditsRecBut_Click(object sender, EventArgs e)
        {
            DailySales dailySales = new DailySales();
            dailySales.Show();
            this.Hide();
            dailySales.FormClosed += (s, a) => this.Close();

        }

        private void GivenCreditsBut_Click(object sender, EventArgs e)
        {
            DailyGivenCredits credits = new DailyGivenCredits();
            credits.Show();
            this.Hide();
            credits.FormClosed += (s, a) => this.Close();

        }
    }
}
