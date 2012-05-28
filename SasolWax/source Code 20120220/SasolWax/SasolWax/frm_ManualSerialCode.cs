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
    public partial class frm_ManualSerialCode : Form
    {
        public frm_ManualSerialCode()
        {
            InitializeComponent();
            txtSearch.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtSeg3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSeg1.Text.Length > 0 && txtSeg2.Text.Length > 0 && txtSeg3.Text.Length > 0)
                {
                    Common.countSession.sSerialCode =  txtSeg1.Text + "-" + txtSeg2.Text + "-" + txtSeg3.Text;
                    if (txtSearch.Text.Length > 0)
                        Common.countSession.sManualBarcode = txtSearch.Text;

                    this.Close();

                    frm_ManualStockCount frm_ManualStockCount = new frm_ManualStockCount();
                    frm_ManualStockCount.Show();
                }
                else
                {
                    MessageBox.Show("Complete all 3 segments.");
                }
            }
            
        }

        private void txtSearch_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSeg1.Focus();
            }
        }

        private void txtSeg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSeg2.Focus();
            }
        }

        private void txtSeg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtSeg3.Focus();
            }
        }

        private void frm_ManualSerialCode_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                // Escape
                this.Close();
            }
        }

        private void frm_ManualSerialCode_GotFocus(object sender, EventArgs e)
        {
            
            txtSeg1.Text = "";
            txtSeg2.Text = "";
            txtSeg3.Text = "";
            txtSearch.Text = "";

            txtSearch.Focus();
        }

        private void frm_ManualSerialCode_Activated(object sender, EventArgs e)
        {
            txtSeg1.Text = "";
            txtSeg2.Text = "";
            txtSeg3.Text = "";
            txtSearch.Text = "";

            txtSearch.Focus();
        }

        private void frm_ManualSerialCode_Load(object sender, EventArgs e)
        {
            txtSeg1.Text = "";
            txtSeg2.Text = "";
            txtSeg3.Text = "";
            txtSearch.Text = "";

            txtSearch.Focus();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}