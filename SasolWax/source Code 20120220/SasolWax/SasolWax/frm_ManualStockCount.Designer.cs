namespace SasolWax
{
    partial class frm_ManualStockCount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSerialH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblBatchCode = new System.Windows.Forms.Label();
            this.cboSerial = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainMenu2 = new System.Windows.Forms.MainMenu();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem3);
            this.mainMenu1.MenuItems.Add(this.menuItem4);
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.menuItem5);
            this.menuItem3.Text = "Menu";
            // 
            // menuItem5
            // 
            this.menuItem5.Text = "Back";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "Save";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Lavender;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(79, 93);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(144, 16);
            // 
            // lblSerialH
            // 
            this.lblSerialH.BackColor = System.Drawing.Color.White;
            this.lblSerialH.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblSerialH.Location = new System.Drawing.Point(6, 34);
            this.lblSerialH.Name = "lblSerialH";
            this.lblSerialH.Size = new System.Drawing.Size(209, 16);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 21);
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.Text = "Confirm Details";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStation
            // 
            this.lblStation.BackColor = System.Drawing.Color.Lavender;
            this.lblStation.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblStation.Location = new System.Drawing.Point(79, 36);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(144, 16);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.Text = "Weight";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(15, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.Text = "Batch #";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.Lavender;
            this.lblWeight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblWeight.Location = new System.Drawing.Point(79, 74);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(144, 16);
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.Location = new System.Drawing.Point(80, 63);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(133, 22);
            this.cboWarehouse.TabIndex = 16;
            this.cboWarehouse.SelectedIndexChanged += new System.EventHandler(this.cboWarehouse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.Text = "Station #";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblWarehouse.Location = new System.Drawing.Point(5, 66);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(70, 20);
            this.lblWarehouse.Text = "Warehouse";
            this.lblWarehouse.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBatchCode
            // 
            this.lblBatchCode.BackColor = System.Drawing.Color.Lavender;
            this.lblBatchCode.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblBatchCode.Location = new System.Drawing.Point(79, 55);
            this.lblBatchCode.Name = "lblBatchCode";
            this.lblBatchCode.Size = new System.Drawing.Size(144, 16);
            // 
            // cboSerial
            // 
            this.cboSerial.Location = new System.Drawing.Point(80, 90);
            this.cboSerial.Name = "cboSerial";
            this.cboSerial.Size = new System.Drawing.Size(133, 22);
            this.cboSerial.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.txtQty);
            this.panel1.Controls.Add(this.txtWeight);
            this.panel1.Controls.Add(this.lblSerialH);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboSerial);
            this.panel1.Controls.Add(this.cboWarehouse);
            this.panel1.Controls.Add(this.lblWarehouse);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSerial);
            this.panel1.Location = new System.Drawing.Point(10, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 180);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtQty.Location = new System.Drawing.Point(80, 117);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(133, 23);
            this.txtQty.TabIndex = 10;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtWeight.Location = new System.Drawing.Point(80, 145);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(133, 23);
            this.txtWeight.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(5, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.Text = "Bag Weight";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(5, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.Text = "Bag Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSerial
            // 
            this.lblSerial.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSerial.Location = new System.Drawing.Point(5, 93);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(70, 20);
            this.lblSerial.Text = "Stock Code";
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.picSignal);
            this.pnlHeader.Controls.Add(this.mode_icon);
            this.pnlHeader.Controls.Add(this.lblHead);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Location = new System.Drawing.Point(0, 1);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(240, 30);
            // 
            // picSignal
            // 
            this.picSignal.Location = new System.Drawing.Point(182, 6);
            this.picSignal.Name = "picSignal";
            this.picSignal.Size = new System.Drawing.Size(20, 20);
            // 
            // mode_icon
            // 
            this.mode_icon.Location = new System.Drawing.Point(171, 11);
            this.mode_icon.Name = "mode_icon";
            this.mode_icon.Size = new System.Drawing.Size(10, 10);
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblHead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Location = new System.Drawing.Point(2, 2);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(174, 25);
            this.lblHead.Text = "Stock Detail";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(202, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 13);
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Back";
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Save";
            // 
            // mainMenu2
            // 
            this.mainMenu2.MenuItems.Add(this.menuItem1);
            this.mainMenu2.MenuItems.Add(this.menuItem2);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(15, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.Text = "Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_ManualStockCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBatchCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label5);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frm_ManualStockCount";
            this.Text = "Manual Stock Count";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ManualStockCount_KeyDown);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSerialH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.Label lblBatchCode;
        private System.Windows.Forms.ComboBox cboSerial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picSignal;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem menuItem4;
    }
}