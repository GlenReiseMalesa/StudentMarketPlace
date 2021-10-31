using StudentHelperForum.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentHelperForum
{
    public partial class UserProfile : System.Web.UI.Page
    {
        int id = 0;
        Service1Client client = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            id = Convert.ToInt32(Session["userId"]);
            dynamic Student = client.getSingleStudent(id);


            ReturnStudentName.InnerHtml = "FirstName: " + Student.Student_Name; 
             ReturnStudentSurname.InnerHtml = "LastName : " + Student.Student_Surname; 
              ReturnStudentEmail.InnerHtml = "Personal Email: " + Student.Student_Personal_Email;

            ReturnStudentCellphone.InnerHtml = "Cellphone : " + Student.Student_Cellphone_Number;
            ReturnStudentAddress.InnerHtml = "Address : " + Student.Student_Address;
            ReturnStudentPassword.InnerHtml = "Password : " + Student.Password;




        }



        protected void Update_Profile(object sender, EventArgs e)
        {

            bool user = client.UpdateUserDetails(id, StudentAddress.Value, id+"@student.uj.ac.za", email.Value, Convert.ToInt32(CellphoneNumber.Value), firstname.Value, lastname.Value, password.Value);
            if (user == true)
            {
                Response.Redirect("UserProfile.aspx");
            }
        }
}
}