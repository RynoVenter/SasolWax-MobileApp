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

namespace Sasol_WaxOMC
{
    public partial class OMC : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccounts_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Accounts.aspx");
        }

        protected void btnReports_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Reports.aspx");
        }

        protected void btnStockTake_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StockTake.aspx");
        }
    }
}
