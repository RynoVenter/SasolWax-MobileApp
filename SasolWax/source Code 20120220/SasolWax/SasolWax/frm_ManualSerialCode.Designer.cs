namespace SasolWax
{
    partial class frm_ManualSerialCode
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
            this.pnlBarcodeScan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeg3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeg2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeg1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblScan = new System.Windows.Forms.Label();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pnlBarcodeScan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarcodeScan
            // 
            this.pnlBarcodeScan.BackColor = System.Drawing.Color.Lavender;
            this.pnlBarcodeScan.Controls.Add(this.panel1);
            this.pnlBarcodeScan.Controls.Add(this.txtSearch);
            this.pnlBarcodeScan.Controls.Add(this.lblScan);
            this.pnlBarcodeScan.Location = new System.Drawing.Point(23, 66);
            this.pnlBarcodeScan.Name = "pnlBarcodeScan";
            this.pnlBarcodeScan.Size = new System.Drawing.Size(193, 215);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSeg3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSeg2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSeg1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 146);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(15, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.Text = "Part 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSeg3
            // 
            this.txtSeg3.Location = new System.Drawing.Point(74, 102);
            this.txtSeg3.Name = "txtSeg3";
            this.txtSeg3.Size = new System.Drawing.Size(103, 21);
            this.txtSeg3.TabIndex = 3;
            this.txtSeg3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeg3_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.Text = "Part 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSeg2
            // 
            this.txtSeg2.Location = new System.Drawing.Point(74, 71);
            this.txtSeg2.Name = "txtSeg2";
            this.txtSeg2.Size = new System.Drawing.Size(103, 21);
            this.txtSeg2.TabIndex = 2;
            this.txtSeg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeg2_KeyPress);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.Text = "Part 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSeg1
            // 
            this.txtSeg1.Location = new System.Drawing.Point(75, 41);
            this.txtSeg1.Name = "txtSeg1";
            this.txtSeg1.Size = new System.Drawing.Size(103, 21);
            this.txtSeg1.TabIndex = 1;
            this.txtSeg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeg1_KeyPress);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(0, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.Text = "Capture Details";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress_1);
            // 
            // lblScan
            // 
            this.lblScan.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblScan.Location = new System.Drawing.Point(10, 8);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(173, 20);
            this.lblScan.Text = "Scan Bag Barcode";
            this.lblScan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picSignal
            // 
            this.picSignal.Location = new System.Drawing.Point(182, 6);
            this.picSignal.Name = "picSignal";
            this.picSignal.Size = new System.Drawing.Size(20, 20);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlHeader.Controls.Add(this.picSignal);
            this.pnlHeader.Controls.Add(this.mode_icon);
            this.pnlHeader.Controls.Add(this.lblHead);
            this.pnlHeader.Controls.Add(this.lblTime);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(240, 30);
            // 
            // mode_icon
            // 
            this.mode_icon.Location = new System.Drawing.Point(171, 3);
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
            this.lblHead.Text = "Manual Serial Code";
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
            this.menuItem2.Text = "";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click_1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Back";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // frm_ManualSerialCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.pnlBarcodeScan);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frm_ManualSerialCode";
            this.Text = "ManualSerialCode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ManualSerialCode_Load);
            this.Activated += new System.EventHandler(this.frm_ManualSerialCode_Activated);
            this.GotFocus += new System.EventHandler(this.frm_ManualSerialCode_GotFocus);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ManualSerialCode_KeyDown);
            this.pnlBarcodeScan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarcodeScan;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.PictureBox picSignal;
        private System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeg1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeg3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeg2;

    }
}