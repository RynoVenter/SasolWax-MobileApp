namespace SasolWax
{
    partial class frm_StockConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockConfirmation));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboSerial = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.cboWarehouse = new System.Windows.Forms.ComboBox();
            this.lblSerial = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboStockCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblBatchCode = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem3);
            this.menuItem1.MenuItems.Add(this.menuItem4);
            resources.ApplyResources(this.menuItem1, "menuItem1");
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem3
            // 
            resources.ApplyResources(this.menuItem3, "menuItem3");
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            resources.ApplyResources(this.menuItem4, "menuItem4");
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem2
            // 
            resources.ApplyResources(this.menuItem2, "menuItem2");
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.picSignal);
            this.pnlHeader.Controls.Add(this.mode_icon);
            this.pnlHeader.Controls.Add(this.lblHead);
            this.pnlHeader.Controls.Add(this.lblTime);
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.Name = "pnlHeader";
            // 
            // picSignal
            // 
            resources.ApplyResources(this.picSignal, "picSignal");
            this.picSignal.Name = "picSignal";
            // 
            // mode_icon
            // 
            resources.ApplyResources(this.mode_icon, "mode_icon");
            this.mode_icon.Name = "mode_icon";
            // 
            // lblHead
            // 
            this.lblHead.BackColor = System.Drawing.Color.MidnightBlue;
            resources.ApplyResources(this.lblHead, "lblHead");
            this.lblHead.ForeColor = System.Drawing.Color.White;
            this.lblHead.Name = "lblHead";
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            // 
            // cboSerial
            // 
            resources.ApplyResources(this.cboSerial, "cboSerial");
            this.cboSerial.Name = "cboSerial";
            this.cboSerial.SelectedIndexChanged += new System.EventHandler(this.cboSerial_SelectedIndexChanged);
            // 
            // lblQty
            // 
            resources.ApplyResources(this.lblQty, "lblQty");
            this.lblQty.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblQty.Name = "lblQty";
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.lblWarehouse, "lblWarehouse");
            this.lblWarehouse.Name = "lblWarehouse";
            // 
            // cboWarehouse
            // 
            resources.ApplyResources(this.cboWarehouse, "cboWarehouse");
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.SelectedIndexChanged += new System.EventHandler(this.cboWarehouse_SelectedIndexChanged);
            // 
            // lblSerial
            // 
            this.lblSerial.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.lblSerial, "lblSerial");
            this.lblSerial.Name = "lblSerial";
            // 
            // txtQty
            // 
            resources.ApplyResources(this.txtQty, "txtQty");
            this.txtQty.Name = "txtQty";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.cboStockCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboSerial);
            this.panel1.Controls.Add(this.cboWarehouse);
            this.panel1.Controls.Add(this.lblWarehouse);
            this.panel1.Controls.Add(this.lblSerial);
            this.panel1.Controls.Add(this.lblQty);
            this.panel1.Controls.Add(this.txtQty);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // cboStockCode
            // 
            resources.ApplyResources(this.cboStockCode, "cboStockCode");
            this.cboStockCode.Name = "cboStockCode";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Name = "label6";
            // 
            // lblStation
            // 
            this.lblStation.BackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.lblStation, "lblStation");
            this.lblStation.Name = "lblStation";
            // 
            // lblBatchCode
            // 
            this.lblBatchCode.BackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.lblBatchCode, "lblBatchCode");
            this.lblBatchCode.Name = "lblBatchCode";
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.lblWeight, "lblWeight");
            this.lblWeight.Name = "lblWeight";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Lavender;
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // frm_StockConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblBatchCode);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frm_StockConfirmation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_StockConfirmation_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picSignal;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox cboSerial;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblWarehouse;
        private System.Windows.Forms.ComboBox cboWarehouse;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblBatchCode;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ComboBox cboStockCode;
        private System.Windows.Forms.Label label2;
    }
}