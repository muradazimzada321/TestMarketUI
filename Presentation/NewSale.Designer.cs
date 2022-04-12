
namespace TestMarketUI
{
    partial class NewSale
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
            this.components = new System.ComponentModel.Container();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewSaleAmTB = new System.Windows.Forms.TextBox();
            this.SaveB = new System.Windows.Forms.Button();
            this.ResetB = new System.Windows.Forms.Button();
            this.CustomerIdTB = new System.Windows.Forms.TextBox();
            this.SearchBut = new System.Windows.Forms.Button();
            this.dataclientGW = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.backMenu = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataclientGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(114, 145);
            this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(136, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Müştəri kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 304);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Əlavə olunacaq məbləğ";
            // 
            // NewSaleAmTB
            // 
            this.NewSaleAmTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.NewSaleAmTB.Location = new System.Drawing.Point(266, 301);
            this.NewSaleAmTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.NewSaleAmTB.Name = "NewSaleAmTB";
            this.NewSaleAmTB.Size = new System.Drawing.Size(276, 31);
            this.NewSaleAmTB.TabIndex = 2;
            // 
            // SaveB
            // 
            this.SaveB.BackColor = System.Drawing.Color.White;
            this.SaveB.Location = new System.Drawing.Point(80, 410);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(161, 52);
            this.SaveB.TabIndex = 3;
            this.SaveB.Text = "Yadda Saxla";
            this.SaveB.UseVisualStyleBackColor = false;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // ResetB
            // 
            this.ResetB.BackColor = System.Drawing.Color.White;
            this.ResetB.Location = new System.Drawing.Point(372, 410);
            this.ResetB.Name = "ResetB";
            this.ResetB.Size = new System.Drawing.Size(161, 52);
            this.ResetB.TabIndex = 4;
            this.ResetB.Text = "Təmizlə";
            this.ResetB.UseVisualStyleBackColor = false;
            this.ResetB.Click += new System.EventHandler(this.ResetB_Click);
            // 
            // CustomerIdTB
            // 
            this.CustomerIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.CustomerIdTB.Location = new System.Drawing.Point(266, 139);
            this.CustomerIdTB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CustomerIdTB.Name = "CustomerIdTB";
            this.CustomerIdTB.Size = new System.Drawing.Size(276, 31);
            this.CustomerIdTB.TabIndex = 1;
            // 
            // SearchBut
            // 
            this.SearchBut.BackColor = System.Drawing.Color.White;
            this.SearchBut.Location = new System.Drawing.Point(561, 139);
            this.SearchBut.Name = "SearchBut";
            this.SearchBut.Size = new System.Drawing.Size(122, 32);
            this.SearchBut.TabIndex = 5;
            this.SearchBut.Text = "Axtar";
            this.SearchBut.UseVisualStyleBackColor = false;
            this.SearchBut.Click += new System.EventHandler(this.SearchBut_Click);
            // 
            // dataclientGW
            // 
            this.dataclientGW.AllowUserToAddRows = false;
            this.dataclientGW.AllowUserToDeleteRows = false;
            this.dataclientGW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataclientGW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataclientGW.BackgroundColor = System.Drawing.Color.White;
            this.dataclientGW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataclientGW.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataclientGW.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataclientGW.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataclientGW.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataclientGW.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataclientGW.Location = new System.Drawing.Point(756, 189);
            this.dataclientGW.Name = "dataclientGW";
            this.dataclientGW.ReadOnly = true;
            this.dataclientGW.Size = new System.Drawing.Size(602, 110);
            this.dataclientGW.TabIndex = 3;
            this.dataclientGW.VirtualMode = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(751, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Müştərinin məlumatları";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // backMenu
            // 
            this.backMenu.ActiveLinkColor = System.Drawing.Color.White;
            this.backMenu.AutoSize = true;
            this.backMenu.LinkColor = System.Drawing.Color.Blue;
            this.backMenu.Location = new System.Drawing.Point(12, 31);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(152, 25);
            this.backMenu.TabIndex = 8;
            this.backMenu.TabStop = true;
            this.backMenu.Text = "Menyuya qayıt";
            this.backMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backMenu_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(570, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yeni Nisyə";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(TestMarketUI.Program);
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 744);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataclientGW);
            this.Controls.Add(this.SearchBut);
            this.Controls.Add(this.CustomerIdTB);
            this.Controls.Add(this.ResetB);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.NewSaleAmTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "NewSale";
            this.Text = "Satış";
            this.Load += new System.EventHandler(this.NewSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataclientGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewSaleAmTB;
        private System.Windows.Forms.Button SaveB;
        private System.Windows.Forms.Button ResetB;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.TextBox CustomerIdTB;
        private System.Windows.Forms.Button SearchBut;
        private System.Windows.Forms.DataGridView dataclientGW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel backMenu;
        private System.Windows.Forms.Label label3;
    }
}