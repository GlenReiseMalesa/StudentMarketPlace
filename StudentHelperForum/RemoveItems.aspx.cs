using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class RemoveItems : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            dynamic Goods = client.getGoodsList();
            dynamic Services = client.getServicesList();
            string display = " ";

            int userId = Convert.ToInt32(Session["userId"]);

            foreach (Good good in Goods)
            {
                if (userId.Equals(good.Student_Number))
                {
                display += "<tr>";
                display += "<td>";
                display += good.Goods_Name;
                display += "</td>";

                display += "<td>$";
                display += good.Goods_Price;
                display += "</td>";

                display += "<td>";
                display += "<div class='cupon_text' >";
                display += "<a class='btn_1' style='background-color:red;' href='RemoveProductItem.aspx?index=" + good.Goods_ID+ "'>X</a>";
                display += "</div>";
                display += "</td>";

                    display += "<td>";
                    display += "<div class='cupon_text' >";
                    display += "<a class='btn_1' style='background-color:blue;' href='EditProductItem.aspx?index=" + good.Goods_ID + "'>Edit Good</a>";
                    display += "</div>";
                    display += "</td>";

                    display += "</tr>";
            }

            }
            foreach (Service service in Services)
            {
                if (userId.Equals(service.Student_Number))
                {
                    display += "<tr>";
                    display += "<td>";
                    display += service.Services_Name;
                    display += "</td>";

                    display += "<td>$";
                    display += service.Services_Price;
                    display += "</td>";

                    display += "<td>";
                    display += "<div class='cupon_text' >";
                    display += "<a class='btn_1' style='background-color:red;' href='RemoveServiceItem.aspx?index=" + service.Services_ID + "'>X</a>";
                    display += "</div>";
                    display += "</td>";

                    display += "<td>";
                    display += "<div class='cupon_text' >";
                    display += "<a class='btn_1' style='background-color:blue;' href='EditServiceItem.aspx?index=" + service.Services_ID + "'>Edit Service</a>";
                    display += "</div>";
                    display += "</td>";

                    display += "</tr>";
                }
            }
            Get_Itmes.InnerHtml = display;



            }
    }
}