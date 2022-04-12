
namespace TestMarketUI
{
    partial class DailyGivenCredits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataDailyGivenLoans = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.daTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.backMenu = new System.Windows.Forms.LinkLabel();
            this.todayspaymentsButton = new System.Windows.Forms.Button();
            this.AllPaymentsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDailyGivenLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDailyGivenLoans
            // 
            this.dataDailyGivenLoans.AllowUserToAddRows = false;
            this.dataDailyGivenLoans.AllowUserToDeleteRows = false;
            this.dataDailyGivenLoans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataDailyGivenLoans.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDailyGivenLoans.BackgroundColor = System.Drawing.Color.White;
            this.dataDailyGivenLoans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataDailyGivenLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDailyGivenLoans.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataDailyGivenLoans.Location = new System.Drawing.Point(291, 238);
            this.dataDailyGivenLoans.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.dataDailyGivenLoans.Name = "dataDailyGivenLoans";
            this.dataDailyGivenLoans.ReadOnly = true;
            this.dataDailyGivenLoans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDailyGivenLoans.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataDailyGivenLoans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataDailyGivenLoans.ShowCellErrors = false;
            this.dataDailyGivenLoans.ShowCellToolTips = false;
            this.dataDailyGivenLoans.ShowEditingIcon = false;
            this.dataDailyGivenLoans.ShowRowErrors = false;
            this.dataDailyGivenLoans.Size = new System.Drawing.Size(938, 471);
            this.dataDailyGivenLoans.TabIndex = 7;
            this.dataDailyGivenLoans.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(130, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tarixi Seç";
            // 
            // daTimePicker
            // 
            this.daTimePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.daTimePicker.CustomFormat = "dd-MM-yyyy";
            this.daTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.daTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daTimePicker.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.daTimePicker.Location = new System.Drawing.Point(291, 196);
            this.daTimePicker.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.daTimePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.daTimePicker.Name = "daTimePicker";
            this.daTimePicker.Size = new System.Drawing.Size(938, 38);
            this.daTimePicker.TabIndex = 5;
            this.daTimePicker.Value = new System.DateTime(2022, 4, 10, 0, 0, 0, 0);
            this.daTimePicker.ValueChanged += new System.EventHandler(this.daTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(691, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gündəlik Verilən Borclar";
            // 
            // backMenu
            // 
            this.backMenu.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.backMenu.AutoSize = true;
            this.backMenu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backMenu.LinkColor = System.Drawing.Color.White;
            this.backMenu.Location = new System.Drawing.Point(66, 57);
            this.backMenu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(177, 31);
            this.backMenu.TabIndex = 9;
            this.backMenu.TabStop = true;
            this.backMenu.Text = "Menyuya qayıt";
            this.backMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backMenu_LinkClicked);
            // 
            // todayspaymentsButton
            // 
            this.todayspaymentsButton.BackColor = System.Drawing.Color.White;
            this.todayspaymentsButton.Location = new System.Drawing.Point(40, 420);
            this.todayspaymentsButton.Name = "todayspaymentsButton";
            this.todayspaymentsButton.Size = new System.Drawing.Size(152, 123);
            this.todayspaymentsButton.TabIndex = 19;
            this.todayspaymentsButton.Text = "Bügünki satışların məbləği";
            this.todayspaymentsButton.UseVisualStyleBackColor = false;
            this.todayspaymentsButton.Click += new System.EventHandler(this.todayspaymentsButton_Click);
            // 
            // AllPaymentsBtn
            // 
            this.AllPaymentsBtn.BackColor = System.Drawing.Color.White;
            this.AllPaymentsBtn.Location = new System.Drawing.Point(40, 279);
            this.AllPaymentsBtn.Name = "AllPaymentsBtn";
            this.AllPaymentsBtn.Size = new System.Drawing.Size(152, 123);
            this.AllPaymentsBtn.TabIndex = 18;
            this.AllPaymentsBtn.Text = "Bütün  ödənişlərin məbləği";
            this.AllPaymentsBtn.UseVisualStyleBackColor = false;
            this.AllPaymentsBtn.Click += new System.EventHandler(this.AllPaymentsBtn_Click);
            // 
            // DailyGivenCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.todayspaymentsButton);
            this.Controls.Add(this.AllPaymentsBtn);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.dataDailyGivenLoans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DailyGivenCredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyGivenCredits";
            this.Load += new System.EventHandler(this.DailyGivenCredits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDailyGivenLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDailyGivenLoans;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker daTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel backMenu;
        private System.Windows.Forms.Button todayspaymentsButton;
        private System.Windows.Forms.Button AllPaymentsBtn;
    }
}