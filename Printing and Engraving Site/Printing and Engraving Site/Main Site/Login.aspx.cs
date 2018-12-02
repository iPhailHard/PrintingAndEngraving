using System;
using System.Collections.Generic;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string _UserRoleID = "";
        public static int _UserID;

        protected void lgnUserLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {

            DataRepository user = new DataRepository();

            List<User> users = user.GetUsers();
            string SecurityLevel = Convert.ToString(user.GetUserByPasswordAndUserName(lgnUserLogin.UserName.ToString(), lgnUserLogin.Password.ToString()));
            int currentUserID = user.GetUserIDByPasswordAndUserName(lgnUserLogin.UserName.ToString(), lgnUserLogin.Password.ToString());
            

            //if (userPermissions.Users.Count < 1)
            //{
            //    e.Authenticated = false;
            //    return;
            //}

            switch (SecurityLevel)
            {
                case "1":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    Response.Redirect("~/Main Site/Home.aspx");
                    Session["UserRoleID"] = "Admin";
                    _UserRoleID = "Admin";
                    Session["UserID"] = currentUserID;
                    _UserID = currentUserID;
                    //FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    //Response.Redirect(Request.UrlReferrer.ToString());

                    break;
                case "2":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    Response.Redirect("~/Main Site/Home.aspx");

                    Session["UserRoleID"] = "Customer";
                    _UserRoleID = "Customer";
                    Session["UserID"] = currentUserID;
                    _UserID = currentUserID;
                    //FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    //Response.Redirect(Request.UrlReferrer.ToString());

                    break;
                case "3":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    Response.Redirect("~/Main Site/Home.aspx");

                    Session["UserRoleID"] = "Supervisor";
                    _UserRoleID = "Supervisor";
                    Session["UserID"] = currentUserID;
                    _UserID = currentUserID;
                    //FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    //Response.Redirect(Request.UrlReferrer.ToString());

                    break;
                case "4":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    Response.Redirect("~/Main Site/Home.aspx");

                    Session["UserRoleID"] = "Employee";
                    _UserRoleID = "Employee";
                    Session["UserID"] = currentUserID;
                    _UserID = currentUserID;
                    //FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, true);
                    //Response.Redirect(Request.UrlReferrer.ToString());

                    break;
                default:
                    _UserRoleID = "Guest";
                    e.Authenticated = false;
                    break;
            }

        }

    }
}