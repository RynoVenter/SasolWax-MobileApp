namespace SasolWax
{
    partial class frm_Warehouse
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
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbWarehouses = new System.Windows.Forms.ListBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "";
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
            this.pnlHeader.Controls.Add(this.lblTime);
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
            this.lblHead.Text = "Warehouse";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(202, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(41, 13);
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbWarehouses
            // 
            this.lbWarehouses.BackColor = System.Drawing.Color.Lavender;
            this.lbWarehouses.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbWarehouses.Items.Add("Warehouse1");
            this.lbWarehouses.Items.Add("");
            this.lbWarehouses.Items.Add("Warehouse2");
            this.lbWarehouses.Items.Add("");
            this.lbWarehouses.Items.Add("Warehouse3");
            this.lbWarehouses.Items.Add("");
            this.lbWarehouses.Items.Add("Warehouse4");
            this.lbWarehouses.Items.Add("");
            this.lbWarehouses.Items.Add("Warehouse5");
            this.lbWarehouses.Items.Add("");
            this.lbWarehouses.Items.Add("Warehouse6");
            this.lbWarehouses.Items.Add("");
            this.lbWarehouses.Items.Add("Warehouse7");
            this.lbWarehouses.Location = new System.Drawing.Point(14, 47);
            this.lbWarehouses.Name = "lbWarehouses";
            this.lbWarehouses.Size = new System.Drawing.Size(212, 218);
            this.lbWarehouses.TabIndex = 3;
            this.lbWarehouses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbWarehouses_KeyPress);
            // 
            // frm_Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.lbWarehouses);
            this.Controls.Add(this.pnlHeader);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frm_Warehouse";
            this.Text = "frm_Warehouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picSignal;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.ListBox lbWarehouses;
    }
}