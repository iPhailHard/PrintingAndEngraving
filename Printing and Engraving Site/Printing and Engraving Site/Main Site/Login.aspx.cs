using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

        #region database class

        //public IQueryable<Employee> Employee_GetData()
        //{
        //    EmployeeDataModel emp = new EmployeeDataModel();
        //    var query = emp.Employees.Include(s => s.)
        //}

        #endregion

        protected void lgnUserLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            //if (true)
            //{
            //    return; //TODO: Implement
            //}

            SqlConnection conn = new SqlConnection("data source=printingandengraving.database.windows.net;initial catalog=PrintingAndEngraving;persist security info=True;user id=bjaune;password=ThisIsMyPassWord@AZURE1;");
            // Create a command to extract the required data and assign it the connection string
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", conn);
            cmd.CommandType = CommandType.Text;
            // Create a DataAdapter to run the command and fill the DataTable
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();

            string user = lgnUserLogin.UserName.ToString();
            string password = lgnUserLogin.Password.ToString();

            foreach (DataRow row in dt.Rows)
            {
                employees.Where(a => a.UserName == user && a.UserPassword == password)
                        .Select(p => p.EmployeeID).ToList();
            }



            employee = employees.Where(a => a.UserName == user && a.UserPassword == password)
                        .Select(p => p).FirstOrDefault();
            

            
            

            string SecurityLevel;

            //UserLogin = clsDataLayer.GetUsers(Server.MapPath("~\\PrintingAndEngraving.accdb"), lgnUserLogin.UserName, lgnUserLogin.Password);


            if (employees.Where(x => x.UserName == user).Count() < 1)
            {
                e.Authenticated = false;
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(employees.Where(x => x.UserPassword == password).Select(y => y.UserPassword).SingleOrDefault()))
                {
                    e.Authenticated = false;
                    return;
                }
                SecurityLevel = employees.Where(x => x.UserName == user && x.UserPassword == password).Select(s => s.UserRoleID).FirstOrDefault().ToString();
            }

           

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