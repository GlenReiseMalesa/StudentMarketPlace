<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="StudentHelperForum.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
    <div class="row d-flex d-md-block flex-nowrap wrapper">
        <div class="col-md-2 float-left col-1 pl-0 pr-0 collapse width show" id="sidebar" >
            <div  class="list-group border-0 card bg-faded text-center text-md-left" style="width: 280px;height:900px;">
                <a style="margin-top:30px;" href="#" class="list-group-item d-inline-block collapsed" data-parent="#sidebar"><i class="fa fa-heart"></i> <span class="hidden-sm-down">Continue Shopping</span></a>
                <a style="margin-top:30px;" href="#" class="list-group-item d-inline-block collapsed" data-parent="#sidebar"><i class="fa fa-list"></i> <span class="hidden-sm-down">View Cart</span></a>
                <a style="margin-top:30px;" href="Sell.aspx" class="list-group-item d-inline-block collapsed" data-parent="#sidebar"><i class="fa fa-th"></i> <span class="hidden-sm-down">Sell New Product/Service</span></a>
                <a style="margin-top:30px;" href="RemoveItems.aspx" class="list-group-item d-inline-block collapsed" data-parent="#sidebar"><i class="fa fa-th"></i> <span class="hidden-sm-down">Remove&Edit Product/Service</span></a>
                <a style="margin-top:30px;" href="Invoice.aspx" class="list-group-item d-inline-block collapsed" data-parent="#sidebar"><i class="fa fa-calendar"></i> <span class="hidden-sm-down">History</span></a>
                <a href="Logout.aspx" style="margin-top:520px;" class="list-group-item d-inline-block collapsed" data-parent="#sidebar"><i class="fa fa-envelope"></i> <span class="hidden-sm-down">Logout</span></a>
        
            </div>
        </div>



        <main class="col-md-10 float-left col px-5 px-md-3 py-3 main">
            <a href="#" data-target="#sidebar" data-toggle="collapse"><i class="fa fa-navicon fa-lg py-2 p-1"></i></a>

                          <div  style="width:300px;margin-left:35%;margin-bottom:2%;">
                             <ul class="list-group">
                              <li class="list-group-item active" aria-current="true">Current User Details</li>
                              <li class="list-group-item" id="ReturnStudentName" runat="server"> </li>
                              <li class="list-group-item" id="ReturnStudentSurname" runat="server"> </li>
                              <li class="list-group-item" id="ReturnStudentEmail" runat="server"> </li>
                              <li class="list-group-item" id="ReturnStudentCellphone" runat="server">Cellphone : 07 8397421</li>
                              <li class="list-group-item" id="ReturnStudentAddress" runat="server">Address : oppirief,apk</li>
                              <li class="list-group-item" id="ReturnStudentPassword" runat="server">Password : dgdfg767dfg88</li>
                            </ul>        

                          </div>

            <a id="more"></a>
            <hr>
            <div style="width:300px;margin-left:35%;margin-top:5%;margin-bottom:10%;">

                              <form class="row contact_form" action="#" method="post" novalidate="novalidate" runat="server">

                                <div class="col-md-12 form-group p_star">
                                    <input type="text" class="form-control" id="StudentAddress" runat="server" name="StudentAddress" value=""
                                        placeholder="Student Address">
                                </div>

                                <div class="col-md-12 form-group p_star">
                                    <input type="text" class="form-control" id="CellphoneNumber" runat="server" name="CellphoneNumber" value=""
                                        placeholder="Cellphone Number">
                                </div>


                                <div class="col-md-12 form-group p_star">
                                    <input type="text" class="form-control" id="firstname" runat="server" name="firstname" value=""
                                        placeholder="First Name">
                                </div>

                                <div class="col-md-12 form-group p_star">
                                    <input type="text" class="form-control" id="lastname" runat="server" name="lastname" value=""
                                        placeholder="Last Name">
                                </div>
                                <div class="col-md-12 form-group p_star">
                                    <input type="text" class="form-control" id="email" name="email" runat="server" value=""
                                        placeholder="Personal E-mail">
                                </div>
                               
                                 <div class="col-md-12 form-group p_star">
                                    <input type="password" class="form-control" id="password" runat="server" name="password" value=""
                                        placeholder="Password">
                                </div>
                                <div class="col-md-12 form-group">
                                     <asp:Button class="btn_3" ID="Button4" OnClick="Update_Profile" runat="server" Text="Update Details" />
                                   </div>
                            </form>

        </div>
            <a id="flexbox"></a>
           


        </main>
    </div>
</div>


</asp:Content>
