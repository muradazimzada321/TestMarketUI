
namespace TestMarketUI
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.GivenCreditsBut = new System.Windows.Forms.Button();
            this.AllCreditsRecBut = new System.Windows.Forms.Button();
            this.RemoveCreditBut = new System.Windows.Forms.Button();
            this.OpenCustDatasBut = new System.Windows.Forms.Button();
            this.NewCustomerBut = new System.Windows.Forms.Button();
            this.NewCreditBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "İşin avand olsun,Kassir";
            // 
            // GivenCreditsBut
            // 
            this.GivenCreditsBut.AutoSize = true;
            this.GivenCreditsBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GivenCreditsBut.BackgroundImage = global::TestMarketUI.Properties.Resources.icons8_bill_96;
            this.GivenCreditsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GivenCreditsBut.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.GivenCreditsBut.Location = new System.Drawing.Point(641, 315);
            this.GivenCreditsBut.Name = "GivenCreditsBut";
            this.GivenCreditsBut.Size = new System.Drawing.Size(219, 174);
            this.GivenCreditsBut.TabIndex = 10;
            this.GivenCreditsBut.Text = "Verilən Borclar";
            this.GivenCreditsBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GivenCreditsBut.UseVisualStyleBackColor = false;
            this.GivenCreditsBut.Click += new System.EventHandler(this.GivenCreditsBut_Click);
            // 
            // AllCreditsRecBut
            // 
            this.AllCreditsRecBut.BackColor = System.Drawing.Color.White;
            this.AllCreditsRecBut.BackgroundImage = global::TestMarketUI.Properties.Resources.icons8_accounting_96;
            this.AllCreditsRecBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AllCreditsRecBut.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.AllCreditsRecBut.Location = new System.Drawing.Point(641, 123);
            this.AllCreditsRecBut.Name = "AllCreditsRecBut";
            this.AllCreditsRecBut.Size = new System.Drawing.Size(219, 174);
            this.AllCreditsRecBut.TabIndex = 9;
            this.AllCreditsRecBut.Text = "Alınan Nisyələr";
            this.AllCreditsRecBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AllCreditsRecBut.UseVisualStyleBackColor = false;
            this.AllCreditsRecBut.Click += new System.EventHandler(this.AllCreditsRecBut_Click);
            // 
            // RemoveCreditBut
            // 
            this.RemoveCreditBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveCreditBut.BackgroundImage = global::TestMarketUI.Properties.Resources.delete__5_;
            this.RemoveCreditBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveCreditBut.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.RemoveCreditBut.Location = new System.Drawing.Point(401, 315);
            this.RemoveCreditBut.Name = "RemoveCreditBut";
            this.RemoveCreditBut.Size = new System.Drawing.Size(219, 174);
            this.RemoveCreditBut.TabIndex = 8;
            this.RemoveCreditBut.Text = "Borcun Silinməsi";
            this.RemoveCreditBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RemoveCreditBut.UseVisualStyleBackColor = false;
            this.RemoveCreditBut.Click += new System.EventHandler(this.RemoveCreditBut_Click);
            // 
            // OpenCustDatasBut
            // 
            this.OpenCustDatasBut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenCustDatasBut.BackgroundImage = global::TestMarketUI.Properties.Resources.icons8_scan_stock_96;
            this.OpenCustDatasBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OpenCustDatasBut.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.OpenCustDatasBut.Location = new System.Drawing.Point(166, 315);
            this.OpenCustDatasBut.Name = "OpenCustDatasBut";
            this.OpenCustDatasBut.Size = new System.Drawing.Size(219, 174);
            this.OpenCustDatasBut.TabIndex = 7;
            this.OpenCustDatasBut.Text = "Müştəri Məlumatları";
            this.OpenCustDatasBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OpenCustDatasBut.UseVisualStyleBackColor = false;
            this.OpenCustDatasBut.Click += new System.EventHandler(this.OpenCustDatasBut_Click);
            // 
            // NewCustomerBut
            // 
            this.NewCustomerBut.BackColor = System.Drawing.Color.White;
            this.NewCustomerBut.BackgroundImage = global::TestMarketUI.Properties.Resources.icons8_client_management_96;
            this.NewCustomerBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewCustomerBut.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.NewCustomerBut.Location = new System.Drawing.Point(401, 123);
            this.NewCustomerBut.Name = "NewCustomerBut";
            this.NewCustomerBut.Size = new System.Drawing.Size(219, 174);
            this.NewCustomerBut.TabIndex = 6;
            this.NewCustomerBut.Text = "Yeni Müştəri";
            this.NewCustomerBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCustomerBut.UseVisualStyleBackColor = false;
            this.NewCustomerBut.Click += new System.EventHandler(this.NewCustomerBut_Click);
            // 
            // NewCreditBut
            // 
            this.NewCreditBut.BackColor = System.Drawing.Color.White;
            this.NewCreditBut.BackgroundImage = global::TestMarketUI.Properties.Resources.icons8_add_96__1_;
            this.NewCreditBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NewCreditBut.Font = new System.Drawing.Font("Times New Roman", 15.75F);
            this.NewCreditBut.Location = new System.Drawing.Point(166, 123);
            this.NewCreditBut.Name = "NewCreditBut";
            this.NewCreditBut.Size = new System.Drawing.Size(219, 174);
            this.NewCreditBut.TabIndex = 5;
            this.NewCreditBut.Text = "Yeni Nisyə";
            this.NewCreditBut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewCreditBut.UseVisualStyleBackColor = false;
            this.NewCreditBut.Click += new System.EventHandler(this.NewCreditBut_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(974, 538);
            this.Controls.Add(this.GivenCreditsBut);
            this.Controls.Add(this.AllCreditsRecBut);
            this.Controls.Add(this.RemoveCreditBut);
            this.Controls.Add(this.OpenCustDatasBut);
            this.Controls.Add(this.NewCustomerBut);
            this.Controls.Add(this.NewCreditBut);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewCreditBut;
        private System.Windows.Forms.Button NewCustomerBut;
        private System.Windows.Forms.Button RemoveCreditBut;
        private System.Windows.Forms.Button OpenCustDatasBut;
        private System.Windows.Forms.Button GivenCreditsBut;
        private System.Windows.Forms.Button AllCreditsRecBut;
    }
}