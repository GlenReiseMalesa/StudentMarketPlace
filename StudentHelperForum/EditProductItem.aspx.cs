using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class EditProductItem : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Int32.Parse(Request.QueryString.Get("index"));
            var GetSingleProduct = client.getGoodItem(id);


            ReturnProdName.InnerHtml = "Product Name : "+ GetSingleProduct.Goods_Name;
            ReturnProdPrice.InnerHtml = "Product Price : " + GetSingleProduct.Goods_Price;
            ReturnProdDescription.InnerHtml = "Product Description: " + GetSingleProduct.Goods_Description;
        }

        protected void Update_Good(object sender, EventArgs e)
        {
            id = Int32.Parse(Request.QueryString.Get("index"));
            bool good = client.editGoodItem(id, ProductName.Value, Int32.Parse(ProductPrice.Value), ProductDescription.Value);

            if (good == true)
            {
                Response.Redirect("EditProductItem.aspx?index=" + id);
            }
        }
    }
}