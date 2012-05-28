using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;


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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Logon_Click(object sender, EventArgs e)
        {
            DataTable dtUser = new DataTable();

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT sPass FROM Users WHERE sUser = '" + UserName.Text + "'", conn);

                da.Fill(dtUser);
            }
            catch (System.Exception ex)
            {  }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            if (dtUser.Rows.Count > 0)
            {
                DataRow dr = dtUser.Rows[0];

                    if (dr.ItemArray.GetValue(0).ToString() == Password.Text)
                    {
                        Response.Redirect("~/Reports.aspx");
                    }
                    else
                    {
                        lblWarning.Text = "The password is incorrect, please retype and try again.";
                        lblWarning.Visible = true;
                        Password.Text = "";
                        Password.Focus();
                    }
                
            }
            else
            {
                lblWarning.Text = "The username is incorrect, please retype and try again.";
                lblWarning.Visible = true;
                UserName.Text = "";
                UserName.Focus();
            }
        }

        protected void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
