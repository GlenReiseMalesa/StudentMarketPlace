using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class UpdateCartProduct : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        int id = 0;
        int sNum = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
        

            if (Session["userId"] != null)
            {
                Add_to_div.Visible = true;

            }

          //  id = Int32.Parse(Request.QueryString.Get("index"));


        }
        public void Adding_Cart(object sender, EventArgs e)
        {


            id = Int32.Parse(Request.QueryString.Get("index"));
            int quantity = Int32.Parse(quantity_input.Value);
            var isDeleted = client.Update_Cart_Product (id, quantity);

               if (isDeleted != null)
               {
                   Response.Redirect("Cart.aspx");

               }

        }
    }
}