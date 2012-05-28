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
using Sasol_WaxOMC.Utilities;

            


namespace Sasol_WaxOMC
{
    public partial class Reports : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM " + lblViewName.Text + " WHERE sArea = '" + cmbArea.SelectedItem.ToString().ToUpper() + "';", conn);

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

        protected void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            DataTable dtViews = new DataTable();

            conn.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Wax_Reports WHERE sReportName = '" + cmbReports.SelectedItem.ToString() + "';", conn);

                da.Fill(dtViews);
            }
            catch (System.Exception ex)
            {  }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            foreach (DataRow dr in dtViews.Rows)
            {

                lblViewName.Text = dr.ItemArray.GetValue(2).ToString();
                break;
            }

            lblPageMessage.Text = "";
            lblPageMessage.Visible = true;
        }

        protected void cmbReports_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnMCorrection_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ManualCorrection.aspx");
        }   
    }
}
