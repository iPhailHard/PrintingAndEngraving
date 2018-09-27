﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lgnUserLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            dsUsers UserLogin;

            string SecurityLevel;

            UserLogin = clsDataLayer.GetUsers(Server.MapPath("PrintingAndEngraving.accdb"), lgnUserLogin.UserName, lgnUserLogin.Password);

            if (UserLogin.Users.Count < 1)
            {
                e.Authenticated = false;
                return;
            }

            SecurityLevel = UserLogin.Users[0].UserRoleID.ToString();

            switch (SecurityLevel)
            {
                case "1":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, false);
                    Session["UserRoleID"] = "Admin";
                    break;
                case "2":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, false);
                    Session["UserRoleID"] = "Customer";
                    break;
                case "3":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, false);
                    Session["UserRoleID"] = "Supervisor";
                    break;
                case "4":
                    e.Authenticated = true;
                    FormsAuthentication.RedirectFromLoginPage(lgnUserLogin.UserName, false);
                    Session["UserRoleID"] = "Employee";
                    break;
                default:
                    e.Authenticated = false;
                    break;
            }


        }
    }
}