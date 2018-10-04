using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Printing_and_Engraving_Site
{
    public partial class userMessages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void ShowSuccessMessage(string message)
        {
            lblSuccessMessage.Text = message;
            phSuccessMessage.Visible = true;
        }

        public void ShowErrorMessage(string message)
        {
            lblErrorMessage.Text = message;
            phErrorMessage.Visible = true;
        }
    }
}