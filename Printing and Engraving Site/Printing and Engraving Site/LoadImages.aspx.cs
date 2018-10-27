using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class LoadImages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary> 
        /// NOTE: This points to your database server 
        /// </summary> 
        //private static string databaseServer = "printingandengraving.database.windows.net";
        //private static string your_username = "bjaune";
        //private static string your_password = "ThisIsMyPassWord@AZURE1";
        ///// <summary>         /// NOTE: Name of database containing required tables 
        ///// </summary> 
        //static string defaultCatalog = "";
        //string _ConnectionString = $"Server=tcp:printingandengraving.database.windows.net,1433;Initial Catalog=PrintingAndEngraving;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string str = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Images/" + str));
                string Image = "~/Images/" + str.ToString();
                string name = TextBox1.Text;
                int itemID = 0 /*= 29*/;
                int ImageID = 0 /*= 29*/;




                SqlConnection con = new SqlConnection(@"Server=tcp:printingandengraving.database.windows.net,1433;Initial Catalog=PrintingAndEngraving;Persist Security Info=False;User ID=bjaune;Password=ThisIsMyPassWord@AZURE1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                SqlCommand cmd = new SqlCommand("insert into Images (ImageID, CatalogImage, ItemID, ImageName) values(@ImageID,@CatalogImage,@ItemID,@ImageName)", con);
                cmd.Parameters.AddWithValue("@ImageName", name);
                cmd.Parameters.AddWithValue("@CatalogImage", System.Text.Encoding.ASCII.GetBytes(Image));
                cmd.Parameters.AddWithValue("@ItemID", itemID);
                cmd.Parameters.AddWithValue("@ImageID", ImageID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Label1.Text = "Image Uploaded";
                Label1.ForeColor = System.Drawing.Color.ForestGreen;

            }

            else
            {
                Label1.Text = "Please Upload your Image";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}