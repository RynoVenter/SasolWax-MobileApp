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
    public partial class Accounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NewUser_Click(object sender, EventArgs e)
        {
            
        }

        protected void UserReset_Click(object sender, EventArgs e)
        {
        }

        protected void btnNewAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NewAccount.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ResetPassword.aspx");
        }

    }
}
