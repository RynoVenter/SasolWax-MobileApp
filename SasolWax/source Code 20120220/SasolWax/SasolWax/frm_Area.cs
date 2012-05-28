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
    public partial class frm_Area : Form
    {
        public frm_Area()
        {
            InitializeComponent();

            lbAreas.Items.Clear();
            DataSet dsArea = SQLite.GetAreas();

            foreach (DataRow dr in dsArea.Tables[0].Rows)
            {
                lbAreas.Items.Add(dr.ItemArray.GetValue(1));
            }

        }

        private void lbAreas_KeyPress(object sender, KeyPressEventArgs e)
        {

            Common.appSession.sArea = lbAreas.GetItemText(lbAreas.SelectedItem);
            frm_MainMenu frm_MainMenu = new frm_MainMenu();
            frm_MainMenu.Show();

            this.Close();

        }

        private void lbAreas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}