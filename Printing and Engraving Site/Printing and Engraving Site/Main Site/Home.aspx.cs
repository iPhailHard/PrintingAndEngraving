using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserRoleID"] != "Admin" || Session["UserRoleID"] != || Session["UserRoleID"] != || Session["UserRoleID"] != "Employee")
            //{
            //    Response.Redirect("Login.aspx");
            //}
           
            if (!Page.IsPostBack)
            {
                
            }
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