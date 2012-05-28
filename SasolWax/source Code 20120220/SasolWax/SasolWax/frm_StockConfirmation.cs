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
        public frm_StockConfirmation()
        {
        
            InitializeComponent();
            String sBarcode = Common.countSession.sStockBarcode;

            String sDateTime = String.Empty;
            txtQty.Focus();
           
            //populate the screen with the relevant data according to the barcode scanned

            if (sBarcode.Length > 22)
            {
                lblStation.Text = sBarcode.Substring(0, 1);
                sDateTime = sBarcode.Substring(1, 6);
                sDateTime += sBarcode.Substring(7, 4);

                lblDate.Text = sDateTime.Substring(0, 2) + "/" + sDateTime.Substring(2, 2) + "/" + sDateTime.Substring(4, 2) + " " +
                                sDateTime.Substring(6, 2) + ":" + sDateTime.Substring(8, 2);

                //txtScanTime.Text = sBarcode.Substring(7, 4);

                //txtBag.Text = sBarcode.Substring(11, 4);

                lblBatchCode.Text = sBarcode.Substring(16, 4);
                Common.countSession.sBatchCode = lblBatchCode.Text;

                lblWeight.Text = sBarcode.Substring(20, 2);

                //txtType.Text = sBarcode.Substring(22, 1);
            }
            //Setup warehouse combo box
            
            //Get StockMasterData
            //Then Build lblSerialH and lblWarehouseH
            DataTable dtStockMaster_Serial = new DataTable();
            DataTable dtStockMaster_StockCode = new DataTable();
            DataTable dtStockMaster_Warehouse = new DataTable();
            bool blnAddToLbl = true;

            dtStockMaster_Serial = SQLite.GetStockMaster_Serial(Common.countSession.sBatchCode, lblStation.Text);

            foreach (DataRow dr in dtStockMaster_Serial.Rows)
            {
                cboSerial.Items.Add(dr.ItemArray.GetValue(0));
                
                if (blnAddToLbl)
                {
                    //lblSerialH.Text = "Serial : " + dr.ItemArray.GetValue(0);
                    cboSerial.SelectedIndex = 0;
                    blnAddToLbl = false;
                    
                }
            }

            blnAddToLbl = true;

            dtStockMaster_StockCode = SQLite.GetStockMaster_StockCode(Common.countSession.sBatchCode, lblStation.Text);

            foreach (DataRow dr in dtStockMaster_StockCode.Rows)
            {
                cboStockCode.Items.Add(dr.ItemArray.GetValue(0));

                if (blnAddToLbl)
                {
                    //lblSerialH.Text = "Serial : " + dr.ItemArray.GetValue(0);
                    cboStockCode.SelectedIndex = 0;
                    blnAddToLbl = false;
                }
            }

            blnAddToLbl = true;

            dtStockMaster_Warehouse = SQLite.GetStockMaster_Warehouse(Common.countSession.sBatchCode, lblStation.Text);

            
            foreach (DataRow dr in dtStockMaster_Warehouse.Rows)
            {
                
                cboWarehouse.Items.Add(dr.ItemArray.GetValue(0));
                
            }
             
            cboWarehouse.Items.Add("-----------");

            DataTable dtWarehouses = new DataTable();
            dtWarehouses = SQLite.GetLocalWarehouses(Common.appSession.sArea);
            foreach (DataRow dr in dtWarehouses.Rows)
            {
                cboWarehouse.Items.Add(dr.ItemArray.GetValue(2));
            }

            if (Common.countSession.sCurrentWarehouse.Length > 0)
            {
                cboWarehouse.SelectedIndex = cboWarehouse.Items.IndexOf(Common.countSession.sCurrentWarehouse);
            }
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Confirm that you counted " + txtQty.Text + " bags of " + cboSerial.Text + " in " + cboWarehouse.Text + "?", "Confirm Count", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (cboSerial.Text.Length > 0 && cboWarehouse.Text.Length > 0)
            {
                if (Common.IsNumeric(txtQty.Text))
                {
                    if (result == DialogResult.Yes)
                    {
                        SQLite.InsertInventoryCount(DateTime.Now, Common.appSession.sUserIpk, cboStockCode.Text, cboWarehouse.Text, Convert.ToInt16(txtQty.Text), cboSerial.Text, Common.countSession.sBatchCode, lblWeight.Text, lblStation.Text, 1);
                        this.Close();
                        frm_StockList frm_StockList = new frm_StockList();
                        frm_StockList.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure the quantity of bags is numeric.", "Non Numeric Quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

                }
            }
            else if (cboSerial.Text.Length == 0 && cboSerial.Text.Length == 0)
                MessageBox.Show("Please indicate all relevant fields.", "Missing Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            frm_ManualSerialCode frm_ManualSerialCode = new frm_ManualSerialCode();
            frm_ManualSerialCode.Show();
            
            this.Close();
        }

        private void frm_StockConfirmation_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                
                // Enter
                if (cboSerial.Text.Length > 0 && cboWarehouse.Text.Length > 0)
                {
                    if (Common.IsNumeric(txtQty.Text))
                    {
                        var result = MessageBox.Show("Confirm that you counted " + txtQty.Text + " bags of " + cboSerial.Text + " in " + cboWarehouse.Text + "?", "Confirm Count", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.Yes)
                        {
                            SQLite.InsertInventoryCount(DateTime.Now, Common.appSession.sUserIpk, cboStockCode.Text, cboWarehouse.Text, Convert.ToInt16(txtQty.Text), cboSerial.Text, Common.countSession.sBatchCode, lblWeight.Text, lblStation.Text, 1);
                            this.Close();
                            frm_StockList frm_StockList = new frm_StockList();
                            frm_StockList.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure the quantity of bags is numeric.", "Non Numeric Quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }
                else if (cboSerial.Text.Length == 0 && cboSerial.Text.Length == 0)
                {
                    MessageBox.Show("Please indicate the serial number.", "Missing Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }

                
            }

            if ((e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                // Escape
                this.Close();
            }

        }

        private void cboWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.countSession.sCurrentWarehouse = cboWarehouse.Text;
        }

        private void cboSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iCboLen = cboSerial.Text.Length;
            String sLastBrace = cboSerial.Text.Substring(iCboLen - 1, 1);
            if (sLastBrace.Equals(")") && iCboLen > 0)
            {
                txtQty.Text = cboSerial.Text.Substring(iCboLen - 3,2);
            }
        }
    }
}