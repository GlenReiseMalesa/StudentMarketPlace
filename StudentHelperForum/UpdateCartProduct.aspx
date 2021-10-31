<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateCartProduct.aspx.cs" Inherits="StudentHelperForum.UpdateCartProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row justify-content-center" style="margin-top:5%;  margin-bottom:5%">
       <div class="col-lg-8">
          <div class="single_product_text text-center" >
              <form runat="server">
            <div class="card_area" >
                <div class="product_count_area">
                    <p>Quantity</p>
                    <div class="product_count d-inline-block">
                        <span class="product_count_item inumber-decrement"> <i class="ti-minus"></i></span>
                        <input class="product_count_item input-number" type="text" value="1" min="0" max="10" id="quantity_input" runat="server">
                        <span class="product_count_item number-increment"> <i class="ti-plus"></i></span>
                    </div>
                   
                </div>
              <div class="add_to_cart" id="Add_to_div" runat="server" Visible="false">
                  <asp:Button class="btn_3" ID="Button4" OnClick="Adding_Cart" runat="server" Text="UpDate Cart" /> 
              </div>
            </div>
                  </form>
          </div>
        </div>
       </div>  
</asp:Content>
