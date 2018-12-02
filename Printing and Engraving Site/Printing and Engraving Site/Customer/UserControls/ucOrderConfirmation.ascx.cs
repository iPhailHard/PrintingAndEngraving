using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site.Customer.UserControls
{
    public partial class ucOrderConfirmation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
    //        if (GetUserRoleID() != "Admin" || GetUserRoleID() != "Supervisor"
    //|| GetUserRoleID() != "Customer" || GetUserRoleID() != "Employee")
    //        {
    //            Response.Redirect("~/Main Site/Login.aspx");
    //        }

        }

        public static int _itemID { get; set; }

        public static DataRepository _data = new DataRepository();


        public void BindItemToConfirmation(int ItemID)
        {
            _itemID = ItemID;
            BindDataToFields();
        }

        private void BindDataToFields()
        {
            _data.GetItems();

            Item item = _data.GetItems().Where(q => q.ItemID == _itemID)
                            .Select(q => q)
                            .SingleOrDefault();
            int itemQuantity = 1; //TODO: implement item quantity and then have it multiply the ItemQuantity text by the item price for an item total

            txtItemCode.Text = item.ItemCode.ToString();
            txtItemName.Text = item.ItemName.ToString();
            txtItemPrice.Text = item.ItemPrice.ToString();
            txtItemQuantity.Text = "1";
            txtItemTotal.Text = Convert.ToString(item.ItemPrice * itemQuantity);
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