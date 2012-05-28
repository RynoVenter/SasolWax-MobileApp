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

using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Text;

namespace Sasol_WaxOMC
{
    public partial class ResetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UserReset_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand();
            String sql = String.Empty;

            cmd.Connection = conn;

            conn.Open();

            try
            {
                sql = "UPDATE Users SET sPass = '" + Password.Text + "' WHERE sUser = '" + UserName.Text + "';";

                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            { Response.Write(ex); }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            lblPageMessage.Text = "Password reset successful.";
            lblPageMessage.Visible = true;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Accounts.aspx");
        }
    }
}
