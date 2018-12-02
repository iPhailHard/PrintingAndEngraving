using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Printing_and_Engraving_Site.Employee
{
    public partial class imgLoader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = "1";
            byte[] bytes = (byte[])GetData("SELECT TOP (1) ImageID,CatalogImage,ItemID,ImageName FROM Images where ImageID =" + id).Rows[0]["Data"];
            string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            imgTest.ImageUrl = "data:image/png;base64," + base64String;
        }

        protected void FetchImage(object sender, EventArgs e)
        {

        }


        private DataTable GetData(string query)
        {
            string constr = ConfigurationManager.ConnectionStrings["PrintingAndEngravingEntities"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        sda.Fill(dt);
                    }
                }
                return dt;
            }
        }
    }
}