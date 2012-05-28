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
                
                Common.appSession.sUser = txtUserName.Text;

                if(txtUserName.Text.Length > 0)
                    txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Cursor tmpCursor = Cursor.Current;

            try
            {
                if ((e.KeyChar == (char)Keys.Enter) && (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0))
                {
                    if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
                    {
                        DataTable dtUser;
                        dtUser = SQLite.GetUser(txtUserName.Text);
                        if (dtUser.Rows.Count == 1)
                        {
                            foreach (DataRow dr in dtUser.Rows)
                            {
                                Common.appSession.sUserIpk = Convert.ToInt32(dr.ItemArray.GetValue(0).ToString());
                                Common.appSession.sUserPass = dr.ItemArray.GetValue(2).ToString();
                            }

                            if (Common.appSession.sUserPass.Equals(txtPassword.Text))
                            {
                                frm_Area frm_Area = new frm_Area();
                                frm_Area.Show();
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
                                    frm_Area frm_Area = new frm_Area();
                                    frm_Area.Show();
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
            catch (System.Exception ex)
            {
                MessageBox.Show("Network connection failed. New users not loaded or user does not exist.");
            }

            Cursor.Current = Cursors.Default;
            
        }

        private void cmdLogon_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (txtUserName.Text.Length > 0 && txtPassword.Text.Length > 0)
                {
                    DataTable dtUser;
                    dtUser = SQLite.GetUser(txtUserName.Text);
                    if (dtUser.Rows.Count == 1)
                    {
                        foreach (DataRow dr in dtUser.Rows)
                        {
                            Common.appSession.sUserIpk = Convert.ToInt32(dr.ItemArray.GetValue(0).ToString());
                            Common.appSession.sUserPass = dr.ItemArray.GetValue(2).ToString();
                        }

                        if (Common.appSession.sUserPass.Equals(txtPassword.Text))
                        {
                            frm_Area frm_Area = new frm_Area();
                            frm_Area.Show();
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
                                frm_Area frm_Area = new frm_Area();
                                frm_Area.Show();
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


        #region internal

        #endregion

        private void frm_Logon_LostFocus(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private static void ValidateUser(String sUser, String sPass)
        {
          
        }
    }
}