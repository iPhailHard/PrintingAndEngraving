using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site.Customer.UserControls
{
    public partial class ucOrderDetails : System.Web.UI.UserControl
    {
        public static int _itemID;
        //{
        //    get
        //    {
        //        if (_itemID != null)
        //        {
        //            return _itemID;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //    set
        //    {
        //        _itemID = (int)ViewState["ItemID"];
        //    }
        //}

        public static DataRepository data = new DataRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (GetUserRoleID() != "Admin" || GetUserRoleID() != "Supervisor"
            //    || GetUserRoleID() != "Customer" || GetUserRoleID() != "Employee")
            //{
            //    Response.Redirect("~/Main Site/Login.aspx");
            //}
        }

        public void BindItemDetailsToOrder(int ItemID)
        {
            _itemID = ItemID;
            //LoadImages();
            LoadItemDetails();
        }

        private void LoadImages()
        {
            Image image = data.GetImageByItemID(_itemID);

            GetImage(image.CatalogImage);
        }

        public static System.Drawing.Image GetImage(byte[] byteArrayIn)
        {
            var ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);

            return returnImage;
        }

        //private void Stringssss()
        //{
        //    StringBuilder stringBuilder = null;

        //    stringBuilder.Append("string.stringystring");
        //    stringBuilder.Append("stringysytring.String");
        //}

        private void LoadItemDetails()
        {
            Item item = data.GetItems().Where(q => q.ItemID == _itemID).Select(q => q).SingleOrDefault();

            if (item != null)
            {
                lblItemDescription.Text = item.ItemDescription.ToString();
                lblItemCode.Text = item.ItemCode.ToString();
                lblItemName.Text = item.ItemName.ToString();
                lblItemPrice.Text = item.ItemPrice.ToString();
            }
            else
            {
                //return error message
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
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