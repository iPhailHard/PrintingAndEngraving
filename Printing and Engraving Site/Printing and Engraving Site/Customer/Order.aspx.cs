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
            //if (GetUserRoleID() != "Admin" || GetUserRoleID() != "Supervisor"
            //    || GetUserRoleID() != "Customer" || GetUserRoleID() != "Employee")
            //{
            //    Response.Redirect("~/Main Site/Login.aspx");
            //}

            //if ((string)Session["UserRoleID"] != "Admin" || (string)Session["UserRoleID"] != "Supervisor"
            //    || (string)Session["UserRoleID"] != "Customer" || (string)Session["UserRoleID"] != "Employee")
            //{
            //    Response.Redirect("~/Main Site/Login.aspx");
            //}

            if (!Page.IsPostBack)
            {
                BindItemInformation();
            }

        }

        public static DataRepository repo = new DataRepository();
        //public static int _userID = (int)(Session["UserID"]);
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
            Order order = new Order();

            order.

            Response.Redirect("~/Order.aspx");
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {

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