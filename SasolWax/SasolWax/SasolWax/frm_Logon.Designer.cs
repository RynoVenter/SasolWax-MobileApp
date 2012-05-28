namespace SasolWax
{
    partial class frm_Logon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLogon = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.picSignal = new System.Windows.Forms.PictureBox();
            this.mode_icon = new System.Windows.Forms.PictureBox();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlChangePass = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlChangePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdLogon);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblVersion);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Location = new System.Drawing.Point(17, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 222);
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.lblPassword.Location = new System.Drawing.Point(34, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 20);
            this.lblPassword.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Username:";
            // 
            // cmdLogon
            // 
            this.cmdLogon.Location = new System.Drawing.Point(101, 172);
            this.cmdLogon.Name = "cmdLogon";
            this.cmdLogon.Size = new System.Drawing.Size(72, 20);
            this.cmdLogon.TabIndex = 2;
            this.cmdLogon.Text = "Log on";
            this.cmdLogon.Click += new System.EventHandler(this.cmdLogon_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtPassword.Location = new System.Drawing.Point(34, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(140, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVersion.Location = new System.Drawing.Point(33, 174);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(101, 20);
            this.lblVersion.Text = "v1.0.0.2";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtUserName.Location = new System.Drawing.Point(33, 51);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(140, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
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
            this.lblHead.Text = "Welcome";
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
            // pnlChangePass
            // 
            this.pnlChangePass.BackColor = System.Drawing.Color.Lavender;
            this.pnlChangePass.Controls.Add(this.label2);
            this.pnlChangePass.Controls.Add(this.label3);
            this.pnlChangePass.Controls.Add(this.btnChangePass);
            this.pnlChangePass.Controls.Add(this.txtConfPass);
            this.pnlChangePass.Controls.Add(this.label4);
            this.pnlChangePass.Controls.Add(this.txtNewPass);
            this.pnlChangePass.Location = new System.Drawing.Point(267, 54);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(207, 222);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.Text = "New Password:";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(101, 172);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(72, 20);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            this.btnChangePass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnChangePass_KeyPress);
            // 
            // txtConfPass
            // 
            this.txtConfPass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtConfPass.Location = new System.Drawing.Point(34, 122);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(140, 23);
            this.txtConfPass.TabIndex = 4;
            this.txtConfPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfPass_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.Text = "v1.0.0.2";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.txtNewPass.Location = new System.Drawing.Point(33, 51);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(140, 23);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPass_KeyPress);
            // 
            // frm_Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(498, 294);
            this.Controls.Add(this.pnlChangePass);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frm_Logon";
            this.Text = "frm_Logon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LostFocus += new System.EventHandler(this.frm_Logon_LostFocus);
            this.panel1.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlChangePass.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picSignal;
        public System.Windows.Forms.PictureBox mode_icon;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLogon;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlChangePass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewPass;
    }
}