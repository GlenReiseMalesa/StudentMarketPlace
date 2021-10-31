<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="StudentHelperForum.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--================Cart Area =================-->
  <section class="cart_area section_padding">
    <div class="container">
      <div class="cart_inner">
        <div class="table-responsive">
          <table class="table">
            <thead>
              <tr>
                <th scope="col">Product</th>
                <th scope="col">Price</th>
                <th scope="col">Quantity</th>
                <th scope="col">Total</th>
                 <th scope="col">Update</th>
                <th scope="col"></th>
              </tr>
            </thead>
            <tbody id="Return_Cart" runat="server">
                
    

       

            </tbody>
          </table>
          <div class="checkout_btn_inner float-right" id="checkoutBtn" runat="server">

          </div>
        </div>
      </div>
        </div>
  </section>
  <!--================End Cart Area =================-->
</asp:Content>
