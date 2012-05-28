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
    public partial class NewActivity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdNew_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["OneMobileConnectionString"].ConnectionString);

            SqlCommand cmd = new SqlCommand();
            String sql = String.Empty;

            cmd.Connection = conn;

            conn.Open();

            try
            {
                sql = "UPDATE Version SET bActive = '0' WHERE sArea = '" + Area.Text + "';";
                for (int c = 0; c < 3; c++)
                {
                    if (c == 2)
                    {
                        sql += "INSERT INTO Version (sTeamName, sDescription, sArea, bActive) VALUES ('RECOUNT','" + Description.Text + "', '" + Area.Text + "', '1');";
                    }
                    else
                    {
                        sql += "INSERT INTO Version (sTeamName, sDescription,sArea, bActive) VALUES ('TEAM  " + Convert.ToInt16(c + 1) + "','" + Description.Text + "', '" + Area.Text + "', '1');";
                    }
                }

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

            lblPageMessage.Text = "New activity created sucessfully.";
            lblPageMessage.Visible = true;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StockTake.aspx");
        }
    }
}
