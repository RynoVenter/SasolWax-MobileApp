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
    public partial class frm_StockList : Form
    {
        public String sArea = String.Empty;

        public frm_StockList()
        {
            InitializeComponent();
            txtSearch.Text = "";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSearch.Text.Length > 22)
                {
                    Common.countSession.sStockBarcode = txtSearch.Text;

                    
                    if (SQLite.GetStockMaster_Serial(txtSearch.Text.Substring(16, 4), txtSearch.Text.Substring(0, 1)).Rows.Count > 0)
                    {

                        frm_StockConfirmation frm_StockConfirmation = new frm_StockConfirmation();
                        frm_StockConfirmation.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Stock item not found.");

                        frm_ManualSerialCode frm_ManualSerialCode = new frm_ManualSerialCode();
                        frm_ManualSerialCode.Show();

                        this.Close();
                    }
                }
            }
        }

        private void frm_StockList_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Text = "";
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            frm_ManualSerialCode frm_ManualSerialCode = new frm_ManualSerialCode();
            frm_ManualSerialCode.Show();

            this.Close();
        }

        private void frm_StockList_GotFocus(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select(0, txtSearch.Text.Length);
            txtSearch.Text = "";
        }

        private void frm_StockList_Activated(object sender, EventArgs e)
        {
            txtSearch.Text = "";

            txtSearch.Focus();
        }

    }
}