using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SasolWax.Utilities;

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
        
            lbMenuItems.Items.Clear();

            lbMenuItems.Items.Add("Stock Count");
            lbMenuItems.Items.Add("Manual Stock Count");
            lbMenuItems.Items.Add("Synchronise");
        }

        private void _screenStateTimer_Tick(object sender, EventArgs e)
        {
            
            lblTime.Text = Convert.ToString(DateTime.Now.TimeOfDay).Substring(0, 5);

            if (Convert.ToInt16(lblTime.Text.Substring(0, 2)) < 12)
                lblGreeting.Text = "Good morning " + Common.appSession.sUser;
            else if (Convert.ToInt16(lblTime.Text.Substring(0, 2)) >= 12 && Convert.ToInt16(lblTime.Text.Substring(0, 2)) <= 18)
                lblGreeting.Text = "Good afternoon " + Common.appSession.sUser;
            else
                lblGreeting.Text = "Good evening " + Common.appSession.sUser;

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
        }

        private void lbMenuItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (lbMenuItems.GetItemText(lbMenuItems.SelectedItem).Equals("Stock Count"))
            {
                Common.appSession.sPreferedMethod = "Scan";
                frm_StockList frm_StockList = new frm_StockList();
                frm_StockList.Show();

            }

            if (lbMenuItems.GetItemText(lbMenuItems.SelectedItem).Equals("Manual Stock Count"))
            {
                Common.appSession.sPreferedMethod = "Manual";
                frm_ManualSerialCode frm_ManualSerialCode = new frm_ManualSerialCode();
                frm_ManualSerialCode.Show();
            }

            if (lbMenuItems.GetItemText(lbMenuItems.SelectedItem).Equals("Synchronise"))
            {
                Cursor.Current = Cursors.WaitCursor;
                Cursor tmpCursor = Cursor.Current;

                SQLite.SendInventoryCount();

                Cursor.Current = Cursors.Default;

                Cursor.Current = Cursors.WaitCursor;

                SQLite.GetStockMasterData();
                SQLite.GetServerAreas();
                SQLite.GetServerWareHouses();
                SQLite.GetServerVersion();

                Cursor.Current = Cursors.Default;
            }
        }

        private void frm_MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
 
            if ((e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                // Escape
                this.Close();
            }

        }
    }
}