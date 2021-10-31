<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RemoveItems.aspx.cs" Inherits="StudentHelperForum.RemoveItems" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     
        <section class="login_part section_padding" style="background-color:lavenderblush">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-lg-6 col-md-6">
                    <div class="login_part_text text-center">
                        <div class="login_part_text_iner">
                            <h2>Remove from our Shop?</h2>
                            
                        </div>
                    </div>
                </div>
                
           

             <div class="col-lg-6 col-md-6" >
                  <div class="table-responsive">
          <table class="table">
            <thead>
              <tr>
                <th scope="col">Name</th>
                 <th scope="col">Price</th>
                <th scope="col">Delete</th>   
                  <th scope="col">Edit</th> 
               </tr>
            </thead>
            <tbody id="Get_Itmes" runat="server">
                
    

       

            </tbody>
          </table>
                    
                </div>
                 </div>
                 </div>
        </div>
    </section>
    <!--================Register to sell a Product end =================-->
</asp:Content>
