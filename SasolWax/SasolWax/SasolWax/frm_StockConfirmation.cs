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
    public partial class frm_StockConfirmation : Form
    {
        private static String[] sBarcodeSegments;

        public frm_StockConfirmation()
        {
            
            InitializeComponent();
            String sBarcode = Common.countSession.sStockBarcode;

            String sDateTime = String.Empty;
            txtWarehouse.Focus();
            txtWarehouse.Text = "";
            menuItem4.Enabled = false;
            menuItem2.Text = "";
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            if (pnlConfirm.Visible == true && pnlManualInventory.Visible == false)
            {
                ConfirmInventoryCount();
            }
            if (pnlManualInventory.Visible == true && pnlConfirm.Visible == false)
            {
                ConfirmManualInventoryCount();
            }            
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            ManualStockCapture();
            menuItem2.Text = "Confirm";

        }

        private void frm_StockConfirmation_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter) && pnlConfirm.Visible == true)
            {
                // Enter
                ConfirmInventoryCount();
            }

            if ((e.KeyCode == System.Windows.Forms.Keys.Enter) && pnlManualInventory.Visible == true)
            {
                // Enter
                ConfirmManualInventoryCount();

            }

            if ((e.KeyCode == System.Windows.Forms.Keys.Escape  && pnlWarehouse.Visible == true))
            {
                // Escape
                this.Close();
            }
            try
            {
                if ((e.KeyCode == System.Windows.Forms.Keys.Escape && pnlBarcodeScan.Visible == true))
                {
                    // Escape
                    
                        pnlWarehouse.Visible = true;
                        menuItem4.Enabled = false;
                        menuItem2.Text = "";

                        pnlWarehouse.Top = 66;
                        pnlWarehouse.Left = 21;

                        pnlBarcodeScan.SendToBack();
                        pnlBarcodeScan.Visible = false;

                        pnlBarcodeScan.Refresh();

                        txtWarehouse.Focus();
                        txtWarehouse.Select(0, txtSearch.Text.Length);
                        txtWarehouse.Text = "";
                }

                if ((e.KeyCode == System.Windows.Forms.Keys.Escape) && pnlConfirm.Visible == true)
                {
                    // Escape
                    pnlBarcodeScan.Visible = true;
                    txtSearch.Text = "";
                    pnlConfirm.Visible = false;
                    menuItem2.Text = "";
                    pnlConfirm.Refresh();
                    txtSearch.Focus();
                    
                }

                if ((e.KeyCode == System.Windows.Forms.Keys.Escape) && pnlManualInventory.Visible == true)
                {
                    // Escape
                    pnlBarcodeScan.Visible = true;
                    txtSearch.Text = "";
                    pnlManualInventory.Visible = false;
                    menuItem2.Text = "";
                    pnlManualInventory.Refresh();
                    txtSearch.Focus();
                    

                }
               
            }
            catch (System.Exception ex)
            { }

        }

        private void cboWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.countSession.sCurrentWarehouse = cboWarehouse.Text;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            cboManualConfirm.Items.Clear();
            cboWarehouse.Items.Clear();


            
            if (e.KeyChar == (char)Keys.Enter && pnlBarcodeScan.Visible == true)
            {
                
                if (txtSearch.Text.Length > 22)
                {

                    DataTable dtStock_StockCode = new DataTable();
                    DataTable dtStock_Warehouse = new DataTable();
                    DataTable dtWarehouses = new DataTable();

                    Common.countSession.sStockBarcode = txtSearch.Text.ToUpper();

                    sBarcodeSegments = txtSearch.Text.ToUpper().Split('/');

                    if (sBarcodeSegments.Length == 4)
                    {
                        Common.countSession.sSerialCode = sBarcodeSegments[0].ToString();

                        lblBags.Text = sBarcodeSegments.GetValue(1).ToString().ToUpper();
                        lblSerial.Text = sBarcodeSegments.GetValue(0).ToString().ToUpper();
                        lblUnit.Text = sBarcodeSegments.GetValue(3).ToString().ToUpper();
                        lblWeight.Text = sBarcodeSegments.GetValue(2).ToString().ToUpper();
                        //lblPackage.Text = sBarcodeSegments.GetValue(1).ToString().ToUpper();
                        lblStocCode.Text = "";
                        dtStock_StockCode = SQLite.GetStockCodes(Common.appSession.sArea, Common.countSession.sSerialCode);

                        foreach (DataRow dr in dtStock_StockCode.Rows)
                        {
                            lblStocCode.Text = dr.ItemArray.GetValue(0).ToString().ToUpper();
                            break;
                        }

                        pnlConfirm.Top = 42;
                        pnlConfirm.Left = 2;
                        pnlConfirm.Visible = true;
                        menuItem2.Text = "Confirm";
                        pnlBarcodeScan.Visible = false;
                        txtSearch.Text = "";
                        pnlBarcodeScan.Refresh();
                        
                        dtStock_Warehouse = SQLite.GetStockWarehouses(Common.appSession.sArea, Common.countSession.sSerialCode);

                        foreach (DataRow dr in dtStock_Warehouse.Rows)
                        {
                            cboWarehouse.Items.Add(dr.ItemArray.GetValue(0).ToString().ToUpper());
                        }

                        cboWarehouse.Items.Add("-----------");

                        
                        dtWarehouses = SQLite.GetLocalWarehouses(Common.appSession.sArea);

                        foreach (DataRow dr in dtWarehouses.Rows)
                        {
                            cboWarehouse.Items.Add(dr.ItemArray.GetValue(2).ToString().ToUpper());
                        }

                        if (Common.countSession.sCurrentWarehouse.Length > 0)
                        {
                            cboWarehouse.SelectedIndex = cboWarehouse.Items.IndexOf(Common.countSession.sCurrentWarehouse);
                            txtBay.Text = Common.countSession.sBay;
                        }

                        if (cboWarehouse.Text.Length > 0)
                            txtBay.Focus();
                        else
                            cboWarehouse.Focus();
                    }
                    else
                    {
                        ManualStockCapture();
                    }
                }
            }
        }

        private void frm_StockConfirmation_Load(object sender, EventArgs e)
        {
            txtWarehouse.Focus();
            txtWarehouse.Text = "";

            menuItem2.Text = "";
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select(0, txtSearch.Text.Length);
            txtSearch.Text = "";
        }

        private void ConfirmInventoryCount()
        {
            if (cboWarehouse.Focused == false)
            {
                if (lblSerial.Text.Length > 0 && cboWarehouse.SelectedIndex >= 0)
                {
                    if (Common.IsNumeric(lblBags.Text))
                    {
                        var result = MessageBox.Show("Confirm that you counted " + lblBags.Text + " bags of " + lblSerial.Text + " in " + cboWarehouse.Text + "?", "Confirm Count", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            SQLite.InsertInventoryCount(DateTime.Now, Common.appSession.sUserIpk, lblStocCode.Text, txtBay.Text.ToUpper(), cboWarehouse.SelectedItem.ToString(), "", Convert.ToInt32(lblBags.Text), lblSerial.Text, lblWeight.Text, lblUnit.Text, Convert.ToInt32(Common.countSession.sVersion));
                            pnlBarcodeScan.Visible = true;
                            txtSearch.Text = "";
                            pnlConfirm.Visible = false;
                            menuItem2.Text = "";
                            pnlConfirm.Refresh();
                            txtSearch.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure the quantity of bags is numeric.", "Non Numeric Quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                else if (lblSerial.Text.Length == 0 && lblSerial.Text.Length == 0)
                {
                    MessageBox.Show("Please indicate the serial number.", "Missing Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
                else if (cboWarehouse.SelectedIndex < 0)
                {
                    MessageBox.Show("Please indicate the warehouse.", "Missing Warehouse", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }          
        }

        private void ConfirmManualInventoryCount()
        {

            if (txtSerial.Text.Length > 0 && cboManualConfirm.Text.Length > 0)
            {
                if (Common.IsNumeric(txtBags.Text))
                {
                    var result = MessageBox.Show("Confirm that you counted " + txtBags.Text + " bags of " + txtSerial.Text + " in " + cboManualConfirm.Text + "?", "Confirm Count", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (result == DialogResult.Yes)
                    {
                        SQLite.InsertInventoryCount(DateTime.Now, Common.appSession.sUserIpk, "", txtBay.Text,cboManualConfirm.SelectedItem.ToString(), "",Convert.ToInt32(txtBags.Text), txtSerial.Text.ToUpper(), txtWeight.Text, cboUnit.SelectedItem.ToString(),Convert.ToInt32(Common.countSession.sVersion));
                        pnlBarcodeScan.Visible = true;
                        txtSearch.Text = "";
                        pnlManualInventory.Visible = false;
                        menuItem2.Text = "";
                        pnlManualInventory.Refresh();

                    }
                }
                else
                {
                    MessageBox.Show("Please ensure the quantity of bags is numeric.", "Non Numeric Quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            else if (txtSerial.Text.Length == 0 && txtSerial.Text.Length == 0)
            {
                MessageBox.Show("Please indicate the serial number.", "Missing Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
        }

        private void ManualStockCapture()
        {
            DataTable dtWarehouses = new DataTable();
            DataTable dtBUoM = new DataTable();

            pnlBarcodeScan.Visible = false;
            pnlBarcodeScan.Refresh();
            pnlManualInventory.Visible = true;
            menuItem2.Text = "Confirm";
            pnlManualInventory.Top = 42;
            pnlManualInventory.Left = 2;

            dtWarehouses = SQLite.GetLocalWarehouses(Common.appSession.sArea);

            foreach (DataRow dr in dtWarehouses.Rows)
            {
                cboManualConfirm.Items.Add(dr.ItemArray.GetValue(2).ToString().ToUpper());
            }

            if (Common.countSession.sCurrentWarehouse.Length > 0)
            {
                cboManualConfirm.SelectedIndex = cboManualConfirm.Items.IndexOf(Common.countSession.sCurrentWarehouse);
                txtBayManual.Text = Common.countSession.sBay;
            }

            dtBUoM = SQLite.GetBUoM();

            foreach (DataRow dr in dtBUoM.Rows)
            {
                cboUnit.Items.Add(dr.ItemArray.GetValue(0).ToString().ToUpper());
            }

            cboManualConfirm.Focus();
        }

        private void cboWarehouse_GotFocus(object sender, EventArgs e)
        {
           // cboWarehouse.Text = "";
        }

        private void cboManualConfirm_GotFocus(object sender, EventArgs e)
        {
            //cboManualConfirm.Text = "";
        }

        private void cboWarehouse_KeyDown(object sender, KeyEventArgs e)
        {
           /* if ((e.KeyCode == System.Windows.Forms.Keys.Enter) && pnlConfirm.Visible == true)
            {
                txtBay.Focus();
            }*/
        }

        private void cboManualConfirm_KeyDown(object sender, KeyEventArgs e)
        {
          /*  if ((e.KeyCode == System.Windows.Forms.Keys.Enter) && pnlManualInventory.Visible == true)
            {
                txtBayManual.Focus();
            }*/
        }

        private void cboWarehouse_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtWarehouse_GotFocus(object sender, EventArgs e)
        {
            txtWarehouse.Focus();
            txtWarehouse.Select(0, txtSearch.Text.Length);
            txtWarehouse.Text = "";
        }

        private void txtWarehouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && pnlWarehouse.Visible == true)
            {
                String[] sWareHouse;

                sWareHouse = txtWarehouse.Text.ToUpper().Split('/');

                Common.countSession.sCurrentWarehouse = sWareHouse.GetValue(0).ToString();

                if (sWareHouse.Length > 2)
                    Common.countSession.sBay = sWareHouse.GetValue(1).ToString();
                else
                    Common.countSession.sBay = String.Empty;

                if (MessageBox.Show("Please confirm that you will be counting warehouse " + Common.countSession.sCurrentWarehouse + "?", "Confirm Warehouse", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    pnlWarehouse.SendToBack();
                    pnlWarehouse.Visible = false;

                    menuItem4.Enabled = true;

                    pnlBarcodeScan.Top = 66;
                    pnlBarcodeScan.Left = 21;
                    pnlBarcodeScan.Visible = true;

                    pnlWarehouse.Refresh();

                    txtSearch.Focus();
                    txtSearch.Select(0, txtSearch.Text.Length);
                    txtSearch.Text = "";
                }
                else
                {
                    txtWarehouse.Text = "";
                    txtWarehouse.Focus();
                }
            }
        }
    }
}