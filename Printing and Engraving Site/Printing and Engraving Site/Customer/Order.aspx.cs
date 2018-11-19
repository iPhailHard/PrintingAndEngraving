using System;
using System.Collections.Generic;
using System.IO;
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
            if (!Page.IsPostBack)
            {
                BindItemInformation();
            }

        }

        public static DataRepository repo = new DataRepository();

        public static int _itemID { get; set; }

        private void BindItemInformation()
        {
            List<Item> items = repo.GetItems();

            mvOrderDetails.SetActiveView(vwOrderItems);

            repItemInformation.DataSource = items;
            repItemInformation.DataBind();
        }

        protected void repItemInformation_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            ImageButton button = e.Item.FindControl("ibImage") as ImageButton;

            _itemID = Convert.ToInt32(button.CommandArgument);
            ucOrderDetails.BindItemDetailsToOrder(_itemID);

            //button.ImageUrl = GetImage(repo.GetImageByItemID(_itemID).CatalogImage).ToString();

            

            mvOrderDetails.SetActiveView(orderDetails);
            

        }

        //public static void ViewSwitchBack()
        //{
        //    ImageButton button = repItemInformation.FindControl()

        //    mvOrderDetails.SetActiveView(vwOrderItems);
        //}

        private void LoadImages()
        {
            Image image = repo.GetImageByItemID(_itemID);

            GetImage(image.CatalogImage);
        }

        public static System.Drawing.Image GetImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            return returnImage;
        }

        //FileByte[] BindImageByItemID(int itemID)
        //{
        //    return repo.GetImageByItemID(itemID);
        //}

        protected void ibImage_Click(object sender, EventArgs e)
        {
            mvOrderDetails.SetActiveView(orderDetails);
        }

        protected void buttonBack_Click(object sender, EventArgs e)
        {
            mvOrderDetails.SetActiveView(vwOrderItems);
        }

        protected void btnAddItemToOrder_Click(object sender, EventArgs e)
        {
            mvOrderDetails.SetActiveView(vwOrderConfirmation);
            ucOrderConfirmation.BindItemToConfirmation(_itemID);
        }

        public void ShowSuccessMessage(string message)
        {
            lblSuccessMessage.Text = message;
        }

        public void ShowErrorMessage(string message)
        {
            lblErrorMessage.Text = message;
        }

        protected void btnContinueShopping_Click(object sender, EventArgs e)
        {
            ShowErrorMessage("This has not been implemented yet, please try again later.");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            ShowSuccessMessage("This would be displayed whenever a successful order was placed.");
        }
    }
}