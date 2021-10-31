using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class EditServiceItem : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Int32.Parse(Request.QueryString.Get("index"));
            var GetSingleService = client.getServiceItem(id);


            ReturnServiceName.InnerHtml = "Service Name : " + GetSingleService.Services_Name;
            ReturnServicePrice.InnerHtml = "Service Price : " + GetSingleService.Services_Price;
            ReturnServiceDescription.InnerHtml = "Service Description: " + GetSingleService.Services_Description;
        }


        protected void Update_Service(object sender, EventArgs e)
        {
            id = Int32.Parse(Request.QueryString.Get("index"));
            bool service = client.editServiceItem(id, ServiceName.Value, Int32.Parse(ServicePrice.Value), ServiceDescription.Value);
            
            if (service == true)
            {
                Response.Redirect("EditServiceItem.aspx?index="+id);
            }
        }
    }
}