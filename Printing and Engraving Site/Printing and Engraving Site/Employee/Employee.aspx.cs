using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (GetUserRoleID() != "Admin" || GetUserRoleID() != "Supervisor"
            //   || GetUserRoleID() != "Employee")
            //{
            //    Response.Redirect("~/Main Site/Login.aspx");
            //}

        }

        private int GetUserID()
        {
            int userID = Login._UserID;

            return userID;
        }

        private string GetUserRoleID()
        {
            string userRoleID = Login._UserRoleID;

            return userRoleID;
        }
    }
}