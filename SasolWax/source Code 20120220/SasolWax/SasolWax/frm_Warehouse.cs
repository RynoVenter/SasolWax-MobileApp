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
    public partial class frm_Warehouse : Form
    {
        private String sArea = String.Empty;

        public frm_Warehouse(String sArea)
        {
            InitializeComponent();
            this.sArea = sArea;
            lbWarehouses.Items.Clear();
            DataTable dtWarehouse = SQLite.GetLocalWarehouses(sArea);

            foreach (DataRow dr in dtWarehouse.Rows)
            {
                lbWarehouses.Items.Add(dr.ItemArray.GetValue(2));
            }
        }

        private void lbWarehouses_KeyPress(object sender, KeyPressEventArgs e)
        {
            frm_StockList frm_StockList = new frm_StockList();
            frm_StockList.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}