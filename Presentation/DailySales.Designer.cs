
namespace TestMarketUI
{
    partial class DailySales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.daTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A2 Arial AzLat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(570, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gündəlik Satışlar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // daTimePicker
            // 
            this.daTimePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.daTimePicker.CustomFormat = "dd-MM-yyyy";
            this.daTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.daTimePicker.Font = new System.Drawing.Font("A2 Arial AzLat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daTimePicker.ImeMode = System.Windows.Forms.ImeMode.On;
            this.daTimePicker.Location = new System.Drawing.Point(408, 190);
            this.daTimePicker.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.daTimePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.daTimePicker.Name = "daTimePicker";
            this.daTimePicker.Size = new System.Drawing.Size(669, 39);
            this.daTimePicker.TabIndex = 1;
            this.daTimePicker.Value = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.daTimePicker.ValueChanged += new System.EventHandler(this.daTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A2 Arial AzLat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(118, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tarixi Seç";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.dataGridView1.Location = new System.Drawing.Point(408, 243);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("A2 Arial AzLat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(669, 490);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.UseWaitCursor = true;
            // 
            // backMenu
            // 
            this.backMenu.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.backMenu.AutoSize = true;
            this.backMenu.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backMenu.LinkColor = System.Drawing.Color.White;
            this.backMenu.Location = new System.Drawing.Point(25, 72);
            this.backMenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(177, 31);
            this.backMenu.TabIndex = 10;
            this.backMenu.TabStop = true;
            this.backMenu.Text = "Menyuya qayıt";
            this.backMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backMenu_LinkClicked);
            // 
            // DailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.daTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DailySales";
            this.RightToLeftLayout = true;
            this.Text = "DailySales";
            this.Load += new System.EventHandler(this.DailySales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DateTimePicker daTimePicker;
        private System.Windows.Forms.LinkLabel backMenu;
    }
}