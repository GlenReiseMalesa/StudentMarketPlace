using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class RemoveService : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

            var isDeleted = client.deleteServiceCart(Convert.ToInt32(Request.QueryString["index"].ToString()));

            if(isDeleted != null)
            {
                Response.Redirect("Cart.aspx");
            }
        }
    }
}