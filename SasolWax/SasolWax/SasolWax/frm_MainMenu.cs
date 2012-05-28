using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SasolWax.Utilities;

using System.Data.SqlClient;

namespace SasolWax
{
    public partial class frm_MainMenu : Form
    {
        private static System.Windows.Forms.Timer _screenStateTimer = new System.Windows.Forms.Timer();

        public frm_MainMenu()
        {
            InitializeComponent();

            _screenStateTimer.Tick += new EventHandler(_screenStateTimer_Tick);
            _screenStateTimer.Interval = 5000;
            _screenStateTimer.Enabled = true;

            lblTime.Text = Convert.ToString(DateTime.Now.TimeOfDay.ToString().Substring(0, 5));

            if (Convert.ToInt16(lblTime.Text.Substring(0, 2)) < 12)
                lblGreeting.Text = "Good morning " + Common.appSession.sUser + ".";
            else if (Convert.ToInt16(lblTime.Text.Substring(0, 2)) >= 12 && Convert.ToInt16(lblTime.Text.Substring(0, 2)) <= 18)
                lblGreeting.Text = "Good afternoon " + Common.appSession.sUser + ".";
            else
                lblGreeting.Text = "Good evening " + Common.appSession.sUser + ".";

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
        
            lbMenuItems.Items.Clear();

            lbMenuItems.Items.Add("Stock Count");
            lbMenuItems.Items.Add("Synchronise");

            cboArea.Items.Clear();
            DataSet dsArea = SQLite.GetAreas();

            foreach (DataRow dr in dsArea.Tables[0].Rows)
            {
                cboArea.Items.Add(dr.ItemArray.GetValue(1).ToString().ToUpper());
            }

            cboVersion.Items.Clear();
            DataTable dtVersion = SQLite.GetVersion();

            foreach (DataRow dr in dtVersion.Rows)
            {
                cboVersion.Items.Add(dr.ItemArray.GetValue(3).ToString().ToUpper());
            }

            cboArea.Focus();
        }

        private void _screenStateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = Convert.ToString(DateTime.Now.TimeOfDay.ToString().Substring(0,5));

                if (Convert.ToInt16(lblTime.Text.Substring(0, 2)) < 12)
                    lblGreeting.Text = "Good morning " + Common.appSession.sUser + ".";
                else if (Convert.ToInt16(lblTime.Text.Substring(0, 2)) >= 12 && Convert.ToInt16(lblTime.Text.Substring(0, 2)) <= 18)
                    lblGreeting.Text = "Good afternoon " + Common.appSession.sUser + ".";
                else
                    lblGreeting.Text = "Good evening " + Common.appSession.sUser + ".";

            
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
        }

        private void lbMenuItems_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (lbMenuItems.GetItemText(lbMenuItems.SelectedItem).Equals("Synchronise"))
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Cursor tmpCursor = Cursor.Current;

                    SQLite.SendInventoryCount();

                    Cursor.Current = Cursors.Default;

                    Cursor.Current = Cursors.WaitCursor;

                    SQLite.GetServerStockBaseLine();
                    SQLite.GetServerWareHouses();
                    SQLite.GetServerVersion(cboArea.SelectedItem.ToString());

                    cboVersion.Items.Clear();
                    DataTable dtVersion = SQLite.GetVersion();

                    foreach (DataRow dr in dtVersion.Rows)
                    {
                        cboVersion.Items.Add(dr.ItemArray.GetValue(3).ToString().ToUpper());
                    }

                    cboArea.Focus();

                    SQLite.SyncUser();

                    Cursor.Current = Cursors.Default;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Syncronisation stopped, please try again.", "Syncronisation Stopped",MessageBoxButtons.OK,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button1);
                    Cursor.Current = Cursors.Default;
                }
            }
            
            if (lbMenuItems.GetItemText(lbMenuItems.SelectedItem).Equals("Stock Count") && cboVersion.Text.Length > 0)
            {
                Common.appSession.sPreferedMethod = "Scan";
                frm_StockConfirmation frm_StockConfirmation = new frm_StockConfirmation();
                frm_StockConfirmation.Show();
            }

            if (lbMenuItems.GetItemText(lbMenuItems.SelectedItem).Equals("Stock Count") && cboVersion.Text.Length == 0)
            {
                MessageBox.Show("Please select the team you have been assigned to.", "Team", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                cboVersion.Focus();
            }
         }

        private void frm_MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
 
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                // Escape
                this.Close();
            }

            if(e.KeyCode == System.Windows.Forms.Keys.Down)
            {
                lbMenuItems.Focus();
            }

            if(e.KeyCode == System.Windows.Forms.Keys.Up)
            {
                lbMenuItems.Focus();
            }


        }

        private void lbMenuItems_GotFocus(object sender, EventArgs e)
        {
            if (cboArea.Text.Length == 0)
            {
                cboArea.Focus();
                MessageBox.Show("Please select an area before you continue?.", "Area", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.appSession.sArea = cboArea.GetItemText(cboArea.SelectedItem);
            if(cboArea.Text.Length > 0)
                cboVersion.Focus();
        }

        private void frm_MainMenu_Closing(object sender, CancelEventArgs e)
        {
            this.Dispose();
        }

        private void cboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dtVersion = SQLite.GetVersion(cboVersion.GetItemText(cboVersion.SelectedItem));

            foreach (DataRow dr in dtVersion.Rows)
            {
                Common.countSession.sVersion = dr.ItemArray.GetValue(0).ToString();
                break;
            }

            
            if (cboVersion.Text.Length > 0)
                lbMenuItems.Focus();
        }
    }
}