using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class Catalog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((string)Session["UserRoleID"] != "Admin" || (string)Session["UserRoleID"] != "Customer"
            //    || (string)Session["UserRoleID"] != "Supervisor" || (string)Session["UserRoleID"] != "Employee")
            //{
            //    Response.Redirect("~/Main Site/Login.aspx");
            //}

        }
    }
}