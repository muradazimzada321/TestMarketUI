
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
            this.backMenu = new System.Windows.Forms.LinkLabel();
            this.CustomersTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxFatherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müştəri məlumatları";
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
            // CustomersTable
            // 
            this.CustomersTable.AllowUserToAddRows = false;
            this.CustomersTable.AllowUserToDeleteRows = false;
            this.CustomersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomersTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomersTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustomersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CustomersTable.Location = new System.Drawing.Point(38, 300);
            this.CustomersTable.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersTable.Name = "CustomersTable";
            this.CustomersTable.Size = new System.Drawing.Size(1193, 377);
            this.CustomersTable.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowId);
            this.panel1.Controls.Add(this.txtbxFatherName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtbxSurname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(746, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 255);
            this.panel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(129, 39);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(258, 39);
            this.txtbxName.TabIndex = 1;
            // 
            // txtbxSurname
            // 
            this.txtbxSurname.Location = new System.Drawing.Point(129, 94);
            this.txtbxSurname.Name = "txtbxSurname";
            this.txtbxSurname.Size = new System.Drawing.Size(258, 39);
            this.txtbxSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad";
            // txtbxFatherName
            // 
            this.txtbxFatherName.Location = new System.Drawing.Point(129, 146);
            this.txtbxFatherName.Name = "txtbxFatherName";
            this.txtbxFatherName.Size = new System.Drawing.Size(258, 39);
            this.txtbxFatherName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ata adı";
            // 
            // ShowId
            // 
            this.ShowId.BackColor = System.Drawing.SystemColors.Window;
            this.ShowId.Location = new System.Drawing.Point(435, 56);
            this.ShowId.Name = "ShowId";
            this.ShowId.Size = new System.Drawing.Size(127, 112);
            this.ShowId.TabIndex = 6;
            this.ShowId.Text = "Müştəri Kodunu Göstər";
            this.ShowId.UseVisualStyleBackColor = false;
            this.ShowId.Click += new System.EventHandler(this.ShowId_Click);
            // 
            // CustomersData
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomersTable);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "CustomersData";
            this.Text = "CustomersData";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel backMenu;
        private System.Windows.Forms.DataGridView CustomersTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbxFatherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowId;
    }
}