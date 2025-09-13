<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/CustomerMaster.Master" AutoEventWireup="true" CodeBehind="PendingRental.aspx.cs" Inherits="CarBooking.View.Customer.PendingRents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col"></div>
            <div class="col">
                <h2 style="color:black; ">Your Pending Rentals</h2>
            </div>
            <div class="col"></div>
        </div>
        <div class="row">
          
            
                <div style="margin-left:30vw;">
                    <form runat="server">
                <div class="col-md-8">
               <asp:GridView runat="server" ID="CarList" Class="table table-hover" >
                   <AlternatingRowStyle BackColor="#FFCC00" ForeColor="White" />

               </asp:GridView>
            </div>
                        </form>
                    </div>
            <div class="col-lg-2"></div>
        </div>
    </div>
</asp:Content>
