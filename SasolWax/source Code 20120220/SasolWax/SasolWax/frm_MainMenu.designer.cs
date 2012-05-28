namespace SasolWax
{
    partial class frm_MainMenu
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbMenuItems = new System.Windows.Forms.ListBox();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
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
            this.lblHead.Text = "Menu";
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
            // lbMenuItems
            // 
            this.lbMenuItems.BackColor = System.Drawing.Color.Lavender;
            this.lbMenuItems.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbMenuItems.Items.Add("MenuItem1");
            this.lbMenuItems.Items.Add("");
            this.lbMenuItems.Items.Add("MenuItem2");
            this.lbMenuItems.Items.Add("");
            this.lbMenuItems.Items.Add("MenuItem3");
            this.lbMenuItems.Items.Add("");
            this.lbMenuItems.Items.Add("MenuItem4");
            this.lbMenuItems.Items.Add("");
            this.lbMenuItems.Items.Add("MenuItem5");
            this.lbMenuItems.Location = new System.Drawing.Point(13, 71);
            this.lbMenuItems.Name = "lbMenuItems";
            this.lbMenuItems.Size = new System.Drawing.Size(212, 211);
            this.lbMenuItems.TabIndex = 2;
            this.lbMenuItems.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbMenuItems_KeyPress);
            // 
            // lblGreeting
            // 
            this.lblGreeting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblGreeting.Location = new System.Drawing.Point(13, 44);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(212, 20);
            // 
            // frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.lbMenuItems);
            this.Controls.Add(this.pnlHeader);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frm_MainMenu";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_MainMenu_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picSignal;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListBox lbMenuItems;
        private System.Windows.Forms.Label lblGreeting;
    }
}