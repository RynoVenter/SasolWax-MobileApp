using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SasolWax.Utilities;
using SasolWax.OneMobileWS_Wax;

namespace SasolWax
{
    public partial class frm_Logon : Form
    {

        private static System.Windows.Forms.Timer _screenStateTimer = new System.Windows.Forms.Timer();

        public frm_Logon()
        {
            
            InitializeComponent();

            pnlChangePass.Visible = false;
            txtUserName.Focus();

            

            _screenStateTimer.Tick += new EventHandler(_screenStateTimer_Tick);
            _screenStateTimer.Interval = 5000;
            _screenStateTimer.Enabled = true;
        }

            private void _screenStateTimer_Tick(object sender, EventArgs e)
            {
                try
                {
                    if (Common.wsWax.Ping())
                    {
                        picSignal.Image = SasolWax.Properties.Resources.ConnectedYes;
                    }
                    else
                    {
                        picSignal.Image = SasolWax.Properties.Resources.ConnectedNo;
                    }

                }
                catch (System.Exception ex)
                {
                    picSignal.Image = SasolWax.Properties.Resources.ConnectedNo;
                }

                lblTime.Text = Convert.ToString(DateTime.Now.TimeOfDay).Substring(0, 5);
            }


        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(txtUserName.Text.Length > 0)
                    txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Logon();
            }
            
        }

        private void cmdLogon_Click(object sender, EventArgs e)
        {
            Logon();
        }


        #region internal

        #endregion

        private void frm_Logon_LostFocus(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void Logon()
        {
            if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
                {
                    Common.appSession.sUser = txtUserName.Text;

                    DataTable dtUser;
                    dtUser = SQLite.GetUser(txtUserName.Text);
                    if (dtUser.Rows.Count == 1)
                    {
                        foreach (DataRow dr in dtUser.Rows)
                        {
                            Common.appSession.sUserIpk = Convert.ToInt32(dr.ItemArray.GetValue(0).ToString());
                            Common.appSession.sUserPass = dr.ItemArray.GetValue(2).ToString();
                            Common.appSession.sUser = dr.ItemArray.GetValue(1).ToString();
                            String[] sPassExp = dr.ItemArray.GetValue(5).ToString().Split('/', ' ');

                            if (sPassExp[0].Length > 2)
                            {
                                Common.appSession.sPassChange = new DateTime(Convert.ToInt32(sPassExp[0].ToString()),
                                                                            Convert.ToInt32(sPassExp[1].ToString()),
                                                                            Convert.ToInt32(sPassExp[2].ToString()));
                            }
                            else
                            {
                                Common.appSession.sPassChange = new DateTime(Convert.ToInt32("20" + sPassExp[0].ToString()),
                                                                            Convert.ToInt32(sPassExp[1].ToString()),
                                                                            Convert.ToInt32(sPassExp[2].ToString()));
                            }
                        }

                        if (Common.appSession.sUserPass.Equals(txtPassword.Text))
                        {
                            //check if password needs to be updated.
                            if (Common.appSession.sPassChange.CompareTo(DateTime.Now) == -1)
                            {
                                pnlChangePass.Visible = true;
                                pnlChangePass.Top = 54;
                                pnlChangePass.Left = 17;
                                txtPassword.Text = "";
                                txtPassword.Focus();
                                txtNewPass.Focus();
                            }
                            else
                            {
                                frm_MainMenu frm_MainMenu = new frm_MainMenu();
                                frm_MainMenu.Show();
                            }

                        }
                        else
                        {
                            //Wrong password
                            MessageBox.Show("The password is incorrect, please retype and try again.");
                            txtPassword.Text = "";
                            txtPassword.Focus();
                        }
                    }
                    else
                    {
                        //Check for new users
                        SQLite.LoadUsers();
                        dtUser = SQLite.GetUser(Common.appSession.sUser);
                        if (dtUser.Rows.Count == 1)
                        {
                            foreach (DataRow dr in dtUser.Rows)
                            {
                                Common.appSession.sUserIpk = Convert.ToInt32(dr.ItemArray.GetValue(0).ToString());
                                Common.appSession.sUserPass = dr.ItemArray.GetValue(2).ToString();
                            }

                            if (Common.appSession.sUserPass.Equals(txtPassword.Text))
                            {

                                frm_MainMenu frm_MainMenu = new frm_MainMenu();
                                frm_MainMenu.Show();
                            }
                            else
                            {
                                MessageBox.Show("The password is incorrect, please retype and try again.");
                                txtPassword.Text = "";
                                txtPassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The User was not found");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Complete the required fields.");
                }
            }
        }

        private static void ValidateUser(String sUser, String sPass)
        {
          
        }

        private void txtNewPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtNewPass.Text.Length > 0)
                    txtConfPass.Focus();
            }
        }

        private void txtConfPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtConfPass.Text.Equals(txtNewPass.Text))
                {
                    try
                    {
                        SQLite.UpdateUser(Convert.ToInt32(Common.appSession.sUserIpk),
                                          Common.appSession.sUser,
                                          txtNewPass.Text);
                    }
                    catch (System.Exception ex)
                    {
                    }

                    pnlChangePass.Visible = false;
                    panel1.Visible = true;
                    panel1.Top = 54;
                    panel1.Left = 17;
                    txtNewPass.Text = "";
                    txtConfPass.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Please ensure that both the new password and confirmation password is the same.", "New Password Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    txtConfPass.Text = "";
                    txtNewPass.Text = "";
                }
            }
        }

        private void btnChangePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtConfPass.Text.Equals(txtNewPass.Text))
            {
                try
                {
                    SQLite.UpdateUser(Convert.ToInt32(Common.appSession.sUserIpk),
                                      Common.appSession.sUser,
                                      txtNewPass.Text);
                }
                catch (System.Exception ex)
                {
                }

                pnlChangePass.Visible = false;
                panel1.Visible = true;
                panel1.Top = 54;
                panel1.Left = 17;
                txtNewPass.Text = "";
                txtConfPass.Text = "";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                MessageBox.Show("Please ensure that both the new password and confirmation password is the same.", "New Password Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                txtConfPass.Text = "";
                txtNewPass.Text = "";
            }
        }
    }
}