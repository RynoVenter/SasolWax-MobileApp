namespace SasolWax
{
    partial class frm_StockList
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblScan = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.pnlBarcodeScan = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBarcodeScan.SuspendLayout();
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
            this.menuItem1.Text = "Menu";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Add Manual";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Back";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.picSignal);
            this.pnlHeader.Controls.Add(this.mode_icon);
            this.pnlHeader.Controls.Add(this.lblHead);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
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
            // lblScan
            // 
            this.lblScan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblScan.Location = new System.Drawing.Point(10, 68);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(173, 20);
            this.lblScan.Text = "Scan Pallet Barcode";
            this.lblScan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 21);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblArea
            // 
            this.lblArea.Location = new System.Drawing.Point(64, 33);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(117, 20);
            this.lblArea.Visible = false;
            // 
            // pnlBarcodeScan
            // 
            this.pnlBarcodeScan.BackColor = System.Drawing.Color.Lavender;
            this.pnlBarcodeScan.Controls.Add(this.txtSearch);
            this.pnlBarcodeScan.Controls.Add(this.lblScan);
            this.pnlBarcodeScan.Location = new System.Drawing.Point(23, 66);
            this.pnlBarcodeScan.Name = "pnlBarcodeScan";
            this.pnlBarcodeScan.Size = new System.Drawing.Size(193, 197);
            // 
            // frm_StockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pnlBarcodeScan);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.pnlHeader);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frm_StockList";
            this.Text = "Stock Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_StockList_Load);
            this.Activated += new System.EventHandler(this.frm_StockList_Activated);
            this.GotFocus += new System.EventHandler(this.frm_StockList_GotFocus);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBarcodeScan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picSignal;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Panel pnlBarcodeScan;
    }
}