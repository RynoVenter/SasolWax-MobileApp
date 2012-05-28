using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Sasol_WaxOMC.Utilities
{
    public class Common
    {
        public class CurrentSearch
        {
            public String serial = String.Empty;
            public String area = String.Empty;
            public String warehouse = String.Empty;
        }

        public class CurrentUser
        {
            public String user = String.Empty;
        }
    }
}
