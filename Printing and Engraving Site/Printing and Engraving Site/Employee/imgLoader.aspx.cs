using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Text;
using System.Drawing.Imaging;
using System.IO;

namespace Printing_and_Engraving_Site.Employee
{
    public partial class imgLoader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string id = "1";
            GetData("SELECT ImageName, CatalogImage FROM Images where ImageID =" + id);

        }

        protected void FetchImage(object sender, EventArgs e)
        {

        }


        private void GetData(string query)
        {
            string constr = ConfigurationManager.ConnectionStrings["PrintingAndEngravingEntities"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader sda = cmd.ExecuteReader();



                sda.Read();
                byte[] bytes = (byte[])sda["CatalogImage"];
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                //imgTest.ImageUrl = "data:image/png;base64," + base64String;

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    this.imgTest.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());
                }

                sda.Close();
                con.Close();


            }
        }
    }
}