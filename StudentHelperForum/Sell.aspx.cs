using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class Sell : System.Web.UI.Page
    {
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            


     
        
        
        }

        public string DefaultFileName = "assets\\img\\akatsuki\\";
        public void Adding_PoS(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["userId"]);

            string filename ="";    

            try
            {
                FileUploader.SaveAs(Server.MapPath(DefaultFileName) +
                     FileUploader.FileName);

                /*              Label1.Text = "File name: " +
                                   FileUploader.PostedFile.FileName + "<br>" +
                                   FileUploader.PostedFile.ContentLength + " kb<br>" +
                                   "Content type: " +
                                   FileUploader.PostedFile.ContentType + "<br><b>Uploaded Successfully";*/

                filename = FileUploader.PostedFile.FileName;

            }
            catch (Exception ex)
            {
                
            }



            if (sell.Value == "Product")
            {
                client.addGood(id, ProductName.Value, Int32.Parse(Price.Value), description.Value, DefaultFileName + filename, Catergory.Value);
            }
            else if(sell.Value == "Service")
            {
                client.addService(Convert.ToInt32(Session["userId"]), ProductName.Value, Int32.Parse(Price.Value), description.Value, DefaultFileName + filename, Catergory.Value);

            }

        }
    }
}