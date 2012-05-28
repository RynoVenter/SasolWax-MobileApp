using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.ComponentModel;

using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text;

namespace Sasol_WaxOMC
{
    public partial class ManualCorrection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            GridViewReports.DataSource = "";

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            DataTable dtReportView = new DataTable();

            conn.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM InventoryCount WHERE sWarehouse = '" + cmbArea.SelectedItem.ToString().ToUpper() + "' AND sSerial LIKE '%" + txtSerialCode.Text + "%';", conn);

                da.Fill(dtReportView);
            }
            catch (System.Exception ex)
            { }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            GridViewReports.DataSource = dtReportView;

            GridViewReports.DataBind();



            lblPageMessage.Text = "";
            lblPageMessage.Visible = false;
        }

        protected void GridViewReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow selRow = GridViewReports.SelectedRow;

            
        }
    }
}
