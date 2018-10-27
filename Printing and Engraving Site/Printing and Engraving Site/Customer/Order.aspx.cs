using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["UserRoleID"] != "Admin")
            //{
            //    Response.Redirect("Login.aspx");
            //}

            BindItemInformation();

        }

        public static DataRepository repo = new DataRepository();

        public static int _itemID { get; set; }

        private void BindItemInformation()
        {
            List<Item> items = repo.GetItems();

            repItemInformation.DataSource = items;
            repItemInformation.DataBind();
        }

        protected void repItemInformation_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            ImageButton button = e.Item.FindControl("lbItemImage") as ImageButton;

            _itemID = Convert.ToInt32(button.CommandArgument);
            //BindItemDetailsToOrder(_itemID);

            button.ImageUrl = repo.GetImageByItemID(_itemID).CatalogImage.ToString();
        }

        //FileByte[] BindImageByItemID(int itemID)
        //{
        //    return repo.GetImageByItemID(itemID);
        //}

        protected void ibImage_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderDetails.aspx");
        }
    }
}