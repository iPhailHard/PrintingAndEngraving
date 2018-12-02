using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class frmCheckout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (GetUserRoleID() != "Admin" || GetUserRoleID() != "Supervisor" 
            //    || GetUserRoleID() != "Customer" || GetUserRoleID() != "Employee")
            //{
            //    Response.Redirect("~/Main Site/Login.aspx");
            //}
            if (Page.IsPostBack)
            {
                BindOrders();
            }
        }

        //public int _userID = Session["UserID"];
        public static DataRepository repo = new DataRepository();


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

        protected void btnPaymentSubmit_Click(object sender, EventArgs e)
        {
            Checkout checkout = new Checkout();
            Random random = new Random();

            checkout.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            checkout.DateCompleted = DateTime.Now;
            checkout.CardHolderAddress1 = txtCardAdd1.Text;
            if (!string.IsNullOrWhiteSpace(txtCardAdd2.Text))
            {
                checkout.CardHolderAddress2 = txtCardAdd2.Text;
            }
            checkout.CardHolderCity = txtCardCity.Text;
            checkout.CardHolderName = txtCardName.Text;
            checkout.CardHolderState = txtCardState.Text;
            checkout.CardHolderZip = txtCardZip.Text;
            checkout.CardNumber = txtCardNumber.Text;
            checkout.UserID = 3;
            checkout.OrderID = random.Next(100);

            if (repo.SavePaymentInformation(checkout))
            {
                //success message
            }
            else
            {
                //error message
            }
            ClearInformation();
        }

        private void ClearInformation()
        {
            txtCardAdd1.Text = string.Empty;
            txtCardAdd2.Text = string.Empty;
            txtCardCity.Text = string.Empty;
            txtCardName.Text = string.Empty;
            txtCardState.Text = string.Empty;
            txtCardZip.Text = string.Empty;
            txtTotalPrice.Text = string.Empty;
            txtCardNumber.Text = string.Empty;
        }

        private void BindOrders()
        {
            //List<Order> orders = repo.GetUserOrderByUserID(GetUserID());

            //if (orders.Where(q => q.UserID == GetUserID()).Select(q => q.IsOrderComplete).SingleOrDefault())
            //{
            //    Order order = orders.Where(q => q.UserID == GetUserID() && q.IsOrderComplete == true).Select(q => q).FirstOrDefault();

            //    txtTotalPrice.Text = order.TotalPrice.ToString();
            //}
            txtTotalPrice.Text = "312.17";
        }

        //private UserOrder GetUserOrderByUserID(int userID)
        //{
        //    UserOrder order = GetUserOrderByUserID(userID);

        //    return order;
        //}
    }
}