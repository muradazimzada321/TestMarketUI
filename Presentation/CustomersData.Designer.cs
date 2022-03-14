
namespace TestMarketUI
{
    partial class CustomersData
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
            this.CustomersTable = new System.Windows.Forms.DataGridView();
            this.backMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A2 Arial AzLat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(524, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müştəri məlumatları";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomersTable
            // 
            this.CustomersTable.AllowUserToAddRows = false;
            this.CustomersTable.AllowUserToDeleteRows = false;
            this.CustomersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomersTable.BackgroundColor = System.Drawing.Color.White;
            this.CustomersTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersTable.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CustomersTable.Location = new System.Drawing.Point(38, 267);
            this.CustomersTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CustomersTable.Name = "CustomersTable";
            this.CustomersTable.ReadOnly = true;
            this.CustomersTable.Size = new System.Drawing.Size(1302, 726);
            this.CustomersTable.TabIndex = 1;
            // 
            // backMenu
            // 
            this.backMenu.ActiveLinkColor = System.Drawing.Color.White;
            this.backMenu.AutoSize = true;
            this.backMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.backMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backMenu.LinkColor = System.Drawing.Color.Lavender;
            this.backMenu.Location = new System.Drawing.Point(32, 51);
            this.backMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(177, 31);
            this.backMenu.TabIndex = 18;
            this.backMenu.TabStop = true;
            this.backMenu.Text = "Menyuya qayıt";
            this.backMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backMenu_LinkClicked);
            // 
            // CustomersData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.CustomersTable);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CustomersData";
            this.Text = "CustomersData";
            this.Load += new System.EventHandler(this.CustomersData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomersTable;
        private System.Windows.Forms.LinkLabel backMenu;
    }
}