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
    public partial class frm_ManualStockCount : Form
    {
        public frm_ManualStockCount()
        {
            InitializeComponent();

            cboSerial.Visible = true;
            lblSerial.Visible = true;
            String sDateTime = String.Empty;
            cboWarehouse.Focus();

            if (Common.countSession.sManualBarcode.Length > 22)
            {

                lblStation.Text = Common.countSession.sManualBarcode.Substring(0, 1);
                sDateTime = Common.countSession.sManualBarcode.Substring(1, 6);
                sDateTime += Common.countSession.sManualBarcode.Substring(7, 4);

                lblDate.Text = sDateTime.Substring(0, 2) + "/" + sDateTime.Substring(2, 2) + "/" + sDateTime.Substring(4, 2) + " " +
                                sDateTime.Substring(6, 2) + ":" + sDateTime.Substring(8, 2);

                //txtScanTime.Text = sBarcode.Substring(7, 4);

                //txtBag.Text = sBarcode.Substring(11, 4);

                lblBatchCode.Text = Common.countSession.sManualBarcode.Substring(16, 4);
                Common.countSession.sBatchCode = lblBatchCode.Text;

                lblWeight.Text = Common.countSession.sManualBarcode.Substring(20, 2);
            }

            lblSerialH.Text = "Serial : " + Common.countSession.sSerialCode;

            //Get possiblebatchcode
            // Common.countSession.sBatchCode = SQLite.GetSerialBatchCode(Common.countSession.sSerialCode);

            //Get StockMasterData
            //Then Build lblSerialH and lblWarehouseH
            DataTable dtStockMaster_StockCode = new DataTable();
            DataTable dtStockMaster_Warehouse = new DataTable();

            dtStockMaster_StockCode = SQLite.GetStockMaster_ManualStockCode(Common.countSession.sSerialCode);

            foreach (DataRow dr in dtStockMaster_StockCode.Rows)
            {
                cboSerial.Items.Add(dr.ItemArray.GetValue(0));
            }

            dtStockMaster_Warehouse = SQLite.GetStockMaster_ManualWarehouse(Common.countSession.sSerialCode);

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

            if (cboSerial.Items.Count == 0)
            {
                cboSerial.Visible = false;
                lblSerial.Visible = false;
            }

            if (Common.countSession.sCurrentWarehouse.Length > 0)
            {
                cboWarehouse.SelectedIndex = cboWarehouse.Items.IndexOf(Common.countSession.sCurrentWarehouse);
            }            
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ManualStockCount_KeyDown(object sender, KeyEventArgs e)
        {

            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
                if (txtQty.Text.Length > 0 && cboWarehouse.Text.Length > 0)
                {
                    var result = MessageBox.Show("Confirm that you counted " + txtQty.Text + " bags of " + cboSerial.Text + " in " + cboWarehouse.Text + "?", "Confirm Count", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    if (Common.IsNumeric(txtQty.Text))
                    {
                        if (result == DialogResult.Yes)
                        {
                            SQLite.InsertInventoryCount(DateTime.Now, Common.appSession.sUserIpk, cboSerial.Text, cboWarehouse.Text, Convert.ToInt32(txtQty.Text), Common.countSession.sSerialCode, lblBatchCode.Text, txtWeight.Text, lblStation.Text, 1);
                            SQLite.InsertMasterStockItem(Common.appSession.sArea, Common.countSession.sCurrentWarehouse, Common.countSession.sSerialCode, lblStation.Text, Common.countSession.sBatchCode);
                            this.Close();
                            if (Common.appSession.sPreferedMethod.Equals("Scan"))
                            {
                                frm_StockList frm_StockList = new frm_StockList();
                                frm_StockList.Show();
                            }
                            else
                            {
                                frm_ManualSerialCode frm_ManualSerialCode = new frm_ManualSerialCode();
                                frm_ManualSerialCode.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please ensure the quantity of bags is numeric.", "Non Numeric Quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                    }
                }

                else if (cboSerial.Text.Length == 0 && txtQty.Text.Length == 0)
                    MessageBox.Show("Please capture the relevant information.", "Missing Detail", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Escape))
            {
                // Escape\
                this.Close();
            }

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            //Save
            var result = MessageBox.Show("Confirm that you counted " + txtQty.Text + " bags of " + cboSerial.Text + " in " + cboWarehouse.Text + "?", "Confirm Count", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (txtQty.Text.Length > 0 && cboWarehouse.Text.Length > 0)
            {
                if (Common.IsNumeric(txtQty.Text))
                {
                    if (result == DialogResult.Yes)
                    {
                        SQLite.InsertInventoryCount(DateTime.Now, Common.appSession.sUserIpk, cboSerial.Text, cboWarehouse.Text, Convert.ToInt32(txtQty.Text), Common.countSession.sSerialCode, lblBatchCode.Text, txtWeight.Text, lblStation.Text, 1);
                        SQLite.InsertMasterStockItem(Common.appSession.sArea, Common.countSession.sCurrentWarehouse, Common.countSession.sSerialCode, lblStation.Text, Common.countSession.sBatchCode);

                        this.Close();
                        if (Common.appSession.sPreferedMethod.Equals("Scan"))
                        {
                            frm_StockList frm_StockList = new frm_StockList();
                            frm_StockList.Show();
                        }
                        else
                        {
                            frm_ManualSerialCode frm_ManualSerialCode = new frm_ManualSerialCode();
                            frm_ManualSerialCode.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please ensure the quantity of bags is numeric.", "Non Numeric Quantity", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                }
            }
            else if (cboSerial.Text.Length == 0 && txtQty.Text.Length == 0)
                MessageBox.Show("Please capture the relevant information.", "Missing Detail", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);

            
        }

        private void cboWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Common.countSession.sCurrentWarehouse = cboWarehouse.Text;
        }
    }
}